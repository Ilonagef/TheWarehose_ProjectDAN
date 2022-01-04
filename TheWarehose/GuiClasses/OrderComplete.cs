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
namespace TheWarehose.GuiClasses
{
    public partial class OrderComplete : Form
    {
        public string path = ProjectPaths.dataDir;
        public OrderComplete()
        {
            InitializeComponent();
        }

        private void OrderComplete_Load(object sender, EventArgs e)
        {

            StreamReader sr = File.OpenText($"{path}\\RegistrationText.txt");


            string[] lines = File.ReadAllLines($"{path}\\RegistrationText.txt");
            foreach (string line in lines)
            {
                string[] checkline = line.Split(',');

                if (MyLoggedUser.loggedUser == checkline[0])
                {
                    lblName.Text = checkline[0];
                    lblMail.Text = checkline[3];
                    lblphone.Text = checkline[1];
                    lbladdress.Text = checkline[2];
                    DataTable dt = CsvReader.ConvertCSVtoDataTable(ProjectPaths.csvFileUser);// admin 
                    DataTable du = CsvReader.GetRows(dt);
                    dataGridView1.DataSource = du;
                    lblPrice.Text = Convert.ToString(CalulationTool.CalculatePrice(du) + "ILs");
                    lblDate.Text = DateTime.Now.ToString("M/d/yyyy");
                }
            }
        }

        private void btrBack_Click(object sender, EventArgs e)
        {
            CarttVeiw cartview = new CarttVeiw();
            this.Hide();
            cartview.Show();
        }

        private void btrTopay_Click(object sender, EventArgs e)
        {

            this.Hide();
            Paymentview paymentview = new Paymentview();
            paymentview.Show();

        }
    }
}
