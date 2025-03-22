namespace Supplier_Management_System
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            txtUserName = new TextBox();
            txtpassword = new TextBox();
            lblUserName = new Label();
            lblPassword = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(222, 224);
            button1.Name = "button1";
            button1.Size = new Size(161, 87);
            button1.TabIndex = 0;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(285, 59);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(254, 31);
            txtUserName.TabIndex = 3;
            // 
            // txtpassword
            // 
            txtpassword.Location = new Point(285, 128);
            txtpassword.Name = "txtpassword";
            txtpassword.Size = new Size(254, 31);
            txtpassword.TabIndex = 4;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Location = new Point(108, 65);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(94, 25);
            lblUserName.TabIndex = 5;
            lblUserName.Text = "UserName";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(108, 131);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(87, 25);
            lblPassword.TabIndex = 6;
            lblPassword.Text = "Password";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblPassword);
            Controls.Add(lblUserName);
            Controls.Add(txtpassword);
            Controls.Add(txtUserName);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox txtUserName;
        private TextBox txtpassword;
        private Label lblUserName;
        private Label lblPassword;
    }
}
