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
using System.IO;
using Warehouse;

namespace TheWarehose
{
    public partial class Phoneview : Form
    {

        protected List<Phone> phoneList = new List<Phone>();
        public Phoneview()
        {


            string[] linesInFile = File.ReadAllLines(ProjectPaths.csvFileAdminPh);
            int index = 0;
            foreach (string item in linesInFile)
            {
                if (index == 0) { index++; continue; }

                var values = item.Split(',');

                var padd = new Phone(int.Parse(values[0]), values[1], values[2],
                                    float.Parse(values[3]), values[4], int.Parse(values[5]),
                                    int.Parse(values[6]), int.Parse(values[7]), float.Parse(values[8]));

                phoneList.Add(padd);
                index++;
            }
            InitializeComponent();

        }


        private void Phoneview_Load(object sender, EventArgs e)
        {

            RefreshCbx1Source();

        }
        private void RefreshCbx1Source()
        {
            this.cbx1.DisplayMember = "Name";
            this.cbx1.ValueMember = "ProductID";
            this.cbx1.DataSource = phoneList;
        }

        private void cbx1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Phone p = cbx1.SelectedItem as Phone;
            lblProId.Text = Convert.ToString(p.ProductID);
            lblName.Text = Convert.ToString(p.Name);
            lblDescription.Text = Convert.ToString(p.Description);
            lblPrice.Text = Convert.ToString(p.Price);
            lblmanu.Text = Convert.ToString(p.Manufacture);
            lblRam.Text = Convert.ToString(p.RAMamount) + "gb";
            lblStorage.Text = Convert.ToString(p.Storage) + "gb";
            lblbattery.Text = Convert.ToString(p.BatteryCapacity) + "mah";
            lblScreen.Text = Convert.ToString(p.ScreenSize) + "inch";


        }

        private void btrAddToCart_Click(object sender, EventArgs e)
        {
            int temp = Convert.ToInt32(lblPrice.Text);
            OperationsUtlity.createDataTableUser(MyLoggedUser.loggedUser, lblProId.Text, lblName.Text, temp);



        }

        private void butbacktomeniu_Click(object sender, EventArgs e)
        {
            Productchooser productchooser = new Productchooser();
            productchooser.Show();
            this.Hide();
        }

        private void butmycart_Click(object sender, EventArgs e)
        {
            CarttVeiw cart = new CarttVeiw();
            cart.Show();
            this.Hide();
        }
    }

}
