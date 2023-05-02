namespace WFA_Members
{
    partial class frmGetAllCustomers
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
            this.DGView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGView)).BeginInit();
            this.SuspendLayout();
            // 
            // DGView
            // 
            this.DGView.AllowUserToAddRows = false;
            this.DGView.AllowUserToDeleteRows = false;
            this.DGView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DGView.Location = new System.Drawing.Point(12, 46);
            this.DGView.Name = "DGView";
            this.DGView.ReadOnly = true;
            this.DGView.RowHeadersWidth = 51;
            this.DGView.RowTemplate.Height = 24;
            this.DGView.Size = new System.Drawing.Size(958, 392);
            this.DGView.TabIndex = 0;
            // 
            // frmGetAllCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 453);
            this.Controls.Add(this.DGView);
            this.Name = "frmGetAllCustomers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "GetAllCustomers";
            this.Load += new System.EventHandler(this.GetAllCustomers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGView;
    }
}