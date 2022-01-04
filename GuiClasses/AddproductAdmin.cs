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
    public partial class AddproductAdmin : Form
    {
        private List<Phone> phones;
        private List<Gadget> gadgets;
        private List<Accessory> accessories;

        public AddproductAdmin()
        {
            phones = new List<Phone>();
            gadgets = new List<Gadget>();
            accessories = new List<Accessory>();
            InitializeComponent();

        }
        DataTable table = new DataTable();
        private void AddProductAdmin_Load(object sender, EventArgs e)
        {
            table.Columns.Add("ProductId", typeof(int));
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Description", typeof(string));
            table.Columns.Add("Price", typeof(float));
            table.Columns.Add("Manufacture", typeof(string));
            table.Columns.Add("RAMamount", typeof(int));
            table.Columns.Add("Size", typeof(float));
            table.Columns.Add("Storage", typeof(int));
            table.Columns.Add("BatteryCapacity", typeof(int));
            table.Columns.Add("ScreenSize", typeof(float));
            table.Columns.Add("Port", typeof(string));


            dataGridView2.DataSource = table;
        }


        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrEmpty(textBoxId.Text)) || (string.IsNullOrEmpty(textBoxName.Text)) || (string.IsNullOrEmpty(textBoxDes.Text)) || (string.IsNullOrEmpty(textBoxPrice.Text)))
                return;
           
            
            if (comboBox1.SelectedItem.ToString() == "Phone")
            {
                table.Rows.Add(textBoxId.Text, textBoxName.Text, textBoxDes.Text, textBoxPrice.Text, textBoxManuf.Text, textBoxRam.Text, textBoxSize.Text = null, textBoxStorge.Text, textBoxBattery.Text, textBoxScreen.Text, textBoxPort.Text = null);

            }
            else if (comboBox1.SelectedItem.ToString() == "Accessorise")
            {
                table.Rows.Add(textBoxId.Text, textBoxName.Text, textBoxDes.Text, textBoxPrice.Text, textBoxManuf.Text, textBoxRam.Text = null, textBoxSize.Text, textBoxStorge.Text = null, textBoxBattery.Text = null, textBoxScreen.Text = null, textBoxPort.Text = null);
            }
            else
            {
                table.Rows.Add(textBoxId.Text, textBoxName.Text, textBoxDes.Text, textBoxPrice.Text, textBoxManuf.Text, textBoxRam.Text = null, textBoxSize.Text = null, textBoxStorge.Text = null, textBoxBattery.Text = null, textBoxScreen.Text = null, textBoxPort.Text);
            }


            dataGridView2.DataSource = table;

            if (comboBox1.SelectedItem.ToString() == "Phone")
            {
                phones.Add(new Phone(int.Parse(textBoxId.Text), textBoxName.Text, textBoxDes.Text, int.Parse(textBoxPrice.Text), textBoxManuf.Text, int.Parse(textBoxRam.Text), int.Parse(textBoxStorge.Text), float.Parse(textBoxBattery.Text), float.Parse(textBoxScreen.Text)));
                AddProduct.AddPhone(int.Parse(textBoxId.Text), textBoxName.Text, textBoxDes.Text, int.Parse(textBoxPrice.Text), textBoxManuf.Text, int.Parse(textBoxRam.Text), int.Parse(textBoxStorge.Text), float.Parse(textBoxBattery.Text), float.Parse(textBoxScreen.Text));
            }
            else if (comboBox1.SelectedItem.ToString() == "Accessorise")
            {
                accessories.Add(new Accessory(int.Parse(textBoxId.Text), textBoxName.Text, textBoxDes.Text, int.Parse(textBoxPrice.Text), textBoxManuf.Text, float.Parse(textBoxSize.Text)));
                AddProduct.AddAcc(int.Parse(textBoxId.Text), textBoxName.Text, textBoxDes.Text, float.Parse(textBoxPrice.Text), textBoxManuf.Text, float.Parse(textBoxSize.Text));

            }
            else
            {
                gadgets.Add(new Gadget(int.Parse(textBoxId.Text), textBoxName.Text, textBoxDes.Text, float.Parse(textBoxPrice.Text), textBoxManuf.Text, textBoxPort.Text));
                AddProduct.AddGad(int.Parse(textBoxId.Text), textBoxName.Text, textBoxDes.Text, float.Parse(textBoxPrice.Text), textBoxManuf.Text, textBoxPort.Text);
            }

            textBoxId.Clear();
            textBoxName.Clear();
            textBoxBattery.Clear();
            textBoxDes.Clear();
            textBoxManuf.Clear();
            textBoxPrice.Clear();
            textBoxRam.Clear();
            textBoxScreen.Clear();
            textBoxStorge.Clear();
            textBoxPort.Clear();
            textBoxId.Focus();
            textBoxName.Focus();
            textBoxStorge.Focus();
            textBoxScreen.Focus();
            textBoxPrice.Focus();
            textBoxManuf.Focus();
            textBoxDes.Focus();
            textBoxBattery.Focus();
            textBoxRam.Focus();
            textBoxPort.Focus();


        }



        private void btnDone_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Phone")
            {
                ProductAddPhone productAdd = new ProductAddPhone(phones);
                productAdd.Show();
            }
            else if (comboBox1.SelectedItem.ToString() == "Accessorise")
            {
                ProductAddAcc productAddAcc = new ProductAddAcc(accessories);
                productAddAcc.Show();
            }
            else
            {
                ProductAddGa productAddGa = new ProductAddGa(gadgets);
                productAddGa.Show();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {

                dataGridView2.Rows.RemoveAt(dataGridView2.CurrentRow.Index);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Accessorise")
            {
                label7.Visible = false;
                textBoxRam.Visible = false;
                textBoxRam.Text = null;
                label10.Visible = false;
                textBoxStorge.Visible = false;
                textBoxStorge.Text = null;
                label9.Visible = false;
                textBoxBattery.Visible = false;
                textBoxBattery.Text = null;
                label8.Visible = false;
                textBoxScreen.Visible = false;
                textBoxScreen.Text = null;
                label12.Visible = false;
                textBoxPort.Visible = false;
                textBoxPort.Text = null;


            }
            else if (comboBox1.SelectedItem.ToString() == "Gadget")
            {
                label12.Visible = true;
                textBoxPort.Visible = true;
                label7.Visible = false;
                textBoxRam.Visible = false;
                label10.Visible = false;
                textBoxStorge.Visible = false;
                label9.Visible = false;
                textBoxBattery.Visible = false;
                label8.Visible = false;
                textBoxScreen.Visible = false;
                label13.Visible = false;
                textBoxSize.Visible = false;
                textBoxSize.Text = null;





            }
            else if (comboBox1.SelectedItem.ToString() == "Phone")
            {

                label7.Visible = true;
                textBoxRam.Visible = true;
                label10.Visible = true;
                textBoxStorge.Visible = true;
                label9.Visible = true;
                textBoxBattery.Visible = true;
                label8.Visible = true;
                textBoxScreen.Visible = true;
                label12.Visible = false;
                textBoxPort.Visible = false;
                textBoxPort.Text = null;
                label13.Visible = false;
                textBoxSize.Visible = false;
                textBoxSize.Text = null;
                label12.Visible = false;
                textBoxPort.Text = null;
            }
        }
    }
}
