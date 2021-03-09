using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackMesaWorkshopManager
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Directory.SetCurrentDirectory(@"bin");
            Process.Start(@"blackmesa_publish.exe");
            Directory.SetCurrentDirectory(new DirectoryInfo(Directory.GetCurrentDirectory()).Parent?.FullName ?? throw new Exception("Parent directory not found"));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Directory.SetCurrentDirectory(@"bin");
            Process.Start(@"hammer.exe");
            Directory.SetCurrentDirectory(new DirectoryInfo(Directory.GetCurrentDirectory()).Parent?.FullName ?? throw new Exception("Parent directory not found"));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Directory.SetCurrentDirectory(@"bin");
            Process.Start(@"QC_Eyes.exe");
            Directory.SetCurrentDirectory(new DirectoryInfo(Directory.GetCurrentDirectory()).Parent?.FullName ?? throw new Exception("Parent directory not found"));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Process.Start(@"bin");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Process.Start(@"bms");
        }
    }
}
