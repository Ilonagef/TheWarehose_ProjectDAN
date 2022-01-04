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
    public partial class Paymentview : Form
    {
        public Paymentview()
        {
            InitializeComponent();
        }

        private void btnPaypal_Click(object sender, EventArgs e)
        {
            PaypalView paypal = new PaypalView();
            paypal.Show();
            this.Hide();
        }

        private void btncredit_Click(object sender, EventArgs e)
        {
            CreditView credit = new CreditView();
            credit.Show();
            this.Hide();
        }

        private void Paymentview_Load(object sender, EventArgs e)
        {

        }
    }
}
