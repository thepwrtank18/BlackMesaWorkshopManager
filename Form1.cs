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
            if (Directory.Exists(@"./bms/custom")) // If the directory exists, you can disable it, but you can't create or enable it (it's already enabled).
            {
                createCustom.Enabled = false;
                enableCustom.Enabled = false;
                disableCustom.Enabled = true;
            }
            else if (Directory.Exists(@"./bms/custom_disabled")) // If the directory exists, you can enable it, but you can't create or disable it (it's already disabled).
            {
                createCustom.Enabled = false;
                enableCustom.Enabled = true;
                disableCustom.Enabled = false;
            }
            else // Otherwise, you can't disable or enable it, but you can create it.
            {
                createCustom.Enabled = true;
                disableCustom.Enabled = false;
                enableCustom.Enabled = false;

            }

            if (!Directory.Exists(@"./bmm_settings"))
            {
                Directory.CreateDirectory(@"./bmm_settings"); // If the directory doesn't exist, make it.
            }

            if (!File.Exists(@"./bmm_settings/workshop.txt")) // Saves whether the workshop is enabled or not.
            {
                isWorkshopDisabled.Checked = false;
            }
            else
            {
                isWorkshopDisabled.Checked = true;
            }

            if (!File.Exists(@"./bmm_settings/oldui.txt")) // Saves whether the old UI is enabled or not.
            {
                enableOldUI.Checked = false;
            }
            else
            {
                enableOldUI.Checked = true;
            }
        }

        private void disableCustom_Click(object sender, EventArgs e)
        {
            Directory.Move(@"./bms/custom", @"./bms/custom_disabled"); // Moves files in the custom folder to the custom_disabled folder.
            disableCustom.Enabled = false;
            enableCustom.Enabled = true;
        }

        private void enableCustom_Click(object sender, EventArgs e)
        {
            Directory.Move(@"./bms/custom_disabled", @"./bms/custom"); // Moves files in the custom_disabled folder to the custom folder.
            enableCustom.Enabled = false;
            disableCustom.Enabled = true;
        }

        private void launchGame_Click(object sender, EventArgs e)
        {
            // this is some YandereDev style code over here
            if (isWorkshopDisabled.Checked && !enableOldUI.Checked) // If the Workshop is disabled and the old UI is disabled
            {
                ProcessStartInfo noWorkshopInfo = new ProcessStartInfo
                {
                    FileName = @"bms.exe", // opens bms
                    Arguments = @"+workshop_disable 1" // with the workshop disabled
                };
                Process.Start(noWorkshopInfo);
            }
            else if (!isWorkshopDisabled.Checked && !enableOldUI.Checked) // If the Workshop is enabled and the old UI is disabled
            {
                ProcessStartInfo withWorkshopInfo = new ProcessStartInfo
                    {
                        FileName = @"bms.exe", // opens bms
                    };
                    Process.Start(withWorkshopInfo);
            }
            else if (isWorkshopDisabled.Checked && enableOldUI.Checked) // if the Workshop is disabled and the old UI is enabled
            {
                ProcessStartInfo withWorkshopInfo = new ProcessStartInfo
                {
                    FileName = @"bms.exe", // opens bms
                    Arguments = @"+workshop_disable 1 -oldgameui" // with the workshop disabled and using the old game ui
                };
                Process.Start(withWorkshopInfo);
            }
            else if (!isWorkshopDisabled.Checked && enableOldUI.Checked) // if the Workshop is enabled and the old UI is enabled 
            {
                ProcessStartInfo withWorkshopInfo = new ProcessStartInfo
                {
                    FileName = @"bms.exe", // opens bms
                    Arguments = @"-oldgameui" // using the old game ui
                };
                Process.Start(withWorkshopInfo);
            }
        }

        private void isWorkshopDisabled_CheckedChanged(object sender, EventArgs e)
        {
            Console.WriteLine("Workshop disabled/enabled, applying that");
            if (File.Exists(@"./bmm_settings/workshop.txt"))
            {
                File.Delete(@"./bmm_settings/workshop.txt");
            }

            if (isWorkshopDisabled.Checked) // If the workshop is disabled, create a txt file that the program will look for on startup
            {
                File.Create("./bmm_settings/workshop.txt").Dispose();
            }
            else if (!isWorkshopDisabled.Checked) // If not, just do nothing
            {
                Console.WriteLine("Workshop disabled, doing nothing");
            }
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
            createCustom.Enabled = true; // Allows you to click the "Create Custom Folder" button
            createCustom.Text = "Repair Custom Folder"; // Renames it to "Repair Custom Folder"
            resetCustom.Enabled = false; // Disables the ability to click on it again
        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
            aboutForm f4 = new aboutForm();
            f4.ShowDialog(); // Shows a box tied to the main menu
        }

        private void enableOldUI_CheckedChanged(object sender, EventArgs e)
        {
            Console.WriteLine("Old UI enabled/disabled, applying that");
            if (File.Exists(@"./bmm_settings/oldui.txt"))
            {
                File.Delete(@"./bmm_settings/oldui.txt");
            }

            if (enableOldUI.Checked) // If the old ui is enabled, create a txt file that the program will look for on startup
            {
                File.Create("./bmm_settings/oldui.txt").Dispose();
            }
            else if (!enableOldUI.Checked) // If disabled, just do nothing
            {
                Console.WriteLine("Old UI disabled, doing nothing");
            }
        }
    }
}