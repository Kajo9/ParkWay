namespace ParkWay
{
    partial class ChangePassword
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
            lblNewPassword = new Label();
            lblConfirmPassword = new Label();
            txtNewPassword = new TextBox();
            txtConfirmPassword = new TextBox();
            btnChangePassword = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblNewPassword
            // 
            lblNewPassword.AutoSize = true;
            lblNewPassword.Location = new Point(201, 203);
            lblNewPassword.Name = "lblNewPassword";
            lblNewPassword.Size = new Size(109, 20);
            lblNewPassword.TabIndex = 0;
            lblNewPassword.Text = "New password:";
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.Location = new Point(201, 296);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(132, 20);
            lblConfirmPassword.TabIndex = 1;
            lblConfirmPassword.Text = "Confirm password:";
            // 
            // txtNewPassword
            // 
            txtNewPassword.Location = new Point(381, 203);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Size = new Size(195, 27);
            txtNewPassword.TabIndex = 2;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(381, 289);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(195, 27);
            txtConfirmPassword.TabIndex = 3;
            // 
            // btnChangePassword
            // 
            btnChangePassword.Location = new Point(267, 372);
            btnChangePassword.Name = "btnChangePassword";
            btnChangePassword.Size = new Size(262, 29);
            btnChangePassword.TabIndex = 4;
            btnChangePassword.Text = "Change password";
            btnChangePassword.UseVisualStyleBackColor = true;
            btnChangePassword.Click += btnChangePassword_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = Properties.Resources.password_entry_8031746;
            pictureBox1.Location = new Point(325, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(128, 128);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // ChangePassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(btnChangePassword);
            Controls.Add(txtConfirmPassword);
            Controls.Add(txtNewPassword);
            Controls.Add(lblConfirmPassword);
            Controls.Add(lblNewPassword);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ChangePassword";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ParkWay";
            WindowState = FormWindowState.Minimized;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNewPassword;
        private Label lblConfirmPassword;
        private TextBox txtNewPassword;
        private TextBox txtConfirmPassword;
        private Button btnChangePassword;
        private PictureBox pictureBox1;
    }
}