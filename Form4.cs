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
using Ookii.Dialogs.WinForms;

namespace BlackMesaWorkshopManager
{
    public partial class aboutForm : Form
    {
        public aboutForm()
        {
            InitializeComponent();
            var userDocFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (!File.Exists(userDocFolder + @"./bmm_globalsettings.txt"))
            {
                button2.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
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
    }
}
