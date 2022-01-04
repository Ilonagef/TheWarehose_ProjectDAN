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
    public partial class PaypalView : Form
    {
        public PaypalView()
        {
            InitializeComponent();
            textBox2.PasswordChar = '*';
            
        }

        private void Login_Click(object sender, EventArgs e)
        {

            Paypal2 paypal = new Paypal2();
            

            if (textBox1.Text.Length == 0 )
            {
                MessageBox.Show("Plese Enter Email Address!");
            }
            else if (!textBox1.Text.Contains("@"))
            {
                MessageBox.Show("Plese Enter Email Address!");
            }
            else if(textBox2.Text.Length==0)
            {
                MessageBox.Show("Plese Enter Password!");
            }
            else
                paypal.Show();
            

        }

        private void Cancel_Click(object sender, EventArgs e)
        {

            Paymentview payment = new Paymentview();
            payment.Show();
                this.Hide();

            
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            String Pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
            if(Regex.IsMatch(textBox1.Text,Pattern))
            {
                errorProvider1.Clear();
            }
            errorProvider1.SetError(this.textBox1, "Plese Provide valid email address ");
        }

        
    }
}
