using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tanent
{
    public partial class Paid : Form
    {
        private string filePath = "tenant.txt";

        public Paid()
        {
            InitializeComponent();
            displayData();
        }

        public void displayData()
        {
            string paid = "Paid";
            List<string[]> customerData = ReadCustomerData(filePath);
            DataTable dt = ConvertToDataTable(customerData);
            DataView dv = dt.DefaultView;
            dv.RowFilter = $"COMMENT = '{paid}'";
            gridPaid.DataSource = dv.ToTable();
        }

        private List<string[]> ReadCustomerData(string filePath)
        {
            List<string[]> customerData = new List<string[]>();
            string[] lines = File.ReadAllLines(filePath);

            foreach (string line in lines)
            {
                string[] data = line.Split(',');
                customerData.Add(data);
            }

            return customerData;
        }

        private DataTable ConvertToDataTable(List<string[]> customerData)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Full Name");
            dt.Columns.Add("Room No");
            dt.Columns.Add("Phone");
            dt.Columns.Add("Deposit");
            dt.Columns.Add("Rent Amt");
            dt.Columns.Add("Lease End");
            dt.Columns.Add("Paid Amt");
            dt.Columns.Add("COMMENT");

            foreach (string[] data in customerData)
            {
                dt.Rows.Add(data);
            }

            return dt;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
