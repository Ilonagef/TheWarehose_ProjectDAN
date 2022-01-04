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
using Warehouse;

namespace TheWarehose
{
    public partial class Productchooser : Form
    {
        

        public Productchooser()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Phoneview phone = new Phoneview();
            phone.Show();
            this.Hide();


        }

        private void picacces_Click(object sender, EventArgs e)
        {
            AccessoriseView accessory = new AccessoriseView();
            accessory.Show();
            this.Hide();
        }

        private void picgad_Click(object sender, EventArgs e)
        {
            GadgetView gadget = new GadgetView();
            gadget.Show();
            this.Hide();

        }

        private void btrTocart_Click(object sender, EventArgs e)
        {
            CarttVeiw carttVeiw = new CarttVeiw();
            carttVeiw.Show();
            this.Hide();

        }
    }
}
