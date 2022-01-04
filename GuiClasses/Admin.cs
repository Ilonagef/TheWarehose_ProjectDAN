using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace TheWarehose.GuiClasses
{
    public partial class Admin : Form
    {

        public Admin()
        {
            InitializeComponent();
            txtPasword.PasswordChar = '*';
        }



        private void btnCancel_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            if (txtUser.Text != "Admin")
            {


                if (txtPasword.Text != "Admin")
                {
                    MessageBox.Show("Please try again");
                }
            }
            else
            {
                AddproductAdmin Addproadmin = new AddproductAdmin();
                Addproadmin.Show();

            }
        }
    }
}
