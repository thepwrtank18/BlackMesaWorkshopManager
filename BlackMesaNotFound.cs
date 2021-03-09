using System;
using System.Diagnostics;
using System.IO;
using System.Security.Permissions;
using System.Text;
using System.Windows.Forms;
using Ookii.Dialogs.WinForms;

namespace BlackMesaWorkshopManager
{
    public partial class BlackMesaNotFound : Form
    {
        public BlackMesaNotFound()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(2); // Exits the program with code 2
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 f1 = new Form1();
            Hide(); // Hides itself from sight to the user
            f1.ShowDialog(); // Shows the main menu
            Close(); // Closes itself
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            taskDialog1.MinimizeBox = false;
            taskDialog1.EnableHyperlinks = true;
            TaskDialogButton button = taskDialog1.ShowDialog(this);
            if (button == folderSelect)
            {
                VistaFolderBrowserDialog folderDlg = new VistaFolderBrowserDialog();
                folderDlg.ShowNewFolderButton = true;
                DialogResult result = folderDlg.ShowDialog();
                if (result == DialogResult.OK)
                {
                    Directory.SetCurrentDirectory(folderDlg.SelectedPath);
                    if (!File.Exists("./bms.exe"))
                    {
                        Console.WriteLine("Black Mesa not there, doing nothing");
                        string message = "Black Mesa not found. Please choose a valid directory.";
                        string title = "Error";
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        DialogResult errorResult = MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
                    }
                    else
                    {
                        Console.WriteLine("Black Mesa detected");
                        var userDocFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                        using (FileStream fs = File.Create(userDocFolder + @"/bmm_globalsettings.txt"))
                        {
                            var title = new UTF8Encoding(true).GetBytes(folderDlg.SelectedPath);
                            fs.Write(title, 0, title.Length);
                        }
                    }
                }
            }
            else if (button == notepadEdit)
            {
                var userDocFolder2 = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                if (!File.Exists(userDocFolder2 + @"/bmm_globalsettings.txt"))
                {
                    File.Create(userDocFolder2 + @"/bmm_globalsettings.txt").Dispose();
                }
                ProcessStartInfo notepadStart = new ProcessStartInfo
                {
                    FileName = @"notepad.exe",
                    Arguments = userDocFolder2 + @"/bmm_globalsettings.txt"
                };
                Process.Start(notepadStart);
            }
            else if (button == closeWindow)
            {

            }
        }
    }
}