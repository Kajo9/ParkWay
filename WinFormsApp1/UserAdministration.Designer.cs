namespace ParkWay
{
    partial class UserAdministration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserAdministration));
            lblFirstName = new Label();
            lblLastName = new Label();
            lblUsername = new Label();
            lblPassword = new Label();
            lblRole = new Label();
            txtFirsName = new TextBox();
            txtLastName = new TextBox();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            cbRole = new ComboBox();
            dgvUsers = new DataGridView();
            menuStrip1 = new MenuStrip();
            newToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            lblStar = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(19, 132);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(86, 20);
            lblFirstName.TabIndex = 0;
            lblFirstName.Text = "First name:*";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(17, 168);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(85, 20);
            lblLastName.TabIndex = 1;
            lblLastName.Text = "Last name:*";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(19, 226);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(84, 20);
            lblUsername.TabIndex = 2;
            lblUsername.Text = "Username:*";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(19, 290);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(79, 20);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Password:*";
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Location = new Point(19, 352);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(48, 20);
            lblRole.TabIndex = 4;
            lblRole.Text = "Role:*";
            // 
            // txtFirsName
            // 
            txtFirsName.Location = new Point(157, 113);
            txtFirsName.Name = "txtFirsName";
            txtFirsName.Size = new Size(200, 27);
            txtFirsName.TabIndex = 5;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(157, 165);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(200, 27);
            txtLastName.TabIndex = 6;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(157, 223);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(200, 27);
            txtUsername.TabIndex = 7;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(157, 283);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(200, 27);
            txtPassword.TabIndex = 8;
            // 
            // cbRole
            // 
            cbRole.FormattingEnabled = true;
            cbRole.Location = new Point(157, 344);
            cbRole.Name = "cbRole";
            cbRole.Size = new Size(200, 28);
            cbRole.TabIndex = 10;
            // 
            // dgvUsers
            // 
            dgvUsers.AllowUserToResizeColumns = false;
            dgvUsers.AllowUserToResizeRows = false;
            dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsers.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvUsers.ColumnHeadersHeight = 29;
            dgvUsers.Location = new Point(493, 52);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.ReadOnly = true;
            dgvUsers.RowHeadersWidth = 51;
            dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsers.Size = new Size(843, 371);
            dgvUsers.TabIndex = 0;
            dgvUsers.CellFormatting += dgvUsers_CellFormatting;
            dgvUsers.SelectionChanged += dgvUsers_SelectionChanged;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { newToolStripMenuItem, saveToolStripMenuItem, deleteToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1357, 28);
            menuStrip1.TabIndex = 12;
            menuStrip1.Text = "menuStrip1";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Image = (Image)resources.GetObject("newToolStripMenuItem.Image");
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            newToolStripMenuItem.Size = new Size(73, 24);
            newToolStripMenuItem.Text = "New";
            newToolStripMenuItem.ToolTipText = "Ctrl+D";
            newToolStripMenuItem.Click += newToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Image = (Image)resources.GetObject("saveToolStripMenuItem.Image");
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            saveToolStripMenuItem.Size = new Size(74, 24);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Image = Properties.Resources.delete_4980658;
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.D;
            deleteToolStripMenuItem.Size = new Size(87, 24);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.ToolTipText = "Ctrl+D";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // lblStar
            // 
            lblStar.AutoSize = true;
            lblStar.ForeColor = SystemColors.ControlText;
            lblStar.Location = new Point(12, 52);
            lblStar.Name = "lblStar";
            lblStar.Size = new Size(325, 20);
            lblStar.TabIndex = 13;
            lblStar.Text = "Sve označno zvijezdom mora biti popunjeno (*)";
            // 
            // UserAdministration
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1357, 451);
            Controls.Add(lblStar);
            Controls.Add(dgvUsers);
            Controls.Add(cbRole);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(txtLastName);
            Controls.Add(txtFirsName);
            Controls.Add(lblRole);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Controls.Add(lblLastName);
            Controls.Add(lblFirstName);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "UserAdministration";
            Text = "User administration";
            WindowState = FormWindowState.Maximized;
            Load += Registration_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFirstName;
        private Label lblLastName;
        private Label lblUsername;
        private Label lblPassword;
        private Label lblRole;
        private TextBox txtFirsName;
        private TextBox txtLastName;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private ComboBox cbRole;
        private DataGridView dgvUsers;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private Label lblStar;
    }
}