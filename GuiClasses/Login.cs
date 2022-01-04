using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheWarehose.GuiClasses;
using System.Text.RegularExpressions;
using System.IO;
namespace TheWarehose
{


    public partial class Login : Form
    {

        public string path = ProjectPaths.dataDir;
        public Login()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtpass.Clear();
            txtName.Focus();

        }

        private void btrlogin_Click(object sender, EventArgs e)
        {




            bool check1 = false;

            StreamReader sr = File.OpenText($"{path}\\RegistrationText.txt");


            string[] lines = File.ReadAllLines($"{path}\\RegistrationText.txt");
            foreach (string line in lines)
            {
                string[] checkline = line.Split(',');

                if (txtName.Text == checkline[0])
                {
                    if (txtpass.Text == checkline[4])
                    {
                        check1 = true;
                        MyLoggedUser.loggedUser = txtName.Text;
                        Productchooser product = new Productchooser();
                        product.Show();
                        this.Hide();
                        break;
                    }
                }
            }
            if (check1 == false)
            {
                MessageBox.Show("user name or password is incorrect!");
            }







        }
        //for Registration
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registration registration = new Registration();
            registration.Show();
            this.Hide();

        }

        private void btradmin_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
        }

       
    }
    public static class MyLoggedUser
    {
        public static string loggedUser;

    }
}
