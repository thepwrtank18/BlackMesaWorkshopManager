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
            Environment.Exit(2);
        }
    }
}