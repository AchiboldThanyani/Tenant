namespace Tanent
{
    partial class Not_Paid
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
            this.gridNotPaid = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.gridNotPaid)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridNotPaid
            // 
            this.gridNotPaid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridNotPaid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridNotPaid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridNotPaid.Location = new System.Drawing.Point(0, 0);
            this.gridNotPaid.Name = "gridNotPaid";
            this.gridNotPaid.RowHeadersWidth = 51;
            this.gridNotPaid.RowTemplate.Height = 24;
            this.gridNotPaid.Size = new System.Drawing.Size(1234, 587);
            this.gridNotPaid.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gridNotPaid);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1234, 587);
            this.panel2.TabIndex = 3;
            // 
            // Not_Paid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 587);
            this.Controls.Add(this.panel2);
            this.Name = "Not_Paid";
            this.Text = "Not_Paid";
            ((System.ComponentModel.ISupportInitialize)(this.gridNotPaid)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridNotPaid;
        private System.Windows.Forms.Panel panel2;
    }
}