using System;
using System.IO;
using System.Security.Permissions;
using System.Text;
using System.Windows.Forms;
using Ookii.Dialogs.WinForms;

namespace BlackMesaWorkshopManager
{
    public partial class Form2 : Form
    {
        public Form2()
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
            VistaFolderBrowserDialog folderDlg = new VistaFolderBrowserDialog();
            folderDlg.ShowNewFolderButton = true;
            DialogResult result = folderDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                Directory.SetCurrentDirectory(folderDlg.SelectedPath);
                var userDocFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                using (FileStream fs = File.Create(userDocFolder + @"/bmm_globalsettings.txt"))
                {
                    var title = new UTF8Encoding(true).GetBytes(folderDlg.SelectedPath);
                    fs.Write(title, 0, title.Length);
                }
                Form1 f1 = new Form1();
                Hide(); // Hides itself from sight to the user
                f1.ShowDialog(); // Shows the main menu
                Close(); // Closes itself
            }
        }
    }
}