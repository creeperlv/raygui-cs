using System.Buffers;
using System.Runtime.CompilerServices;

namespace raygui_cs
{
    public static class ZeroAllocationStringUtils
    {
        /// <summary>
        /// Split a span to an range array.
        /// </summary>
        /// <param name="input"></param>
        /// <param name="separators"></param>
        /// <returns></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (int, (int, int) [ ]) Split(this ReadOnlySpan<char> input , params char [ ] separators)
        {
            (int, int) [ ] ranges = ArrayPool<(int, int)>.Shared.Rent(Raygui.RAYGUI_MAX_TEXT_LINES);
            int HitCount = 0;
            int LastHit = -1;

            for (int i = 0 ; i < input.Length ; i++)
            {
                char c = input [ i ];
                foreach (var item in separators)
                {
                    if (c == item)
                    {
                        HitCount++;
                        ranges [ HitCount - 1 ] = (LastHit + 1, i - LastHit-1);
                        LastHit = i;
                    }
                }
            }
            //if (LastHit != input.Length - 1)
            {
                HitCount++;
                ranges [ HitCount - 1 ] = (LastHit + 1, input.Length- LastHit-1);
            }
            return (HitCount, ranges);
        }
        /// <summary>
        /// Split a span to an range array.
        /// </summary>
        /// <param name="input"></param>
        /// <param name="separators"></param>
        /// <returns>(Count,(Start,Length)[])</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (int, (int, int) [ ]) SplitSingleChar(this ReadOnlySpan<char> input , char item)
        {
            (int, int) [ ] ranges = ArrayPool<(int, int)>.Shared.Rent(Raygui.RAYGUI_MAX_TEXT_LINES);
            int HitCount = 0;
            int LastHit = -1;

            for (int i = 0 ; i < input.Length ; i++)
            {
                char c = input [ i ];
                {
                    if (c == item)
                    {
                        HitCount++;
                        ranges [ HitCount - 1 ] = (LastHit + 1, i - LastHit-1);
                        LastHit = i;
                    }
                }
            }
            {
                HitCount++;
                ranges [ HitCount - 1 ] = (LastHit + 1, input.Length- LastHit-1);
            }

            return (HitCount, ranges);
        }
    }
}
