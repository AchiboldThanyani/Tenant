namespace Tanent
{
    partial class Remove_Tanent
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
            this.btnSearchRemove = new System.Windows.Forms.Button();
            this.tanentDelete = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.searchByDelete = new System.Windows.Forms.ComboBox();
            this.btnUdoRemove = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.gridDelete = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSearchRemove);
            this.panel1.Controls.Add(this.tanentDelete);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.searchByDelete);
            this.panel1.Controls.Add(this.btnUdoRemove);
            this.panel1.Controls.Add(this.btnRemove);
            this.panel1.Controls.Add(this.gridDelete);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1236, 587);
            this.panel1.TabIndex = 0;
            // 
            // btnSearchRemove
            // 
            this.btnSearchRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnSearchRemove.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSearchRemove.Location = new System.Drawing.Point(487, 67);
            this.btnSearchRemove.Name = "btnSearchRemove";
            this.btnSearchRemove.Size = new System.Drawing.Size(112, 45);
            this.btnSearchRemove.TabIndex = 47;
            this.btnSearchRemove.Text = "Search";
            this.btnSearchRemove.UseVisualStyleBackColor = false;
            this.btnSearchRemove.Click += new System.EventHandler(this.btnSearchRemove_Click);
            // 
            // tanentDelete
            // 
            this.tanentDelete.Location = new System.Drawing.Point(181, 82);
            this.tanentDelete.Multiline = true;
            this.tanentDelete.Name = "tanentDelete";
            this.tanentDelete.Size = new System.Drawing.Size(288, 29);
            this.tanentDelete.TabIndex = 46;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 24);
            this.label5.TabIndex = 45;
            this.label5.Text = "Enter Tanent:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 24);
            this.label4.TabIndex = 44;
            this.label4.Text = "Search By:";
            // 
            // searchByDelete
            // 
            this.searchByDelete.FormattingEnabled = true;
            this.searchByDelete.Items.AddRange(new object[] {
            "Room No",
            "Full Name"});
            this.searchByDelete.Location = new System.Drawing.Point(181, 34);
            this.searchByDelete.Name = "searchByDelete";
            this.searchByDelete.Size = new System.Drawing.Size(288, 30);
            this.searchByDelete.TabIndex = 43;
            // 
            // btnUdoRemove
            // 
            this.btnUdoRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnUdoRemove.ForeColor = System.Drawing.SystemColors.Control;
            this.btnUdoRemove.Location = new System.Drawing.Point(369, 163);
            this.btnUdoRemove.Name = "btnUdoRemove";
            this.btnUdoRemove.Size = new System.Drawing.Size(112, 45);
            this.btnUdoRemove.TabIndex = 42;
            this.btnUdoRemove.Text = "Undo";
            this.btnUdoRemove.UseVisualStyleBackColor = false;
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnRemove.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRemove.Location = new System.Drawing.Point(181, 163);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(112, 45);
            this.btnRemove.TabIndex = 41;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // gridDelete
            // 
            this.gridDelete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridDelete.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridDelete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDelete.Location = new System.Drawing.Point(12, 239);
            this.gridDelete.Name = "gridDelete";
            this.gridDelete.RowHeadersWidth = 51;
            this.gridDelete.RowTemplate.Height = 24;
            this.gridDelete.Size = new System.Drawing.Size(1201, 150);
            this.gridDelete.TabIndex = 36;
            // 
            // Remove_Tanent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 587);
            this.Controls.Add(this.panel1);
            this.Name = "Remove_Tanent";
            this.Text = "Remove_Tanent";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDelete)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tanentDelete;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox searchByDelete;
        private System.Windows.Forms.Button btnUdoRemove;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.DataGridView gridDelete;
        private System.Windows.Forms.Button btnSearchRemove;
    }
}