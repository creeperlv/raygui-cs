using System.Runtime.InteropServices;

namespace raygui_cs
{
    public static class StreamUtilities
    {
        public static int ReadInt32(this Stream stream , Span<byte> Byte4Buffer)
        {
            stream.Read(Byte4Buffer);
            return BitConverter.ToInt32(Byte4Buffer);
        }
        public static short ReadInt16(this Stream stream , Span<byte> Byte4Buffer)
        {
            stream.Read(Byte4Buffer);
            return BitConverter.ToInt16(Byte4Buffer);
        }
        public static uint ReadUInt32(this Stream stream , Span<byte> Byte4Buffer)
        {
            stream.Read(Byte4Buffer);
            return BitConverter.ToUInt32(Byte4Buffer);
        }
        public static T ReadStruct<T>(this Stream stream) where T : struct
        {
            int Size = Marshal.SizeOf<T>();
            IntPtr ptr = Marshal.AllocHGlobal(Size);
            //Marshal.Copy(buffer,0,ptr,Size);
            unsafe
            {
                Span<byte> buffer_ = new Span<byte>(ptr.ToPointer() , Size);
                stream.Read(buffer_);
            }
            T result = default;
            result = Marshal.PtrToStructure<T>(ptr);
            Marshal.FreeHGlobal(ptr);
            return result;
        }
    }
}
