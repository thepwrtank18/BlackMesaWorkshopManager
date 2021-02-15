using System;
using System.Windows.Forms;

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
    }
}