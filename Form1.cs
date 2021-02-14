#pragma warning disable IDE1006 // pascal case is trash, camel case forever
using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace BlackMesaWorkshopManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            if (Directory.Exists(@"./bms/custom"))
            {
                createCustom.Enabled = false;
                enableCustom.Enabled = false;
                disableCustom.Enabled = true;
            }
            else if (Directory.Exists(@"./bms/custom_disabled"))
            {
                createCustom.Enabled = false;
                enableCustom.Enabled = true;
                disableCustom.Enabled = false;
            }
            else
            {
                createCustom.Enabled = true;
                disableCustom.Enabled = false;
                enableCustom.Enabled = false;

            }
        }

        private void disableCustom_Click(object sender, EventArgs e)
        {
            Directory.Move(@"./bms/custom", @"./bms/custom_disabled"); // Moves files in the custom folder to the custom_disabled folder
            disableCustom.Enabled = false;
            enableCustom.Enabled = true;
        }

        private void enableCustom_Click(object sender, EventArgs e)
        {
            Directory.Move(@"./bms/custom_disabled", @"./bms/custom"); // Moves files in the custom_disabled folder to the custom folder
            enableCustom.Enabled = false;
            disableCustom.Enabled = true;
        }

        private void launchGame_Click(object sender, EventArgs e)
        {
            if (isWorkshopDisabled.Checked)
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

        private void createCustom_Click(object sender, EventArgs e)
        {
            Directory.CreateDirectory(@"./bms/custom");                  // creates the custom folder
            Directory.CreateDirectory(@"./bms/custom/nonvpk");           // creates the folder that non-vpk mods go in
            Directory.CreateDirectory(@"./bms/custom/nonvpk/models");    // creates the folder that non-vpk models go in
            Directory.CreateDirectory(@"./bms/custom/nonvpk/materials"); // creates the folder that non-vpk materials go in
            Directory.CreateDirectory(@"./bms/custom/nonvpk/particles"); // creates the folder that non-vpk particles go in
            Directory.CreateDirectory(@"./bms/custom/nonvpk/maps");      // creates the folder that non-vpk maps go in
            createCustom.Enabled = false;
            disableCustom.Enabled = true;
        }

        private void resetCustom_CheckedChanged(object sender, EventArgs e)
        {
            createCustom.Enabled = true;
            createCustom.Text = "Repair Custom Folder";
            resetCustom.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
            aboutForm f4 = new aboutForm();
            f4.ShowDialog();
        }
    }
}
