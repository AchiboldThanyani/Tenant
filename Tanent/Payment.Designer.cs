namespace Tanent
{
    partial class Payment
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
            this.moDataSet = new Tanent.MoDataSet();
            this.tanentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tanentsTableAdapter = new Tanent.MoDataSetTableAdapters.TanentsTableAdapter();
            this.tableAdapterManager = new Tanent.MoDataSetTableAdapters.TableAdapterManager();
            this.panel1 = new System.Windows.Forms.Panel();
            this.hideIncomplete = new System.Windows.Forms.Button();
            this.hideBtn = new System.Windows.Forms.Button();
            this.checkIncompletePatment = new System.Windows.Forms.CheckBox();
            this.hideHeader = new System.Windows.Forms.Label();
            this.hideTxtPaid = new System.Windows.Forms.TextBox();
            this.hideLabel = new System.Windows.Forms.Label();
            this.paymentClear = new System.Windows.Forms.Button();
            this.checkNotPaidPayment = new System.Windows.Forms.CheckBox();
            this.btnResetPayment = new System.Windows.Forms.Button();
            this.btnSearchPayment = new System.Windows.Forms.Button();
            this.checkPaidPayment = new System.Windows.Forms.CheckBox();
            this.txtSearchPayment = new System.Windows.Forms.TextBox();
            this.searchByPayement = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gridPayment = new System.Windows.Forms.DataGridView();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOMMENTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.moDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tanentsBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPayment)).BeginInit();
            this.SuspendLayout();
            // 
            // moDataSet
            // 
            this.moDataSet.DataSetName = "MoDataSet";
            this.moDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tanentsBindingSource
            // 
            this.tanentsBindingSource.DataMember = "Tanents";
            this.tanentsBindingSource.DataSource = this.moDataSet;
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
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.hideIncomplete);
            this.panel1.Controls.Add(this.hideBtn);
            this.panel1.Controls.Add(this.checkIncompletePatment);
            this.panel1.Controls.Add(this.hideHeader);
            this.panel1.Controls.Add(this.hideTxtPaid);
            this.panel1.Controls.Add(this.hideLabel);
            this.panel1.Controls.Add(this.paymentClear);
            this.panel1.Controls.Add(this.checkNotPaidPayment);
            this.panel1.Controls.Add(this.btnResetPayment);
            this.panel1.Controls.Add(this.btnSearchPayment);
            this.panel1.Controls.Add(this.checkPaidPayment);
            this.panel1.Controls.Add(this.txtSearchPayment);
            this.panel1.Controls.Add(this.searchByPayement);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(718, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 640);
            this.panel1.TabIndex = 0;
            // 
            // hideIncomplete
            // 
            this.hideIncomplete.Location = new System.Drawing.Point(225, 391);
            this.hideIncomplete.Name = "hideIncomplete";
            this.hideIncomplete.Size = new System.Drawing.Size(131, 37);
            this.hideIncomplete.TabIndex = 14;
            this.hideIncomplete.Text = "Incomplete";
            this.hideIncomplete.UseVisualStyleBackColor = true;
            this.hideIncomplete.Visible = false;
            this.hideIncomplete.Click += new System.EventHandler(this.hideIncomplete_Click);
            // 
            // hideBtn
            // 
            this.hideBtn.Location = new System.Drawing.Point(132, 391);
            this.hideBtn.Name = "hideBtn";
            this.hideBtn.Size = new System.Drawing.Size(82, 37);
            this.hideBtn.TabIndex = 13;
            this.hideBtn.Text = "Done";
            this.hideBtn.UseVisualStyleBackColor = true;
            this.hideBtn.Visible = false;
            this.hideBtn.Click += new System.EventHandler(this.hideBtn_Click);
            // 
            // checkIncompletePatment
            // 
            this.checkIncompletePatment.AutoSize = true;
            this.checkIncompletePatment.Location = new System.Drawing.Point(241, 221);
            this.checkIncompletePatment.Name = "checkIncompletePatment";
            this.checkIncompletePatment.Size = new System.Drawing.Size(125, 28);
            this.checkIncompletePatment.TabIndex = 12;
            this.checkIncompletePatment.Text = "Incomplete";
            this.checkIncompletePatment.UseVisualStyleBackColor = true;
            this.checkIncompletePatment.CheckedChanged += new System.EventHandler(this.checkIncompletePatment_CheckedChanged);
            // 
            // hideHeader
            // 
            this.hideHeader.AutoSize = true;
            this.hideHeader.Location = new System.Drawing.Point(3, 290);
            this.hideHeader.Name = "hideHeader";
            this.hideHeader.Size = new System.Drawing.Size(181, 24);
            this.hideHeader.TabIndex = 11;
            this.hideHeader.Text = "Incomplete Payment";
            this.hideHeader.Visible = false;
            // 
            // hideTxtPaid
            // 
            this.hideTxtPaid.Location = new System.Drawing.Point(132, 334);
            this.hideTxtPaid.Multiline = true;
            this.hideTxtPaid.Name = "hideTxtPaid";
            this.hideTxtPaid.Size = new System.Drawing.Size(207, 31);
            this.hideTxtPaid.TabIndex = 10;
            this.hideTxtPaid.Visible = false;
            // 
            // hideLabel
            // 
            this.hideLabel.AutoSize = true;
            this.hideLabel.Location = new System.Drawing.Point(3, 341);
            this.hideLabel.Name = "hideLabel";
            this.hideLabel.Size = new System.Drawing.Size(123, 24);
            this.hideLabel.TabIndex = 9;
            this.hideLabel.Text = "Paid Amount:";
            this.hideLabel.Visible = false;
            // 
            // paymentClear
            // 
            this.paymentClear.Location = new System.Drawing.Point(257, 119);
            this.paymentClear.Name = "paymentClear";
            this.paymentClear.Size = new System.Drawing.Size(109, 38);
            this.paymentClear.TabIndex = 8;
            this.paymentClear.Text = "Clear";
            this.paymentClear.UseVisualStyleBackColor = true;
            this.paymentClear.Click += new System.EventHandler(this.paymentClear_Click);
            // 
            // checkNotPaidPayment
            // 
            this.checkNotPaidPayment.AutoSize = true;
            this.checkNotPaidPayment.Location = new System.Drawing.Point(132, 221);
            this.checkNotPaidPayment.Name = "checkNotPaidPayment";
            this.checkNotPaidPayment.Size = new System.Drawing.Size(103, 28);
            this.checkNotPaidPayment.TabIndex = 7;
            this.checkNotPaidPayment.Text = "Not Paid";
            this.checkNotPaidPayment.UseVisualStyleBackColor = true;
            this.checkNotPaidPayment.CheckedChanged += new System.EventHandler(this.checkNotPaidPayment_CheckedChanged);
            // 
            // btnResetPayment
            // 
            this.btnResetPayment.Location = new System.Drawing.Point(126, 511);
            this.btnResetPayment.Name = "btnResetPayment";
            this.btnResetPayment.Size = new System.Drawing.Size(204, 35);
            this.btnResetPayment.TabIndex = 6;
            this.btnResetPayment.Text = "Reset All Payments";
            this.btnResetPayment.UseVisualStyleBackColor = true;
            this.btnResetPayment.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // btnSearchPayment
            // 
            this.btnSearchPayment.Location = new System.Drawing.Point(126, 119);
            this.btnSearchPayment.Name = "btnSearchPayment";
            this.btnSearchPayment.Size = new System.Drawing.Size(109, 38);
            this.btnSearchPayment.TabIndex = 5;
            this.btnSearchPayment.Text = "Search";
            this.btnSearchPayment.UseVisualStyleBackColor = true;
            this.btnSearchPayment.Click += new System.EventHandler(this.btnSearchPayment_Click);
            // 
            // checkPaidPayment
            // 
            this.checkPaidPayment.AutoSize = true;
            this.checkPaidPayment.Location = new System.Drawing.Point(57, 221);
            this.checkPaidPayment.Name = "checkPaidPayment";
            this.checkPaidPayment.Size = new System.Drawing.Size(69, 28);
            this.checkPaidPayment.TabIndex = 4;
            this.checkPaidPayment.Text = "Paid";
            this.checkPaidPayment.UseVisualStyleBackColor = true;
            this.checkPaidPayment.CheckedChanged += new System.EventHandler(this.checkPaidPayment_CheckedChanged);
            // 
            // txtSearchPayment
            // 
            this.txtSearchPayment.Location = new System.Drawing.Point(126, 71);
            this.txtSearchPayment.Multiline = true;
            this.txtSearchPayment.Name = "txtSearchPayment";
            this.txtSearchPayment.Size = new System.Drawing.Size(240, 31);
            this.txtSearchPayment.TabIndex = 3;
            // 
            // searchByPayement
            // 
            this.searchByPayement.FormattingEnabled = true;
            this.searchByPayement.Items.AddRange(new object[] {
            "Room No.",
            "Full Name"});
            this.searchByPayement.Location = new System.Drawing.Point(109, 24);
            this.searchByPayement.Name = "searchByPayement";
            this.searchByPayement.Size = new System.Drawing.Size(257, 30);
            this.searchByPayement.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Search by:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Tenant:";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.Controls.Add(this.gridPayment);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(712, 640);
            this.panel2.TabIndex = 1;
            // 
            // gridPayment
            // 
            this.gridPayment.AutoGenerateColumns = false;
            this.gridPayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPayment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fullNameDataGridViewTextBoxColumn,
            this.Column1,
            this.cOMMENTDataGridViewTextBoxColumn});
            this.gridPayment.DataSource = this.tanentsBindingSource;
            this.gridPayment.Location = new System.Drawing.Point(55, 25);
            this.gridPayment.Name = "gridPayment";
            this.gridPayment.RowHeadersWidth = 51;
            this.gridPayment.RowTemplate.Height = 24;
            this.gridPayment.Size = new System.Drawing.Size(642, 511);
            this.gridPayment.TabIndex = 0;
            this.gridPayment.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridPayment_CellContentClick);
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "fullName";
            this.fullNameDataGridViewTextBoxColumn.HeaderText = "Full Name";
            this.fullNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            this.fullNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "paidAmt";
            this.Column1.HeaderText = "Paid Amt";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // cOMMENTDataGridViewTextBoxColumn
            // 
            this.cOMMENTDataGridViewTextBoxColumn.DataPropertyName = "COMMENT";
            this.cOMMENTDataGridViewTextBoxColumn.HeaderText = "COMMENT";
            this.cOMMENTDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cOMMENTDataGridViewTextBoxColumn.Name = "cOMMENTDataGridViewTextBoxColumn";
            this.cOMMENTDataGridViewTextBoxColumn.Width = 150;
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1531, 640);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Payment";
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.Payment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.moDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tanentsBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridPayment)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MoDataSet moDataSet;
        private System.Windows.Forms.BindingSource tanentsBindingSource;
        private MoDataSetTableAdapters.TanentsTableAdapter tanentsTableAdapter;
        private MoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSearchPayment;
        private System.Windows.Forms.CheckBox checkPaidPayment;
        private System.Windows.Forms.TextBox txtSearchPayment;
        private System.Windows.Forms.ComboBox searchByPayement;
        private System.Windows.Forms.DataGridView gridPayment;
        private System.Windows.Forms.Button btnResetPayment;
        private System.Windows.Forms.CheckBox checkNotPaidPayment;
        private System.Windows.Forms.Button paymentClear;
        private System.Windows.Forms.Label hideHeader;
        private System.Windows.Forms.TextBox hideTxtPaid;
        private System.Windows.Forms.Label hideLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOMMENTDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button hideBtn;
        private System.Windows.Forms.CheckBox checkIncompletePatment;
        private System.Windows.Forms.Button hideIncomplete;
    }
}