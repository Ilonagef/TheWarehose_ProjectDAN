using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Warehouse;

namespace TheWarehose.GuiClasses
{
    public partial class ProductAddGa : Form
    {
        private List<Gadget> gadgetsList;

        public ProductAddGa(List<Gadget> gadgets)
        {

            gadgetsList = new List<Gadget>();

            foreach (Gadget gadget in gadgets)
            {
                gadgetsList.Add(gadget);
            }
            InitializeComponent();
        }
        private void RefreshCbx1Source()
        {
            this.comboBox1.DisplayMember = "Name";
            this.comboBox1.ValueMember = "ProductID";
            this.comboBox1.DataSource = gadgetsList;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Gadget g = comboBox1.SelectedItem as Gadget;
            lab10.Text = Convert.ToString(g.ProductID);
            lab11.Text = Convert.ToString(g.Name);
            lab12.Text = Convert.ToString(g.Description);
            lab13.Text = Convert.ToString(g.Price); //+ "  ILS";
            lab14.Text = Convert.ToString(g.Manufacture);
            lab15.Text = Convert.ToString(g.Port);
        }

        private void ProductAddGa_Load(object sender, EventArgs e)
        {
            RefreshCbx1Source();
        }
    }
}
