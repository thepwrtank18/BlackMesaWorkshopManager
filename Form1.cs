﻿#pragma warning disable IDE1006 // pascal case is trash, camel case forever
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
        }

        private void disableCustom_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Work in progress!");
        }

        private void enableCustom_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Work in progress!");
        }

        private void launchGame_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                try
                {
                    ProcessStartInfo noWorkshopInfo = new ProcessStartInfo
                    {
                        FileName = @"bms.exe", // opens bms
                        Arguments = @"+workshop_disable 1" // with the workshop disabled
                    };
                    Process.Start(noWorkshopInfo);
                }
                catch
                {
                    Console.WriteLine("Couldn't find Black Mesa. Almost as if I tried to warn the user!");
                    throw;
                }

            }
            else
            {
                try
                {
                    ProcessStartInfo withWorkshopInfo = new ProcessStartInfo
                    {
                        FileName = @"bms.exe", // opens bms
                    };
                    Process.Start(withWorkshopInfo);
                }
                catch
                {
                    Console.WriteLine("Couldn't find Black Mesa. Almost as if I tried to warn the user!");
                    throw;
                }

            }
        }

        private void isWorkshopDisabled_CheckedChanged(object sender, EventArgs e)
        {
            Console.WriteLine("Check box altered");
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("If you are seeing this, you are using a debugger or just viewing the code. Thank you for using this!");
            Console.WriteLine("I made this in 5-6 hours, which isn't really much. Again, thanks for using the program!");
        }
    }
}
