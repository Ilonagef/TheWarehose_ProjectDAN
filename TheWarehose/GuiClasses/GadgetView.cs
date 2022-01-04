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
using Warehouse;

namespace TheWarehose.GuiClasses
{
    public partial class GadgetView : Form
    {// create a list of a gadget
        protected List<Gadget> GadgetList = new List<Gadget>();
        public GadgetView()
        {
            string[] linesInFile = File.ReadAllLines(ProjectPaths.csvFileAdmingad);
            int index = 0;
            foreach (string item in linesInFile)
            {
                if (index == 0) { index++; continue; }

                var values = item.Split(',');

                var Gadd = new Gadget(int.Parse(values[0]), values[1], values[2],
                                    float.Parse(values[3]), values[4], values[5]);

                GadgetList.Add(Gadd);
                index++;
            }
            InitializeComponent();
        }

        private void GadgetView_Load(object sender, EventArgs e)
        {

            this.cbx1.DisplayMember = "Name";
            this.cbx1.ValueMember = "ProductID";
            this.cbx1.DataSource = GadgetList;
        }



        // show on the form the thinks of the product 
        private void cbx1_SelectedIndexChanged(object sender, EventArgs e)
        {

            Gadget g = cbx1.SelectedItem as Gadget;
            lblProID.Text = Convert.ToString(g.ProductID);
            lblName.Text = Convert.ToString(g.Name);
            lblDescription.Text = Convert.ToString(g.Description);
            lblPrice.Text = Convert.ToString(g.Price); //+ "  ILS";
            lblmanu.Text = Convert.ToString(g.Manufacture);
            lblPort.Text = Convert.ToString(g.Port) + "inch";

        }
        // show the user what ho choose.
        private void Add_Click(object sender, EventArgs e)
        {
            int temp = Convert.ToInt32(lblPrice.Text);
            OperationsUtlity.createDataTableUser(MyLoggedUser.loggedUser, lblProID.Text, lblName.Text, temp);
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
