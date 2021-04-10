using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Tp2
{
    public partial class EnterForm : Form
    {
        public static string settext;
        public EnterForm()
        {
           
            InitializeComponent();
        }

        private void EnterForm_Load(object sender, EventArgs e)
        {
            

        }
        public List<String> clients = new List<String>();



        public void PassValue(string strValue, string prValue,int agValue)
        {
                  }
        String clt;
        private void btadd_Click(object sender, EventArgs e)
        {

            if ((txtnom.Text != "") && (txtpre.Text != "") && (txtage.Text != ""))
            {
                clt  = txtnom.Text + " " + txtpre.Text + " " + txtage.Text;
                clients.Add(clt);

                
            }
            else
            {
                MessageBox.Show("Remplir les cases vides..");
            }
            
        }

        private void txtNom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar)) && !(Char.IsWhiteSpace(e.KeyChar)) && !(Char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txtPrenom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar)) && !(Char.IsWhiteSpace(e.KeyChar)) && !(Char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txtAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            settext = clt;
            lister f2 = new lister();
            f2.ShowDialog();
        }

        private void btEfface_Click(object sender, EventArgs e)
        {
            txtnom.Text = "";
            txtpre.Text = "";
            txtage.Text = "";
        }

        private void btQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
