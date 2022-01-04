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
    public partial class ProductAddAcc : Form
    {
        private static List<Accessory> accessryList;
        public ProductAddAcc(List<Accessory> accessories)
       {
           accessryList = new List<Accessory>();
           foreach (Accessory accessory in accessories)
           {
               accessryList.Add(accessory);
           }
           InitializeComponent();
       }
        private void RefreshCbxSource()
        {
            this.comboBox1.DisplayMember = "Name";
            this.comboBox1.ValueMember = "ProductID";
            this.comboBox1.DataSource = accessryList;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Accessory a = comboBox1.SelectedItem as Accessory;
            lab1.Text = Convert.ToString(a.ProductID);
            lab2.Text = Convert.ToString(a.Name);
            lab3.Text = Convert.ToString(a.Description);
            lab4.Text = Convert.ToString(a.Price);
            lab5.Text = Convert.ToString(a.Manufacture);
            lab6.Text = Convert.ToString(a.Size) + "inch"; 
        }

        private void ProductAddAcc_Load(object sender, EventArgs e)
        {
            RefreshCbxSource();
        }
    }
}
