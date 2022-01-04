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

    public partial class AccessoriseView : Form
    {
        protected List<Accessory> AccessoryList = new List<Accessory>();
        public AccessoriseView()
        {
            string[] linesInFile = File.ReadAllLines(ProjectPaths.csvFileAdminAC);
            int index = 0;
            foreach (string item in linesInFile)
            {
                if (index == 0) { index++; continue; }

                var values = item.Split(',');

                var Aadd = new Accessory(int.Parse(values[0]), values[1], values[2],
                                    float.Parse(values[3]), values[4], float.Parse(values[5]));

                AccessoryList.Add(Aadd);
                index++;
            }

            InitializeComponent();


        }


        private void AccessoriseView_Load(object sender, EventArgs e)
        {
            this.cbx1.DisplayMember = "Name";
            this.cbx1.ValueMember = "ProductID";
            this.cbx1.DataSource = AccessoryList;
        }
        // show all the think on the form
        private void cbx1_SelectedIndexChanged(object sender, EventArgs e)
        {

            Accessory a = cbx1.SelectedItem as Accessory;
            label8.Text = Convert.ToString(a.ProductID);
            label12.Text = Convert.ToString(a.Name);
            label9.Text = Convert.ToString(a.Description);
            label6.Text = Convert.ToString(a.Price);
            label16.Text = Convert.ToString(a.Manufacture);
            label17.Text = Convert.ToString(a.Size) + "inch";

        }
        // show what the user buy on the greed data 
        private void AddCart_Click(object sender, EventArgs e)
        {
            int temp = Convert.ToInt32(label6.Text);
            OperationsUtlity.createDataTableUser(MyLoggedUser.loggedUser, label8.Text, label12.Text, temp);

        }

        private void butMyCart_Click(object sender, EventArgs e)
        {
            CarttVeiw cart = new CarttVeiw();
            cart.Show();
            this.Hide();
        }

        private void butbacktomeniu_Click(object sender, EventArgs e)
        {
            Productchooser productchooser = new Productchooser();
            productchooser.Show();
            this.Hide();
        }


    }
}
