using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AqFS_Editor
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }

    public static class AqFS_Lib
    {
        [DllImport("AqFS Library.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int AqFS_init(string fname);

        [DllImport("AqFS Library.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void aqfs_cd(string dir);

        [DllImport("AqFS Library.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void aqfs_ls();

        [DllImport("AqFS Library.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void aqfs_cp(string dpath, string spath, string nname);

        [DllImport("AqFS Library.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void aqfs_del(string path);

        [DllImport("AqFS Library.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void aqfs_mkdir(string path);

        [DllImport("AqFS Library.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void aqfs_mkfl(string path, string dir_name);

        [DllImport("AqFS Library.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void aqfs_editfl(string path, byte[] data, UInt32 type, UInt32 off, UInt32 osz);

        [DllImport("AqFS Library.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void aqfs_editflRAW(string path, byte[] data, UInt32 sz, UInt32 type, UInt32 off, UInt32 osz);

        [DllImport("AqFS Library.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr aqfs_rfl(string path, UInt32 off, UInt32 sz);

        [DllImport("AqFS Library.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void aqfs_mv(string path, string spath);

        [DllImport("AqFS Library.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern UInt32 file_size(string fname);

        [DllImport("AqFS Library.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void WriteToHost(string fname, UInt32 off, UInt32 sz);

        [DllImport("AqFS Library.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern UInt32 aqfs_fsz(string fname);
    }
}
