using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Warehouse;
using System.Security.Policy;

namespace TheWarehose.GuiClasses
{

    public partial class CarttVeiw : Form
    {
        public List<Cart> CartList;

        public string selcetedId;
        public string selcetedUser;
        public CarttVeiw()
        {
            this.CartList = new List<Cart>();

            InitializeComponent();




        }


        // view the data on the datagrid 
        private void CarttVeiw_Load(object sender, EventArgs e)
        {
            DataTable dt = CsvReader.ConvertCSVtoDataTable(ProjectPaths.csvFileUser);// admin 
            DataTable du = CsvReader.GetRows(dt);
            dataGridViewUserItems.DataSource = du;
            labeltotalPrice.Text = Convert.ToString(CalulationTool.CalculatePrice(du) + "ILs");


        }
        // go to pay
        private void button1_Click(object sender, EventArgs e)
        {
            //Paymentview paymentview = new Paymentview();
            //paymentview.Show();
            //this.Hide();
            OrderComplete ordercomplete = new OrderComplete();
            ordercomplete.Show();


        }
        // back to meniu
        private void button2_Click(object sender, EventArgs e)
        {
            Productchooser productchooser = new Productchooser();
            productchooser.Show();
            this.Hide();



        }
        //delete a raw or more from the table
        private void btrclear_Click(object sender, EventArgs e)
        {


            if (dataGridViewUserItems.SelectedRows.Count > 0)
            {

                dataGridViewUserItems.Rows.RemoveAt(dataGridViewUserItems.CurrentRow.Index);


                //Rewrites CSV file according to modified DataGridView
                var sb = new StringBuilder();
                var headers = dataGridViewUserItems.Columns.Cast<DataGridViewColumn>();
                sb.AppendLine(string.Join(",", headers.Select(column => "" + column.HeaderText + "").ToArray()));

                foreach (DataGridViewRow row in dataGridViewUserItems.Rows)
                {
                    var cells = row.Cells.Cast<DataGridViewCell>();
                    sb.AppendLine(string.Join(",", cells.Select(cell => "" + cell.Value + "").ToArray()));
                }
                File.WriteAllText(ProjectPaths.csvFileUser, sb.ToString());



            }
        }

        private void dataGridViewUserItems_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewUserItems.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridViewUserItems.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridViewUserItems.Rows[selectedrowindex];
                string a = Convert.ToString(selectedRow.Cells["ProductId"].Value);
                selcetedId = a;
                string b = Convert.ToString(selectedRow.Cells["UserName"].Value);
                selcetedUser = b;
            }
        }
    }
}
