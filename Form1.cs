using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace BlackMesaWorkshopManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            if (File.Exists("./bms.exe"))
            {
                Console.WriteLine("Black Mesa detected, continuing");
            }
            else
            {
                Console.WriteLine("Black Mesa not there, disabling everything");
                Form2 f2 = new Form2();
                f2.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Work in progress!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Work in progress!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                ProcessStartInfo noWorkshopInfo = new ProcessStartInfo
                {
                    FileName = @"bms", // opens bms
                    Arguments = @"+workshop_disable 1" // with the workshop disabled
                };
                Process.Start(noWorkshopInfo);
            }
            else
            {
                ProcessStartInfo withWorkshopInfo = new ProcessStartInfo
                {
                    FileName = @"bms", // opens bms
                };
                Process.Start(withWorkshopInfo);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Console.WriteLine("Check box altered");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
