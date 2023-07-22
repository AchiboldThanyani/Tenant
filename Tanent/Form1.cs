using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tanent
{
    public partial class Form1 : Form
    {
        private Form activeForm;
        public Form1()
        {
            InitializeComponent();
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(childForm);
            this.panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Register(), sender);
        }

        private void Payment_Click(object sender, EventArgs e)
        {
            OpenChildForm( new Payment(), sender);
        }

        private void AllTanents_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Tanents(), sender);
        }

        private void paid_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Paid(), sender);
        }

        private void notPaid_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Not_Paid(), sender);
        }

        private void editTanent_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Edit_Tanent(), sender);
        }

        private void removeTanent_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Remove_Tanent(), sender);
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Home(), sender);
        }
    }
}
