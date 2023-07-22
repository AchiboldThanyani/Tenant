namespace Tanent
{
    partial class Register
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tanentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.moDataSet = new Tanent.MoDataSet();
            this.tanentsTableAdapter = new Tanent.MoDataSetTableAdapters.TanentsTableAdapter();
            this.tableAdapterManager = new Tanent.MoDataSetTableAdapters.TableAdapterManager();
            this.gridRegister = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.fullName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.roomNo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.phoneNo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rentAmt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.leaseEnd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.paidAmt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.TERM = new System.Windows.Forms.Label();
            this.deposit = new System.Windows.Forms.TextBox();
            this.COMMENT = new System.Windows.Forms.ComboBox();
            this.registerClear = new System.Windows.Forms.Button();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOMMENTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tanentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridRegister)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.registerClear);
            this.panel1.Controls.Add(this.COMMENT);
            this.panel1.Controls.Add(this.deposit);
            this.panel1.Controls.Add(this.TERM);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.gridRegister);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.paidAmt);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.leaseEnd);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.rentAmt);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.phoneNo);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.roomNo);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.fullName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1624, 618);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // tanentsBindingSource
            // 
            this.tanentsBindingSource.DataMember = "Tanents";
            this.tanentsBindingSource.DataSource = this.moDataSet;
            // 
            // moDataSet
            // 
            this.moDataSet.DataSetName = "MoDataSet";
            this.moDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tanentsTableAdapter
            // 
            this.tanentsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TanentsTableAdapter = this.tanentsTableAdapter;
            this.tableAdapterManager.UpdateOrder = Tanent.MoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // gridRegister
            // 
            this.gridRegister.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridRegister.AutoGenerateColumns = false;
            this.gridRegister.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridRegister.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridRegister.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fullNameDataGridViewTextBoxColumn,
            this.roomN,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.cOMMENTDataGridViewTextBoxColumn});
            this.gridRegister.DataSource = this.tanentsBindingSource;
            this.gridRegister.Location = new System.Drawing.Point(45, 305);
            this.gridRegister.Name = "gridRegister";
            this.gridRegister.RowHeadersWidth = 51;
            this.gridRegister.RowTemplate.Height = 24;
            this.gridRegister.Size = new System.Drawing.Size(1489, 301);
            this.gridRegister.TabIndex = 26;
            this.gridRegister.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridRegister_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Full Name:";
            // 
            // fullName
            // 
            this.fullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullName.Location = new System.Drawing.Point(142, 26);
            this.fullName.Multiline = true;
            this.fullName.Name = "fullName";
            this.fullName.Size = new System.Drawing.Size(232, 31);
            this.fullName.TabIndex = 1;
            this.fullName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Room No:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // roomNo
            // 
            this.roomNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomNo.Location = new System.Drawing.Point(142, 76);
            this.roomNo.Multiline = true;
            this.roomNo.Name = "roomNo";
            this.roomNo.Size = new System.Drawing.Size(232, 31);
            this.roomNo.TabIndex = 3;
            this.roomNo.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(39, 136);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 24);
            this.label8.TabIndex = 12;
            this.label8.Text = "Phone No:";
            // 
            // phoneNo
            // 
            this.phoneNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNo.Location = new System.Drawing.Point(142, 133);
            this.phoneNo.Multiline = true;
            this.phoneNo.Name = "phoneNo";
            this.phoneNo.Size = new System.Drawing.Size(232, 31);
            this.phoneNo.TabIndex = 13;
            this.phoneNo.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(387, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 24);
            this.label7.TabIndex = 14;
            this.label7.Text = "Rent Amt:";
            // 
            // rentAmt
            // 
            this.rentAmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentAmt.Location = new System.Drawing.Point(490, 23);
            this.rentAmt.Multiline = true;
            this.rentAmt.Name = "rentAmt";
            this.rentAmt.Size = new System.Drawing.Size(232, 31);
            this.rentAmt.TabIndex = 15;
            this.rentAmt.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(387, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 24);
            this.label4.TabIndex = 16;
            this.label4.Text = "Lease End:";
            // 
            // leaseEnd
            // 
            this.leaseEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leaseEnd.Location = new System.Drawing.Point(490, 76);
            this.leaseEnd.Multiline = true;
            this.leaseEnd.Name = "leaseEnd";
            this.leaseEnd.Size = new System.Drawing.Size(232, 31);
            this.leaseEnd.TabIndex = 17;
            this.leaseEnd.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(387, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 24);
            this.label3.TabIndex = 18;
            this.label3.Text = "Paid Amt";
            // 
            // paidAmt
            // 
            this.paidAmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paidAmt.Location = new System.Drawing.Point(490, 126);
            this.paidAmt.Multiline = true;
            this.paidAmt.Name = "paidAmt";
            this.paidAmt.Size = new System.Drawing.Size(232, 31);
            this.paidAmt.TabIndex = 19;
            this.paidAmt.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(754, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 24);
            this.label9.TabIndex = 24;
            this.label9.Text = "COMMENT:";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAdd.Location = new System.Drawing.Point(874, 100);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(112, 45);
            this.btnAdd.TabIndex = 27;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // TERM
            // 
            this.TERM.AutoSize = true;
            this.TERM.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TERM.Location = new System.Drawing.Point(39, 187);
            this.TERM.Name = "TERM";
            this.TERM.Size = new System.Drawing.Size(78, 24);
            this.TERM.TabIndex = 28;
            this.TERM.Text = "Deposit:";
            // 
            // deposit
            // 
            this.deposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deposit.Location = new System.Drawing.Point(142, 180);
            this.deposit.Multiline = true;
            this.deposit.Name = "deposit";
            this.deposit.Size = new System.Drawing.Size(232, 31);
            this.deposit.TabIndex = 29;
            // 
            // COMMENT
            // 
            this.COMMENT.FormattingEnabled = true;
            this.COMMENT.Items.AddRange(new object[] {
            "Paid",
            "Not Paid",
            "Incomplete"});
            this.COMMENT.Location = new System.Drawing.Point(874, 26);
            this.COMMENT.Name = "COMMENT";
            this.COMMENT.Size = new System.Drawing.Size(224, 30);
            this.COMMENT.TabIndex = 34;
            // 
            // registerClear
            // 
            this.registerClear.Location = new System.Drawing.Point(1016, 102);
            this.registerClear.Name = "registerClear";
            this.registerClear.Size = new System.Drawing.Size(82, 41);
            this.registerClear.TabIndex = 36;
            this.registerClear.Text = "Clear";
            this.registerClear.UseVisualStyleBackColor = true;
            this.registerClear.Click += new System.EventHandler(this.registerClear_Click);
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "fullName";
            this.fullNameDataGridViewTextBoxColumn.HeaderText = "Full Name";
            this.fullNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            // 
            // roomN
            // 
            this.roomN.DataPropertyName = "roomNo";
            this.roomN.HeaderText = "Room No";
            this.roomN.MinimumWidth = 6;
            this.roomN.Name = "roomN";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "phone";
            this.Column1.HeaderText = "Phone";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "deposit";
            this.Column2.HeaderText = "Deposit";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "rentAmt";
            this.Column3.HeaderText = "Rent Amt";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "leaseEnd";
            this.Column4.HeaderText = "Lease End";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "paidAmt";
            this.Column5.HeaderText = "Paid Amt";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // cOMMENTDataGridViewTextBoxColumn
            // 
            this.cOMMENTDataGridViewTextBoxColumn.DataPropertyName = "COMMENT";
            this.cOMMENTDataGridViewTextBoxColumn.HeaderText = "COMMENT";
            this.cOMMENTDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cOMMENTDataGridViewTextBoxColumn.Name = "cOMMENTDataGridViewTextBoxColumn";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1624, 618);
            this.Controls.Add(this.panel1);
            this.Name = "Register";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tanentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridRegister)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MoDataSet moDataSet;
        private System.Windows.Forms.BindingSource tanentsBindingSource;
        private MoDataSetTableAdapters.TanentsTableAdapter tanentsTableAdapter;
        private MoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn rMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rEFFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tERMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rENTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dEPODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView gridRegister;
        private System.Windows.Forms.Button registerClear;
        private System.Windows.Forms.ComboBox COMMENT;
        private System.Windows.Forms.TextBox deposit;
        private System.Windows.Forms.Label TERM;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox paidAmt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox leaseEnd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox rentAmt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox phoneNo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox roomNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fullName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOMMENTDataGridViewTextBoxColumn;
    }
}