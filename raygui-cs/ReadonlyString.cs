using System.Runtime.CompilerServices;

namespace raygui_cs
{
    /// <summary>
    /// Act like a string pointer to help reduce heap allocation.
    /// </summary>
    public struct ReadonlyString
    {
        public readonly static ReadonlyString NULL = new() { Ref = null };
        public string Ref;
        public int Start;
        public int Length;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ReadonlyString(string string_value , int start , int length)
        {
            Ref = string_value;
            Start = start;
            Length = length;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ReadonlyString()
        {
            Ref = null;
            Start = 0;
            Length = 0;
        }
        public char this [ int index ]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return Ref [ index + Start ];
            }
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ReadOnlySpan<char> AsReadOnlySpan() => (ReadOnlySpan<char>)this;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator ReadonlyString(string s) => new ReadonlyString { Ref = s , Start = 0 , Length = s.Length };
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator ReadOnlySpan<char>(ReadonlyString s)
        {
            if (s.Start + s.Length > s.Ref.Length)
            {
                throw new IndexOutOfRangeException();
            }
            return ((ReadOnlySpan<char>)s.Ref).Slice(s.Start , s.Length);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool IsNull() => Ref == null;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool IsNotNull()=>Ref!=null;
    }
}
