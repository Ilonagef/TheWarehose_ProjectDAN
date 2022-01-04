using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheWarehose.GuiClasses
{
    public partial class CreditView : Form
    {


        public CreditView()
        {
            InitializeComponent();


        }



        private void button1_Click(object sender, EventArgs e)
        {
            if ( textBox1.Text.Length == 0)
            {
                MessageBox.Show("incorrect Credit Number");
            }
            else if ((int.Parse(textBox3.Text) > 12)||(textBox3.Text.Length>2)||(textBox2.Text.Length != 4) || (textBox3.Text.Length == 0) || (textBox2.Text.Length == 0))

            {
                MessageBox.Show("incorrect Expiration Date");
            }
           

            else if (textBox4.Text.Length != 3 || (textBox4.Text.Length == 0))
            {
                MessageBox.Show("incorrect Issue Number");
            }
            else
                MessageBox.Show("The payment successful ");

        }

        private void button2_Click(object sender, EventArgs e)
        {

            Paymentview payment = new Paymentview();
            payment.Show();
            this.Hide();


        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char ch = e.KeyChar;
            if (!Char.IsDigit(ch) )
            {
                e.Handled = true;
            }

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

       
    }
    }



