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

namespace Tanent
{
    public partial class Not_Paid : Form
    {
        private string filePath = "tenant.txt";

        public Not_Paid()
        {
            InitializeComponent();
            displayData();
        }

        public void displayData() // update the currently added data
        {
            string notPaid = "Not Paid";
            List<string[]> records = LoadDataFromFile(filePath);

            // Filter the records for "Not Paid" comments
            List<string[]> filteredRecords = records.Where(r => r[7] == notPaid).ToList();

            DataTable dt = ConvertToDataTable(filteredRecords);
            gridNotPaid.DataSource = dt;
        }

        private List<string[]> LoadDataFromFile(string filePath)
        {
            List<string[]> records = new List<string[]>();

            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);

                foreach (string line in lines)
                {
                    string[] fields = line.Split(',');
                    records.Add(fields);
                }
            }

            return records;
        }

        private DataTable ConvertToDataTable(List<string[]> records)
        {
            DataTable dt = new DataTable();

            // Add columns to the DataTable
            dt.Columns.Add("Full Name");
            dt.Columns.Add("Room No");
            dt.Columns.Add("Phone No");
            dt.Columns.Add("Deposit");
            dt.Columns.Add("Rent Amt");
            dt.Columns.Add("Lease End");
            dt.Columns.Add("Paid Amt");
            dt.Columns.Add("COMMENT");

            // Add rows to the DataTable
            foreach (string[] fields in records)
            {
                dt.Rows.Add(fields);
            }

            return dt;
        }
    }
}
