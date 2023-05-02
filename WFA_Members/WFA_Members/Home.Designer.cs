namespace WFA_Members
{
    partial class Home
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
            this.GetAllCustomers = new System.Windows.Forms.Button();
            this.GetCustomerById = new System.Windows.Forms.Button();
            this.Create = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GetAllCustomers
            // 
            this.GetAllCustomers.Location = new System.Drawing.Point(83, 104);
            this.GetAllCustomers.Name = "GetAllCustomers";
            this.GetAllCustomers.Size = new System.Drawing.Size(125, 50);
            this.GetAllCustomers.TabIndex = 4;
            this.GetAllCustomers.Text = "All Members";
            this.GetAllCustomers.UseVisualStyleBackColor = true;
            this.GetAllCustomers.Click += new System.EventHandler(this.GetAllCustomers_Click);
            // 
            // GetCustomerById
            // 
            this.GetCustomerById.Location = new System.Drawing.Point(258, 104);
            this.GetCustomerById.Name = "GetCustomerById";
            this.GetCustomerById.Size = new System.Drawing.Size(125, 50);
            this.GetCustomerById.TabIndex = 5;
            this.GetCustomerById.Text = "Find a Member";
            this.GetCustomerById.UseVisualStyleBackColor = true;
            this.GetCustomerById.Click += new System.EventHandler(this.GetCustomerById_Click);
            // 
            // Create
            // 
            this.Create.Location = new System.Drawing.Point(433, 104);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(125, 50);
            this.Create.TabIndex = 6;
            this.Create.Text = "New Member";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(608, 104);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(125, 50);
            this.Update.TabIndex = 7;
            this.Update.Text = "Edit a Member";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(783, 104);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(125, 50);
            this.Delete.TabIndex = 8;
            this.Delete.Text = "Delete a Member";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 253);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Create);
            this.Controls.Add(this.GetCustomerById);
            this.Controls.Add(this.GetAllCustomers);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Home_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button GetAllCustomers;
        private System.Windows.Forms.Button GetCustomerById;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Delete;
    }
}

