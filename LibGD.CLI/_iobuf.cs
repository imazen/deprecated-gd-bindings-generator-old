using System;
using System.Runtime.InteropServices;

namespace LibGD
{
    public class C
    {
        // FILE *fopen( const char *filename, const char *mode );
        [DllImport("msvcrt", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        [return: MarshalAs(UnmanagedType.SysInt)]
        public static extern IntPtr fopen([In, MarshalAs(UnmanagedType.LPStr)] string filename, [In, MarshalAs(UnmanagedType.LPStr)] string mode);

        // int fclose( FILE *stream );
        [DllImport("msvcrt", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        [return: MarshalAs(UnmanagedType.I4)]
        public static extern int fclose([In] IntPtr stream);
    }

    public unsafe partial class _iobuf : IDisposable
    {
        [StructLayout(LayoutKind.Sequential, Size = 8)]
        public struct Internal
        {
            public char* _ptr;
            public int _cnt;
            public char* _base;
            public int _flag;
            public int _file;
            public int _charbuf;
            public int _bufsiz;
            public char* _tmpfname;
        }

        public global::System.IntPtr __Instance { get; protected set; }

        internal _iobuf(_iobuf.Internal* native)
            : this(new global::System.IntPtr(native))
        {
        }

        internal _iobuf(_iobuf.Internal native)
            : this(&native)
        {
        }

        public _iobuf(global::System.IntPtr native, bool isInternalImpl = false)
        {
            __Instance = native;
        }

        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            Marshal.FreeHGlobal(__Instance);
        }
    }
}
