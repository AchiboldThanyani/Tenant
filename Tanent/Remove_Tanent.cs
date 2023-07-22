using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tanent
{
    public partial class Remove_Tanent : Form
    {
        private string filePath = "tenant.txt"; // Path to the text file
        private string toBeRemoved = "";

        public Remove_Tanent()
        {
            InitializeComponent();
            btnUdoRemove.Visible = false;
        }

        private void btnSearchRemove_Click(object sender, EventArgs e)
        {
            try
            {
                bool found = false;
                string searchBy = searchByDelete.SelectedItem.ToString();
                string search = tanentDelete.Text;
                List<string> lines = File.ReadAllLines(filePath).ToList();

                string name = GetName(searchBy, search, lines);
                List<string> filteredLines = new List<string>();
                string foundLine = null;

                foreach (string line in lines)
                {
                    string[] values = line.Split(',');
                    string lineName = values[0];

                    if (lineName == name)
                    {
                        foundLine = line;
                        found = true;
                        break;
                    }
                }
                if (foundLine != null)
                {
                    filteredLines.Add(foundLine);
                    toBeRemoved = name;
                }
                if (!found)
                {
                    MessageBox.Show("Tenant Not Found");
                }

                DisplayData(filteredLines);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Enter Tenant Details");
            }
        }

        public string GetName(string refOrName, string search, List<string> lines)
        {
            foreach (string line in lines)
            {
                string[] values = line.Split(',');
                string reff = values[1];
                string fullName = values[0];

                if ((refOrName == "Room No" && reff == search) ||
                    (refOrName == "Full Name" && fullName == search))
                {
                    return values[0];
                }
            }

            throw new NullReferenceException("Tanent not found");
        }

        public void DisplayData(List<string> lines)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("fullName");
            dt.Columns.Add("roomNo");
            dt.Columns.Add("phone");
            dt.Columns.Add("deposit");
            dt.Columns.Add("rentAmt");
            dt.Columns.Add("leaseEnd");
            dt.Columns.Add("paidAmt");
            dt.Columns.Add("COMMENT");

            foreach (string line in lines)
            {
                string[] values = line.Split(',');
                dt.Rows.Add(values);
            }

            gridDelete.DataSource = dt;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            List<string> lines = File.ReadAllLines(filePath).ToList();
            List<string> updatedLines = new List<string>();

            foreach (string line in lines)
            {
                string[] values = line.Split(',');
                string name = values[0];

                if (name != toBeRemoved)
                {
                    updatedLines.Add(line);
                }
            }

            File.WriteAllLines(filePath, updatedLines);
            DisplayData(updatedLines);
            MessageBox.Show("Tanent successfully removed");
        }
    }
}
