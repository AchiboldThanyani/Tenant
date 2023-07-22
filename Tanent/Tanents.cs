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
    public partial class Tanents : Form
    {
        string filePath = "tenant.txt";

        public Tanents()
        {
            InitializeComponent();
            displayData();
        }

        public void displayData() // update the currently added data
        {
            DataTable dt = LoadDataFromTextFile();
            dataGridTanents.DataSource = dt;
        }
        private DataTable LoadDataFromTextFile()
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

            if (File.Exists(filePath))
            {
                try
                {
                    string[] lines = File.ReadAllLines(filePath);
                    foreach (string line in lines)
                    {
                        string[] parts = line.Split(',');

                        if (parts.Length == dt.Columns.Count)
                        {
                            dt.Rows.Add(parts); // Add the split parts directly as a new row
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading tenant data: " + ex.Message);
                }
            }

            return dt;
        }

    }
}
