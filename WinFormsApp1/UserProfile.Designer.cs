namespace ParkWay
{
    partial class UserProfile
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
            pictureBox1 = new PictureBox();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            lblFirstName = new Label();
            lblLastName = new Label();
            lblUsername = new Label();
            lblPassword = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BackColor = SystemColors.Control;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Image = Properties.Resources.avatar_12124771;
            pictureBox1.Location = new Point(417, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(160, 160);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // txtFirstName
            // 
            txtFirstName.Anchor = AnchorStyles.None;
            txtFirstName.ForeColor = SystemColors.ControlText;
            txtFirstName.Location = new Point(386, 229);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(235, 27);
            txtFirstName.TabIndex = 1;
            // 
            // txtLastName
            // 
            txtLastName.Anchor = AnchorStyles.None;
            txtLastName.ForeColor = SystemColors.ControlText;
            txtLastName.Location = new Point(383, 289);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(238, 27);
            txtLastName.TabIndex = 2;
            // 
            // txtUsername
            // 
            txtUsername.Anchor = AnchorStyles.None;
            txtUsername.ForeColor = SystemColors.ControlText;
            txtUsername.Location = new Point(383, 352);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(238, 27);
            txtUsername.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.None;
            txtPassword.ForeColor = SystemColors.ControlText;
            txtPassword.Location = new Point(383, 419);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(241, 27);
            txtPassword.TabIndex = 4;
            // 
            // lblFirstName
            // 
            lblFirstName.Anchor = AnchorStyles.None;
            lblFirstName.AutoSize = true;
            lblFirstName.BackColor = SystemColors.Control;
            lblFirstName.ForeColor = SystemColors.ActiveCaptionText;
            lblFirstName.Location = new Point(240, 232);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(80, 20);
            lblFirstName.TabIndex = 5;
            lblFirstName.Text = "First name:";
            // 
            // lblLastName
            // 
            lblLastName.Anchor = AnchorStyles.None;
            lblLastName.AutoSize = true;
            lblLastName.BackColor = SystemColors.Control;
            lblLastName.ForeColor = SystemColors.ActiveCaptionText;
            lblLastName.Location = new Point(240, 292);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(79, 20);
            lblLastName.TabIndex = 6;
            lblLastName.Text = "Last name:";
            // 
            // lblUsername
            // 
            lblUsername.Anchor = AnchorStyles.None;
            lblUsername.AutoSize = true;
            lblUsername.BackColor = SystemColors.Control;
            lblUsername.ForeColor = SystemColors.ActiveCaptionText;
            lblUsername.Location = new Point(240, 359);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(78, 20);
            lblUsername.TabIndex = 7;
            lblUsername.Text = "Username:";
            // 
            // lblPassword
            // 
            lblPassword.Anchor = AnchorStyles.None;
            lblPassword.AutoSize = true;
            lblPassword.BackColor = SystemColors.Control;
            lblPassword.ForeColor = SystemColors.ActiveCaptionText;
            lblPassword.Location = new Point(240, 422);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(73, 20);
            lblPassword.TabIndex = 8;
            lblPassword.Text = "Password:";
            // 
            // UserProfile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(978, 540);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Controls.Add(lblLastName);
            Controls.Add(lblFirstName);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(pictureBox1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "UserProfile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserProfile";
            WindowState = FormWindowState.Maximized;
            Load += UserProfile_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label lblFirstName;
        private Label lblLastName;
        private Label lblUsername;
        private Label lblPassword;
    }
}