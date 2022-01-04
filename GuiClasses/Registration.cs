using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using System.Net.Mail;
namespace TheWarehose.GuiClasses
{
    public partial class Registration : Form
    {
        public string path = ProjectPaths.dataDir;

        public Registration()
        {
            InitializeComponent();
        }

        private void btrClear_Click(object sender, EventArgs e)
        {
            txtname.Text = "";
            txtphone.Clear();
            txtresidence.Clear();
            txtmail.Clear();
            txtname.Focus();
        }

        private void btrSignUp_Click(object sender, EventArgs e)
        {

            TextWriter txt = File.AppendText($"{path}\\RegistrationText.txt");


            if (string.IsNullOrWhiteSpace(txtname.Text) )
            {
                MessageBox.Show("Enter Full Name !.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                txt.Write(txtname.Text + ",");
            }


            if(txtphone.Text.Length != 10)
            {
                MessageBox.Show("Enter corect number .", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (string.IsNullOrWhiteSpace(txtphone.Text))
            {
                MessageBox.Show("Enter phone number .", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                txt.Write(txtphone.Text + ",");
            }

            if (string.IsNullOrWhiteSpace(txtresidence.Text))
            {
                MessageBox.Show("Enter residence .", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
             else
            {
                txt.Write(txtresidence.Text + ",");
            }

            if (string.IsNullOrWhiteSpace(txtmail.Text))
            {
                MessageBox.Show("This email isn't correct formate .");/*, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);*/
            }
            else
            {
                txt.Write(txtmail.Text + ",");
            }


            if (string.IsNullOrWhiteSpace(txtpass.Text))
            {
                MessageBox.Show("the password must to be between 4-15 chars .", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                txt.Write(txtpass.Text + "\n");
            }
            txt.Close();



            Login login = new Login();
            login.Show();
            this.Hide();
        }

       

        

        private void txtphone_KeyPress_1(object sender, KeyPressEventArgs e)//insert only numbers
        {
            Char ch = e.KeyChar;
            if (!Char.IsDigit(ch))
            {
                e.Handled = true;
            }
        }

        private void txtname_KeyPress(object sender, KeyPressEventArgs e)//insert only letters
        {
            if(!Char.IsControl(e.KeyChar)&& !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtresidence_KeyPress(object sender, KeyPressEventArgs e)//insert only letters
        {
            if (!Char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
