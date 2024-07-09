namespace WinFormsApp1
{
    partial class Login
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
            btnCancel = new Button();
            btnLogin = new Button();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            lb_Username = new Label();
            lbl_Password = new Label();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.BackColor = SystemColors.Control;
            btnCancel.Location = new Point(438, 256);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btn_Cancel_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.ActiveCaption;
            btnLogin.Location = new Point(51, 256);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 29);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btn_Login_Click;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(265, 78);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(267, 27);
            txtUsername.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(265, 156);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(267, 27);
            txtPassword.TabIndex = 1;
            // 
            // lb_Username
            // 
            lb_Username.AutoSize = true;
            lb_Username.Location = new Point(51, 81);
            lb_Username.Name = "lb_Username";
            lb_Username.Size = new Size(82, 20);
            lb_Username.TabIndex = 4;
            lb_Username.Text = "Username: ";
            // 
            // lbl_Password
            // 
            lbl_Password.AutoSize = true;
            lbl_Password.Location = new Point(51, 156);
            lbl_Password.Name = "lbl_Password";
            lbl_Password.Size = new Size(77, 20);
            lbl_Password.TabIndex = 5;
            lbl_Password.Text = "Password: ";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(558, 334);
            Controls.Add(lbl_Password);
            Controls.Add(lb_Username);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(btnLogin);
            Controls.Add(btnCancel);
            Name = "Login";
            Text = "FrmLogin";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancel;
        private Button btnLogin;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label lb_Username;
        private Label lbl_Password;
    }
}
