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
            btn_Cancel = new Button();
            btn_Login = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            lb_Username = new Label();
            lbl_Password = new Label();
            SuspendLayout();
            // 
            // btn_Cancel
            // 
            btn_Cancel.BackColor = SystemColors.Control;
            btn_Cancel.Location = new Point(438, 256);
            btn_Cancel.Name = "btn_Cancel";
            btn_Cancel.Size = new Size(94, 29);
            btn_Cancel.TabIndex = 0;
            btn_Cancel.Text = "Cancel";
            btn_Cancel.UseVisualStyleBackColor = false;
            btn_Cancel.Click += btn_Cancel_Click;
            // 
            // btn_Login
            // 
            btn_Login.BackColor = SystemColors.ActiveCaption;
            btn_Login.Location = new Point(51, 256);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(94, 29);
            btn_Login.TabIndex = 1;
            btn_Login.Text = "Login";
            btn_Login.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(265, 78);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(267, 27);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(265, 156);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(267, 27);
            textBox2.TabIndex = 3;
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
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(btn_Login);
            Controls.Add(btn_Cancel);
            Name = "Login";
            Text = "FrmLogin";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Cancel;
        private Button btn_Login;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label lb_Username;
        private Label lbl_Password;
    }
}
