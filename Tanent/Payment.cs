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
    public partial class Payment : Form
    {
        private string filePath = "tenant.txt";
        string refferenceOrName = ""; // to be changed based on the comboBox to help checkBox
        string toSearch = ""; // to be set as name or refference
        string check; // to be set to comment, to change the checkBox
        CheckBox checkBox;
        /// 
        /// </summary>
        public Payment()
        {
            InitializeComponent();
        }
        private void btnSearchPayment_Click(object sender, EventArgs e)
        {
            try
            {
                bool found = false;
                string searchBy = searchByPayement.SelectedItem.ToString();
                string search = txtSearchPayment.Text;
                List<string> lines = File.ReadAllLines(filePath).ToList();
                List<string> filteredLines = new List<string>();

                foreach (string line in lines)
                {
                    string[] values = line.Split(',');
                    string fullName = values[0];
                    string comment = values[7];

                    if ((searchBy == "Room No." && values[1] == search) ||
                        (searchBy == "Full Name" && fullName == search))
                    {
                        refferenceOrName = searchBy;
                        toSearch = search;
                        filteredLines.Add(line);
                        found = true;
                    }
                }
                if (!found)
                {
                    MessageBox.Show("Tenant Not Found");
                }
                DisplayData(filteredLines);
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Please Enter Correct Tenant Details");
            }
        }
        private void tanentsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tanentsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.moDataSet);

        }

        private void Payment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'moDataSet.Tanents' table. You can move, or remove it, as needed.
            //this.tanentsTableAdapter.Fill(this.moDataSet.Tanents);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void DisplayData(List<string> lines)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("FullName");
            dt.Columns.Add("paidAmt");
            dt.Columns.Add("Comment");

            foreach (string line in lines)
            {
                string[] values = line.Split(',');
                string fullName = values[0];
                string paid = values[6];
                string comment = values[7];
                dt.Rows.Add(fullName, paid, comment);
            }
            gridPayment.DataSource = dt;
        }

        private void checkPaidPayment_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePaymentStatus(refferenceOrName, toSearch, checkPaidPayment.Checked);
            checkNotPaidPayment.Checked = false;
        }

        private void checkNotPaidPayment_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePaymentStatus(refferenceOrName, toSearch, !checkNotPaidPayment.Checked);
            checkPaidPayment.Checked = false;
        }

        private void UpdatePaymentStatus(string refferenceOrName, string search, bool isPaid)
        {
            List<string> lines = File.ReadAllLines(filePath).ToList();
            List<string> filteredLines = new List<string>();
            for (int i = 0; i < lines.Count; i++)
            {
                string[] values = lines[i].Split(',');
                string fullName = values[0];

                if ((refferenceOrName == "Room No." && values[1] == search) ||
                    (refferenceOrName == "Full Name" && fullName == search))
                {
                    if (isPaid)
                    {
                        values[6] = values[4];
                        values[7] = "Paid";
                    }
                    else
                    {
                        values[6] = "R0";
                        values[7] = "Not Paid";
                    }

                    lines[i] = string.Join(",", values);
                    filteredLines.Add(lines[i]); // Add the modified line to the filteredLines list
                }
            }

            File.WriteAllLines(filePath, lines);
            DisplayData(filteredLines);
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to reset all payment statuses?", "Confirmation", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                List<string> lines = File.ReadAllLines(filePath).ToList();

                for (int i = 0; i < lines.Count; i++)
                {
                    string[] values = lines[i].Split(',');
                    values[6] = "R0";
                    values[7] = "Not Paid";
                    lines[i] = string.Join(",", values);
                }

                File.WriteAllLines(filePath, lines);
                DisplayData(lines);
            }
        }

        private void paymentClear_Click(object sender, EventArgs e)
        {
            List<string> filteredLines = new List<string>();
            DisplayData(filteredLines);
            txtSearchPayment.Clear();
            refferenceOrName = "";
            toSearch = "";
            searchByPayement.SelectedItem = null;
            checkPaidPayment.Checked = false;
            checkNotPaidPayment.Checked = false;
            checkIncompletePatment.Checked = false;
            hideHeader.Visible = false;
            hideLabel.Visible = false;
            hideTxtPaid.Visible = false;
            hideBtn.Visible = false;
            hideIncomplete.Visible = false;
        }

        private void checkIncompletePatment_CheckedChanged(object sender, EventArgs e)
        {
            checkIncomplet();
        }
        public void checkIncomplet()
        {
            if (checkIncompletePatment.Checked)
            {
                hideHeader.Visible = true;
                hideLabel.Visible = true;
                hideTxtPaid.Visible = true;
                hideBtn.Visible = true;
                hideIncomplete.Visible = true;
            } else
            {
                hideHeader.Visible = false;
                hideLabel.Visible = false;
                hideTxtPaid.Visible = false;
                hideBtn.Visible = false;
                hideIncomplete.Visible = false;
            }
        }

        private void gridPayment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void hideIncomplete_Click(object sender, EventArgs e)
        {
            string paid = hideTxtPaid.Text;
            updateIcompletePyament(refferenceOrName, toSearch, paid);
        }
        public void updateIcompletePyament(string refferenceOrName, string search, string paid)
        {
            List<string> lines = File.ReadAllLines(filePath).ToList();
            List<string> filteredLines = new List<string>();
            for (int i = 0; i < lines.Count; i++)
            {
                string[] values = lines[i].Split(',');
                string fullName = values[0];

                if ((refferenceOrName == "Room No." && values[1] == search) ||
                    (refferenceOrName == "Full Name" && fullName == search))
                {

                    values[6] = "R" + paid;
                    values[7] = "Incomplete";
                    lines[i] = string.Join(",", values);
                    filteredLines.Add(lines[i]); // Add the modified line to the filteredLines list
                }
            }

            File.WriteAllLines(filePath, lines);
            DisplayData(filteredLines);
        }

        private void hideBtn_Click(object sender, EventArgs e)
        {
            updateDonePayment(refferenceOrName, toSearch);
        }
        public void updateDonePayment(string refferenceOrName, string search)
        {
            List<string> lines = File.ReadAllLines(filePath).ToList();
            List<string> filteredLines = new List<string>();
            string cur = "";
            int paid = Convert.ToInt32(hideTxtPaid.Text);
            for (int i = 0; i < lines.Count; i++)
            {
                string[] values = lines[i].Split(',');
                string fullName = values[0];

                if ((refferenceOrName == "Room No." && values[1] == search) ||
                    (refferenceOrName == "Full Name" && fullName == search))
                {
                    cur = values[6];
                    cur = cur.Substring(1);
                    int sum = paid + Convert.ToInt32(cur);
                    values[6] = "R" + sum;
                    values[7] = "Paid";
                    lines[i] = string.Join(",", values);
                    filteredLines.Add(lines[i]); // Add the modified line to the filteredLines list
                }
            }

            File.WriteAllLines(filePath, lines);
            DisplayData(filteredLines);
        }
    }
}
