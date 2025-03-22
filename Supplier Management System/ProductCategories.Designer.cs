namespace Supplier_Management_System
{
    partial class ProductCategories
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
            lblProductCategories = new Label();
            txtCategories = new TextBox();
            btnAddCategories = new Button();
            dataGridView1 = new DataGridView();
            Delete = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblProductCategories
            // 
            lblProductCategories.AutoSize = true;
            lblProductCategories.Enabled = false;
            lblProductCategories.Location = new Point(165, 43);
            lblProductCategories.Name = "lblProductCategories";
            lblProductCategories.Size = new Size(158, 25);
            lblProductCategories.TabIndex = 0;
            lblProductCategories.Text = "ProductCategories";
            // 
            // txtCategories
            // 
            txtCategories.Location = new Point(369, 40);
            txtCategories.Name = "txtCategories";
            txtCategories.Size = new Size(150, 31);
            txtCategories.TabIndex = 1;
            // 
            // btnAddCategories
            // 
            btnAddCategories.Location = new Point(265, 105);
            btnAddCategories.Name = "btnAddCategories";
            btnAddCategories.Size = new Size(209, 34);
            btnAddCategories.TabIndex = 2;
            btnAddCategories.Text = "AddCategories";
            btnAddCategories.UseVisualStyleBackColor = true;
            btnAddCategories.Click += btnAddCategories_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Delete });
            dataGridView1.Location = new Point(83, 172);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(624, 242);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Delete
            // 
            Delete.HeaderText = "Delete";
            Delete.MinimumWidth = 8;
            Delete.Name = "Delete";
            Delete.Text = "Delete";
            Delete.Width = 150;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(btnAddCategories);
            Controls.Add(txtCategories);
            Controls.Add(lblProductCategories);
            Name = "MainMenu";
            Text = "MainMenu";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblProductCategories;
        private TextBox txtCategories;
        private Button btnAddCategories;
        private DataGridView dataGridView1;
        private DataGridViewButtonColumn Delete;
    }
}