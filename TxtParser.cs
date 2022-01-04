using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Data;
using Warehouse;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Runtime.Remoting.Messaging;
using LumenWorks.Framework.IO.Csv;
using System.Windows.Forms;
using CsvHelper;

namespace TheWarehose
{
    public static class ProjectPaths
    {

        private static string AppPath => Path.GetDirectoryName(Environment.GetCommandLineArgs()[0]);
        private static DirectoryInfo myDir = new DirectoryInfo(AppPath);
        public static string dataDir = myDir.Parent.Parent.FullName.ToString();
        public static string csvFileUser = $"{dataDir}\\UsersCart.csv";
        public static string csvFileAdminPh = $"{dataDir}\\adminph.csv";
        public static string csvFileAdminAC = $"{dataDir}\\adminac.csv";
        public static string csvFileAdmingad = $"{dataDir}\\adminga.csv";
    }
    public static class GlobalTableUser
    {
        public static DataTable userDataTable;
    }
    public static class CsvReader
    {
        public static DataTable ConvertCSVtoDataTable(string strFilePath)
        {
            DataTable dt = new DataTable();
            using (StreamReader sr = new StreamReader(strFilePath))
            {
                string[] headers = sr.ReadLine().Split(',');
                foreach (string header in headers)
                {
                    dt.Columns.Add(header);
                }
                while (!sr.EndOfStream)
                {
                    string[] rows = sr.ReadLine().Split(',');
                    DataRow dr = dt.NewRow();
                    for (int i = 0; i < headers.Length; i++)
                    {
                        dr[i] = rows[i];
                    }
                    dt.Rows.Add(dr);
                }

            }


            return dt;
        }
        public static DataTable GetRows(DataTable myTable)
        {
            // Get the DataTable of a DataSet.

            DataTable dtTemp = new DataTable();
            dtTemp.Columns.Add("UserName", typeof(string)); // dt.Columns.Add("Id", typeof(int));
            dtTemp.Columns.Add("ProductId", typeof(string));
            dtTemp.Columns.Add("ProductName", typeof(string));
            dtTemp.Columns.Add("Price", typeof(int));

            // Print the value one column of each DataRow.
            foreach (DataRow item in myTable.Rows)
            {
                if (item["UserName"].ToString().CompareTo(MyLoggedUser.loggedUser) == 0)
                {
                    dtTemp.Rows.Add(item.ItemArray);


                }

            }


            return dtTemp;
        }


    }
    public static class OperationsUtlity
    {

        public static void createDataTableUser(string myUser, string myItem, string name, int myprice)
        {
            string newFileName = ProjectPaths.csvFileUser;

            string clientDetails = myUser + "," + myItem + "," + name + "," + myprice + "\n";


            if (!File.Exists(newFileName))
            {
                string clientHeader = "UserName" + "," + "ProductId" + "," + "ProductName" + "," + "Price" + Environment.NewLine;

                File.WriteAllText(newFileName, clientHeader);
            }

            File.AppendAllText(newFileName, clientDetails);

        }

    }
    public static class CSVUtlity
    {
        public static void ToCSV(this DataTable dtDataTable, string strFilePath)
        {
            StreamWriter sw = new StreamWriter(strFilePath, false);
            //headers  
            for (int i = 0; i < dtDataTable.Columns.Count; i++)
            {
                sw.Write(dtDataTable.Columns[i]);
                if (i < dtDataTable.Columns.Count - 1)
                {
                    sw.Write(",");
                }
            }
            sw.Write(sw.NewLine);
            foreach (DataRow dr in dtDataTable.Rows)
            {
                for (int i = 0; i < dtDataTable.Columns.Count; i++)
                {
                    if (!Convert.IsDBNull(dr[i]))
                    {
                        string value = dr[i].ToString();
                        if (value.Contains(','))
                        {
                            value = String.Format("\"{0}\"", value);
                            sw.Write(value);
                        }
                        else
                        {
                            sw.Write(dr[i].ToString());
                        }
                    }
                    if (i < dtDataTable.Columns.Count - 1)
                    {
                        sw.Write(",");
                    }
                }
                sw.Write(sw.NewLine);
            }
            sw.Close();
        }
    }
    public static class CalulationTool
    {
        public static double CalculatePrice(DataTable myDt)
        {
            int sum = 0;
            foreach (DataRow dr in myDt.Rows)
            {
                sum += Convert.ToInt32(dr["Price"]);
            }
            return sum;
        }
    }

    public static class AddProduct
    {
        public static void AddPhone(int productID, string name, string description, float price, string manufacture, int RamAmount, int storage, float batteycapcity, float screensize)
        {
            string newFileName = ProjectPaths.csvFileAdminPh;

            string clientDetails = productID + "," + name + "," + description + "," + price + "," + manufacture + "," + RamAmount + "," + storage + "," + batteycapcity + "," + screensize + "\n";


            if (!File.Exists(newFileName))
            {
                string clientHeader = "ProductId" + "," + "ProductName" + "," + "Description" + "," + "Price" + "," + "Manufacture" + "," + "RamAmount" + "," + "storage" + "," + "batteycapcity" + "," + "screensize" + Environment.NewLine;

                File.WriteAllText(newFileName, clientHeader);
            }

            File.AppendAllText(newFileName, clientDetails);

        }

        public static void AddAcc(int productID, string name, string description, float price, string manufacture, float size)
        {
            string newFileName = ProjectPaths.csvFileAdminAC;

            string clientDetails = productID + "," + name + "," + description + "," + price + "," + manufacture + "," + size + "\n";


            if (!File.Exists(newFileName))
            {
                string clientHeader = "ProductId" + "," + "ProductName" + "," + "Description" + "," + "Price" + "," + "Manufacture" + "," + "Size" + Environment.NewLine;

                File.WriteAllText(newFileName, clientHeader);
            }

            File.AppendAllText(newFileName, clientDetails);

        }

        public static void AddGad(int productID, string name, string description, float price, string manufacture, string port)
        {
            string newFileName = ProjectPaths.csvFileAdmingad;

            string clientDetails = productID + "," + name + "," + description + "," + price + "," + manufacture + "," + port + "\n";


            if (!File.Exists(newFileName))
            {
                string clientHeader = "ProductId" + "," + "ProductName" + "," + "Description" + "," + "Price" + "," + "Manufacture" + "," + "Port" + Environment.NewLine;

                File.WriteAllText(newFileName, clientHeader);
            }

            File.AppendAllText(newFileName, clientDetails);

        }







    }




}



