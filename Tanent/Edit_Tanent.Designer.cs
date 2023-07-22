namespace Tanent
{
    partial class Edit_Tanent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.tanent = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.searchByEdit = new System.Windows.Forms.ComboBox();
            this.btnUdoEdit = new System.Windows.Forms.Button();
            this.btnDoneEdit = new System.Windows.Forms.Button();
            this.oldValue = new System.Windows.Forms.TextBox();
            this.lblOldValue = new System.Windows.Forms.Label();
            this.newValue = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gridEdit = new System.Windows.Forms.DataGridView();
            this.comboBoxEdit = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tanent);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.searchByEdit);
            this.panel1.Controls.Add(this.btnUdoEdit);
            this.panel1.Controls.Add(this.btnDoneEdit);
            this.panel1.Controls.Add(this.oldValue);
            this.panel1.Controls.Add(this.lblOldValue);
            this.panel1.Controls.Add(this.newValue);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.gridEdit);
            this.panel1.Controls.Add(this.comboBoxEdit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1108, 587);
            this.panel1.TabIndex = 0;
            // 
            // tanent
            // 
            this.tanent.Location = new System.Drawing.Point(181, 74);
            this.tanent.Multiline = true;
            this.tanent.Name = "tanent";
            this.tanent.Size = new System.Drawing.Size(288, 29);
            this.tanent.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 24);
            this.label5.TabIndex = 32;
            this.label5.Text = "Enter Tenant:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 24);
            this.label4.TabIndex = 31;
            this.label4.Text = "Search By:";
            // 
            // searchByEdit
            // 
            this.searchByEdit.FormattingEnabled = true;
            this.searchByEdit.Items.AddRange(new object[] {
            "Room No",
            "Full Name"});
            this.searchByEdit.Location = new System.Drawing.Point(181, 26);
            this.searchByEdit.Name = "searchByEdit";
            this.searchByEdit.Size = new System.Drawing.Size(288, 30);
            this.searchByEdit.TabIndex = 30;
            // 
            // btnUdoEdit
            // 
            this.btnUdoEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnUdoEdit.ForeColor = System.Drawing.SystemColors.Control;
            this.btnUdoEdit.Location = new System.Drawing.Point(713, 125);
            this.btnUdoEdit.Name = "btnUdoEdit";
            this.btnUdoEdit.Size = new System.Drawing.Size(112, 45);
            this.btnUdoEdit.TabIndex = 29;
            this.btnUdoEdit.Text = "Undo";
            this.btnUdoEdit.UseVisualStyleBackColor = false;
            this.btnUdoEdit.Click += new System.EventHandler(this.btnUdoEdit_Click);
            // 
            // btnDoneEdit
            // 
            this.btnDoneEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnDoneEdit.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDoneEdit.Location = new System.Drawing.Point(513, 126);
            this.btnDoneEdit.Name = "btnDoneEdit";
            this.btnDoneEdit.Size = new System.Drawing.Size(112, 45);
            this.btnDoneEdit.TabIndex = 28;
            this.btnDoneEdit.Text = "Done";
            this.btnDoneEdit.UseVisualStyleBackColor = false;
            this.btnDoneEdit.Click += new System.EventHandler(this.btnDoneEdit_Click);
            // 
            // oldValue
            // 
            this.oldValue.Location = new System.Drawing.Point(654, 27);
            this.oldValue.Multiline = true;
            this.oldValue.Name = "oldValue";
            this.oldValue.Size = new System.Drawing.Size(288, 29);
            this.oldValue.TabIndex = 8;
            // 
            // lblOldValue
            // 
            this.lblOldValue.AutoSize = true;
            this.lblOldValue.Location = new System.Drawing.Point(517, 33);
            this.lblOldValue.Name = "lblOldValue";
            this.lblOldValue.Size = new System.Drawing.Size(99, 24);
            this.lblOldValue.TabIndex = 7;
            this.lblOldValue.Text = "Old Value:";
            // 
            // newValue
            // 
            this.newValue.Location = new System.Drawing.Point(654, 67);
            this.newValue.Multiline = true;
            this.newValue.Name = "newValue";
            this.newValue.Size = new System.Drawing.Size(288, 29);
            this.newValue.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(517, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "New Value:";
            // 
            // gridEdit
            // 
            this.gridEdit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridEdit.Location = new System.Drawing.Point(12, 231);
            this.gridEdit.Name = "gridEdit";
            this.gridEdit.RowHeadersWidth = 51;
            this.gridEdit.RowTemplate.Height = 24;
            this.gridEdit.Size = new System.Drawing.Size(1084, 150);
            this.gridEdit.TabIndex = 4;
            // 
            // comboBoxEdit
            // 
            this.comboBoxEdit.FormattingEnabled = true;
            this.comboBoxEdit.Items.AddRange(new object[] {
            "Full Name",
            "Room No.",
            "Phone No.",
            "Deposit",
            "Rent Amt",
            "Lease End",
            "Paid Amt",
            "COMMENT"});
            this.comboBoxEdit.Location = new System.Drawing.Point(181, 131);
            this.comboBoxEdit.Name = "comboBoxEdit";
            this.comboBoxEdit.Size = new System.Drawing.Size(288, 30);
            this.comboBoxEdit.TabIndex = 3;
            this.comboBoxEdit.SelectedIndexChanged += new System.EventHandler(this.comboBoxEdit_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select Attribute:";
            // 
            // Edit_Tanent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 587);
            this.Controls.Add(this.panel1);
            this.Name = "Edit_Tanent";
            this.Text = "Edit_Tanent";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridEdit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox oldValue;
        private System.Windows.Forms.Label lblOldValue;
        private System.Windows.Forms.TextBox newValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView gridEdit;
        private System.Windows.Forms.ComboBox comboBoxEdit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUdoEdit;
        private System.Windows.Forms.Button btnDoneEdit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox searchByEdit;
        private System.Windows.Forms.TextBox tanent;
        private System.Windows.Forms.Label label5;
    }
}