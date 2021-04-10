using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Tp2
{
    public partial class lister : Form
    {
        public lister()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            liste1.Text = EnterForm.settext;
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            EnterForm f = new EnterForm();
            f.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
