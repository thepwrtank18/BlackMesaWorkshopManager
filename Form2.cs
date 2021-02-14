using System;
using System.Net.Mime;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;

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
            Environment.Exit(2);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Console.WriteLine("Successfully loaded");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 f1 = new Form1();
            Hide();
            f1.ShowDialog();
            Close();
        }
    }
}