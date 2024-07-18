namespace ParkWay
{
    partial class Registration
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
            lblFirstName = new Label();
            lblLastName = new Label();
            lblUsername = new Label();
            lblPassword = new Label();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnRegister = new Button();
            SuspendLayout();
            // 
            // lblFirstName
            // 
            lblFirstName.Anchor = AnchorStyles.None;
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(205, 104);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(80, 20);
            lblFirstName.TabIndex = 0;
            lblFirstName.Text = "First name:";
            // 
            // lblLastName
            // 
            lblLastName.Anchor = AnchorStyles.None;
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(205, 167);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(79, 20);
            lblLastName.TabIndex = 1;
            lblLastName.Text = "Last name:";
            // 
            // lblUsername
            // 
            lblUsername.Anchor = AnchorStyles.None;
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(205, 232);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(78, 20);
            lblUsername.TabIndex = 2;
            lblUsername.Text = "Username:";
            // 
            // lblPassword
            // 
            lblPassword.Anchor = AnchorStyles.None;
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(205, 293);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(73, 20);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Password:";
            // 
            // txtFirstName
            // 
            txtFirstName.Anchor = AnchorStyles.None;
            txtFirstName.Location = new Point(316, 104);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(210, 27);
            txtFirstName.TabIndex = 4;
            // 
            // txtLastName
            // 
            txtLastName.Anchor = AnchorStyles.None;
            txtLastName.Location = new Point(316, 167);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(210, 27);
            txtLastName.TabIndex = 5;
            // 
            // txtUsername
            // 
            txtUsername.Anchor = AnchorStyles.None;
            txtUsername.Location = new Point(316, 232);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(210, 27);
            txtUsername.TabIndex = 6;
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.None;
            txtPassword.Location = new Point(316, 293);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(210, 27);
            txtPassword.TabIndex = 7;
            // 
            // btnRegister
            // 
            btnRegister.Anchor = AnchorStyles.None;
            btnRegister.Location = new Point(354, 380);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(94, 29);
            btnRegister.TabIndex = 8;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // Registration
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRegister);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Controls.Add(lblLastName);
            Controls.Add(lblFirstName);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Registration";
            Text = "ParkWay";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFirstName;
        private Label lblLastName;
        private Label lblUsername;
        private Label lblPassword;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnRegister;
    }
}