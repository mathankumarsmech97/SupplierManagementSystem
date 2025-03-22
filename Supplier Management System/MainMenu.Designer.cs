namespace Supplier_Management_System
{
    partial class MainMenu
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
            btnProductCatagories = new Button();
            btnSupplierManagement = new Button();
            btnCustomerManagement = new Button();
            SuspendLayout();
            // 
            // btnProductCatagories
            // 
            btnProductCatagories.Location = new Point(47, 126);
            btnProductCatagories.Name = "btnProductCatagories";
            btnProductCatagories.Size = new Size(175, 70);
            btnProductCatagories.TabIndex = 0;
            btnProductCatagories.Text = "Product Catagories";
            btnProductCatagories.TextAlign = ContentAlignment.MiddleRight;
            btnProductCatagories.UseVisualStyleBackColor = true;
            btnProductCatagories.Click += btnProductCatagories_Click;
            // 
            // btnSupplierManagement
            // 
            btnSupplierManagement.Location = new Point(292, 126);
            btnSupplierManagement.Name = "btnSupplierManagement";
            btnSupplierManagement.Size = new Size(181, 70);
            btnSupplierManagement.TabIndex = 1;
            btnSupplierManagement.Text = "Supplier Management";
            btnSupplierManagement.UseVisualStyleBackColor = true;
            btnSupplierManagement.Click += btnSupplierManagement_Click;
            // 
            // btnCustomerManagement
            // 
            btnCustomerManagement.Location = new Point(542, 126);
            btnCustomerManagement.Name = "btnCustomerManagement";
            btnCustomerManagement.Size = new Size(176, 70);
            btnCustomerManagement.TabIndex = 2;
            btnCustomerManagement.Text = "Customer Management";
            btnCustomerManagement.UseVisualStyleBackColor = true;
            btnCustomerManagement.Click += btnCustomerManagement_Click;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCustomerManagement);
            Controls.Add(btnSupplierManagement);
            Controls.Add(btnProductCatagories);
            Name = "MainMenu";
            Text = "MainMenu";
            ResumeLayout(false);
        }

        #endregion

        private Button btnProductCatagories;
        private Button btnSupplierManagement;
        private Button btnCustomerManagement;
    }
}