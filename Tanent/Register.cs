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
    public partial class Register : Form
    {
        private string filePath = "tenant.txt";
        public Register()
        {
            InitializeComponent();
            //button1.Visible = false;   
            displayData();
        }

        private void tanentsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tanentsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.moDataSet);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void Register_Load(object sender, EventArgs e)
        {
            // Load data from the text file
            displayData();
        }

        public void displayData() // update the currently added data
        {
            DataTable dt = LoadDataFromTextFile();
            gridRegister.DataSource = dt;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Construct the data string to write to the text file
                string data = $"{fullName.Text},{roomNo.Text},{phoneNo.Text},R{deposit.Text},R{rentAmt.Text},{leaseEnd.Text},R{paidAmt.Text},{COMMENT.SelectedItem.ToString()}";

                // Append the data to the text file
                AppendDataToTextFile(data);

                displayData();
                MessageBox.Show("Tenant inserted successfully");
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Please enter Tenant details");
            }
        }
        private DataTable LoadDataFromTextFile()
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


        private void AppendDataToTextFile(string data)
        {
            try
            {
                using (StreamWriter writer = File.AppendText(filePath))
                {
                    writer.WriteLine(data);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving tenant data: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void gridRegister_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void registerClear_Click(object sender, EventArgs e)
        {
            fullName.Clear();
            roomNo.Clear();
            phoneNo.Clear();
            deposit.Clear();
            rentAmt.Clear();
            leaseEnd.Clear();
            paidAmt.Clear();
            COMMENT.SelectedItem = null;
        }
    }
}
