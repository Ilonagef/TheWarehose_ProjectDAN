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
    public partial class ProductAddPhone : Form
    {
        private static List<Phone> phoneList;



          public ProductAddPhone(List<Phone> phones)
           {

               phoneList = new List<Phone>();

               foreach (Phone phone in phones)
               {
                   phoneList.Add(phone);
               }
               InitializeComponent();
           }

        

        private void RefreshCbx1Source()
        {
            this.comboBox1.DisplayMember = "Name";
            this.comboBox1.ValueMember = "ProductID";
    
            
            this.comboBox1.DataSource = phoneList;
            
           
             
            
            
        }

        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            
            Phone p = comboBox1.SelectedItem as Phone;
            lab1.Text = Convert.ToString(p.ProductID);
            lab2.Text = Convert.ToString(p.Name);
            lab3.Text = Convert.ToString(p.Description);
            lab4.Text = Convert.ToString(p.Price);
            lab5.Text = Convert.ToString(p.Manufacture);
            lab6.Text = Convert.ToString(p.RAMamount) + "gb";
            lab7.Text = Convert.ToString(p.Storage) + "gb";
            lab8.Text = Convert.ToString(p.BatteryCapacity) + "mah";
            lab9.Text = Convert.ToString(p.ScreenSize) + "inch";
            
            

            
 
            

          
        }

        private void ProductAdd_Load(object sender, EventArgs e)
        {
            RefreshCbx1Source();
        }
    }
}
