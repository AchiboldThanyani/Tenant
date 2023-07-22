using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Tanent
{
    public partial class Edit_Tanent : Form
    {
        private string filePath = "tenant.txt"; // Path to the text file
        private string val = "";
        public Edit_Tanent()
        {
            InitializeComponent();
           // btnUdoEdit.Visible = false;
        }

        private void comboBoxEdit_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateCurrentInfo();
        }

        public void updateCurrentInfo()
        {
            if (comboBoxEdit.SelectedIndex > -1)
            {
                string searchBy = searchByEdit.SelectedItem.ToString();
                string tanentSearch = tanent.Text;
                string selected = comboBoxEdit.SelectedItem.ToString();

                List<string> lines = File.ReadAllLines(filePath).ToList();
                string name = GetName(searchBy, tanentSearch, lines);

                List<string> filteredLines = new List<string>();
                string foundLine = null;

                foreach (string line in lines)
                {
                    string[] values = line.Split(',');
                    string lineName = values[0];

                    if (lineName == name)
                    {
                        foundLine = line;
                        break;
                    }
                }

                if (foundLine != null)
                {
                    filteredLines.Add(foundLine);
                    //toBeEdited = id;
                }

                DisplayData(filteredLines);
                GetOldValue(selected, filteredLines);
                oldValue.Text = val;
            }
        }

        public string GetName(string refOrName, string search, List<string> lines)
        {
            bool found = false;
            foreach (string line in lines)
            {
                string[] values = line.Split(',');
                string reff = values[1];
                string fullName = values[0];

                if ((refOrName == "Room No" && reff == search) ||
                    (refOrName == "Full Name" && fullName == search))
                {
                    return values[0];
                    found = true;
                }
            }
            if (!found)
            {
                MessageBox.Show("Tenant Not Found");
            }
            throw new NullReferenceException("Tanent not found");
        }

        public void GetOldValue(string selected, List<string> lines)
        {
            foreach (string line in lines)
            {
                string[] values = line.Split(',');
                string name = values[0];

                if (selected == "Full Name")
                {
                    val = values[0];
                }
                else if (selected == "Room No.")
                {
                    val = values[1];
                }
                else if (selected == "Phone No.")
                {
                    val = values[2];
                }
                else if (selected == "Deposit")
                {
                    val = values[3];
                }
                else if (selected == "Rent Amt")
                {
                    val = values[4];
                }
                else if (selected == "Lease End")
                {
                    val = values[5];
                }
                else if (selected == "Paid Amt")
                {
                    val = values[6];
                }
                else if (selected == "COMMENT")
                {
                    val = values[7];
                }
                else
                {
                    throw new ArgumentException("Invalid selected value");
                }
            }
        }

        private void btnDoneEdit_Click(object sender, EventArgs e)
        {
            try
            {
                string searchBy = searchByEdit.SelectedItem.ToString();
                string selected = comboBoxEdit.SelectedItem.ToString();
                string value = newValue.Text;
                string tanentSearch = tanent.Text;

                List<string> lines = File.ReadAllLines(filePath).ToList();
                string name = GetName(searchBy, tanentSearch, lines);

                for (int i = 0; i < lines.Count; i++)
                {
                    string[] values = lines[i].Split(',');
                    string lineName = values[0];

                    if (lineName == name)
                    {
                        if (selected == "Full Name")
                        {
                            values[0] = value;
                        }
                        else if (selected == "Room No.")
                        {
                            values[1] = value;
                        }
                        else if (selected == "Phone No.")
                        {
                            values[2] = value;
                        }
                        else if (selected == "Deposit")
                        {
                            values[3] = "R" + value;
                        }
                        else if (selected == "Rent Amt")
                        {
                            values[4] = "R" + value;
                        }
                        else if (selected == "Lease End")
                        {
                            values[5] = value;
                        }
                        else if (selected == "Paid Amt")
                        {
                            values[6] = "R" + value;
                        }
                        else if (selected == "COMMENT")
                        {
                            values[7] = value;
                        }
                        else
                        {
                            throw new ArgumentException("Invalid selected value");
                        }

                        lines[i] = string.Join(",", values);
                        break;
                    }
                }

                File.WriteAllLines(filePath, lines);

                List<string> filteredLines = lines.Where(line =>
                {
                    string[] values = line.Split(',');
                    string lineName = values[0];
                    return lineName == name;
                }).ToList();

                DisplayData(filteredLines);
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Please Enter Tenant Details");
            }
        }

        public void DisplayData(List<string> lines)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Full Name");
            dt.Columns.Add("Room No.");
            dt.Columns.Add("Phone NO.");
            dt.Columns.Add("Deposit");
            dt.Columns.Add("Rent Amt");
            dt.Columns.Add("Lease End");
            dt.Columns.Add("Paid Amt");
            dt.Columns.Add("COMMENT");

            foreach (string line in lines)
            {
                string[] values = line.Split(',');
                dt.Rows.Add(values);
            }

            gridEdit.DataSource = dt;
        }

        private void btnUdoEdit_Click(object sender, EventArgs e)
        {
            
        }
    }
}
