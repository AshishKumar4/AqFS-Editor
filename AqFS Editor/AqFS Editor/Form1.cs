
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;

namespace AqFS_Editor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Open_HDD_Click(object sender, EventArgs e)     // Browse HDD
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
            }
            string fname = openFileDialog1.FileName;
            HDD_ReadStatus.Text = AqFS_Lib.AqFS_init(fname).ToString();
            HDD_Path.Text = fname;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)      // Open_HDD
        {
            HDD_ReadStatus.Text = AqFS_Lib.AqFS_init(HDD_Path.Text).ToString();
        }

        public static byte[] HtoGFileContent;

        public static byte[] GtoHFileContent;

        public static string GuestFileName;

        public static string HostFileName;

        private void button2_Click_1(object sender, EventArgs e)    // Guest To Memory
        {
            string fname = HDD_GuestFiles.Text;

            UInt32 sz = AqFS_Lib.aqfs_fsz(fname);
            IntPtr buffer = AqFS_Lib.aqfs_rfl(fname, 0, sz);

            HtoGFileContent = new byte[sz];

            Marshal.Copy(buffer, HtoGFileContent, 0, (int)sz);
        }

        private void button5_Click(object sender, EventArgs e)      // Memory to Host
        {
            DialogResult result = Host_SaveFromMemory.ShowDialog();
            if (result == DialogResult.OK)
            {
                HostFileName = Host_SaveFromMemory.FileName;

                File.WriteAllBytes(HostFileName, HtoGFileContent);
            }
        }

        private void button6_Click(object sender, EventArgs e)      // Guest To Host
        {
            string fname = HDD_GuestFiles.Text;

            UInt32 sz = AqFS_Lib.aqfs_fsz(fname);
            IntPtr buffer = AqFS_Lib.aqfs_rfl(fname, 0, sz);

            byte[] tbuf = new byte[sz];

            Marshal.Copy(buffer, tbuf, 0, (int)sz);
            File.WriteAllBytes(fname, tbuf);
        }

        private void HDD_GuestFiles_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)      // Host To Memory
        {
            DialogResult result = openFileDialog2.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                GuestFileName = openFileDialog2.FileName;
                GtoHFileContent = File.ReadAllBytes(GuestFileName);
                Console.WriteLine("The File size is: ");
                Console.WriteLine(GtoHFileContent.Length.ToString());
            }
        }

        private void button4_Click(object sender, EventArgs e)      // Memory to Guest
        {
            string fname = HDD_GuestPath.Text;

            AqFS_Lib.aqfs_mkfl(fname, @"\");
            AqFS_Lib.aqfs_editflRAW(fname, GtoHFileContent, (UInt32)GtoHFileContent.Length, 0, 0, 0);
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)      // Host To Guest
        {
            DialogResult result = openFileDialog2.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                string fname = openFileDialog2.FileName;
                byte[] fcontent = File.ReadAllBytes(fname);
                Console.WriteLine("The File size is: ");
                Console.WriteLine(fcontent.Length.ToString());
                string[] tmp = fname.Split('\\');
                string fname_local = tmp[tmp.Length - 1];
                Console.WriteLine(fname_local);
                // AqFS_Lib.aqfs_ls();
                AqFS_Lib.aqfs_mkfl(fname_local, @"\");
                AqFS_Lib.aqfs_editflRAW(fname_local, fcontent, (UInt32)fcontent.Length, 0, 0, 0);
            }
        }
    }
}
