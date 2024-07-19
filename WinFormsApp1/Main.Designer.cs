namespace ParkWay
{
    partial class Main
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
            msCatalog = new MenuStrip();
            catalogToolStripMenuItem = new ToolStripMenuItem();
            floorsToolStripMenuItem = new ToolStripMenuItem();
            parkingSpotsToolStripMenuItem = new ToolStripMenuItem();
            usersToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            toolStripDropDownButton1 = new ToolStripDropDownButton();
            profileToolStripMenuItem = new ToolStripMenuItem();
            viewReservationsToolStripMenuItem = new ToolStripMenuItem();
            changepasswordOutToolStripMenuItem = new ToolStripMenuItem();
            logOutToolStripMenuItem1 = new ToolStripMenuItem();
            lblLogUser = new Label();
            msCatalog.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // msCatalog
            // 
            msCatalog.BackColor = SystemColors.GradientInactiveCaption;
            msCatalog.Dock = DockStyle.Left;
            msCatalog.ImageScalingSize = new Size(20, 20);
            msCatalog.Items.AddRange(new ToolStripItem[] { catalogToolStripMenuItem });
            msCatalog.Location = new Point(0, 0);
            msCatalog.Name = "msCatalog";
            msCatalog.Size = new Size(101, 424);
            msCatalog.TabIndex = 1;
            msCatalog.Text = "menuStrip1";
            // 
            // catalogToolStripMenuItem
            // 
            catalogToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { floorsToolStripMenuItem, parkingSpotsToolStripMenuItem, usersToolStripMenuItem });
            catalogToolStripMenuItem.Image = Properties.Resources.catalog_13085305;
            catalogToolStripMenuItem.Name = "catalogToolStripMenuItem";
            catalogToolStripMenuItem.Size = new Size(88, 24);
            catalogToolStripMenuItem.Text = "Catalog";
            // 
            // floorsToolStripMenuItem
            // 
            floorsToolStripMenuItem.Name = "floorsToolStripMenuItem";
            floorsToolStripMenuItem.Size = new Size(179, 26);
            floorsToolStripMenuItem.Text = "Floors";
            floorsToolStripMenuItem.Click += floorsToolStripMenuItem_Click;
            // 
            // parkingSpotsToolStripMenuItem
            // 
            parkingSpotsToolStripMenuItem.Name = "parkingSpotsToolStripMenuItem";
            parkingSpotsToolStripMenuItem.Size = new Size(179, 26);
            parkingSpotsToolStripMenuItem.Text = "Parking spots";
            parkingSpotsToolStripMenuItem.Click += parkingSpotsToolStripMenuItem_Click;
            // 
            // usersToolStripMenuItem
            // 
            usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            usersToolStripMenuItem.Size = new Size(179, 26);
            usersToolStripMenuItem.Text = "Users";
            usersToolStripMenuItem.Click += usersToolStripMenuItem_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.Right;
            toolStrip1.ImageScalingSize = new Size(25, 25);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripDropDownButton1 });
            toolStrip1.Location = new Point(1119, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(40, 424);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            toolStripDropDownButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripDropDownButton1.DropDownItems.AddRange(new ToolStripItem[] { profileToolStripMenuItem, viewReservationsToolStripMenuItem, changepasswordOutToolStripMenuItem, logOutToolStripMenuItem1 });
            toolStripDropDownButton1.Image = Properties.Resources.avatar_12124771;
            toolStripDropDownButton1.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            toolStripDropDownButton1.Size = new Size(37, 29);
            toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // profileToolStripMenuItem
            // 
            profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            profileToolStripMenuItem.Size = new Size(273, 32);
            profileToolStripMenuItem.Text = "Profile";
            profileToolStripMenuItem.Click += profileToolStripMenuItem_Click;
            // 
            // viewReservationsToolStripMenuItem
            // 
            viewReservationsToolStripMenuItem.Name = "viewReservationsToolStripMenuItem";
            viewReservationsToolStripMenuItem.Size = new Size(273, 32);
            viewReservationsToolStripMenuItem.Text = "View/Reserve Parking Spot";
            viewReservationsToolStripMenuItem.Click += viewReservationsToolStripMenuItem_Click;
            // 
            // changepasswordOutToolStripMenuItem
            // 
            changepasswordOutToolStripMenuItem.Name = "changepasswordOutToolStripMenuItem";
            changepasswordOutToolStripMenuItem.Size = new Size(273, 32);
            changepasswordOutToolStripMenuItem.Text = "Change password";
            changepasswordOutToolStripMenuItem.Click += LogOutToolStripMenuItem_Click;
            // 
            // logOutToolStripMenuItem1
            // 
            logOutToolStripMenuItem1.Image = Properties.Resources.power_on_4980965;
            logOutToolStripMenuItem1.Name = "logOutToolStripMenuItem1";
            logOutToolStripMenuItem1.Size = new Size(273, 32);
            logOutToolStripMenuItem1.Text = "Log out";
            logOutToolStripMenuItem1.Click += logOutToolStripMenuItem1_Click;
            // 
            // lblLogUser
            // 
            lblLogUser.AutoSize = true;
            lblLogUser.Location = new Point(819, 361);
            lblLogUser.Name = "lblLogUser";
            lblLogUser.Size = new Size(0, 20);
            lblLogUser.TabIndex = 3;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1159, 424);
            Controls.Add(lblLogUser);
            Controls.Add(toolStrip1);
            Controls.Add(msCatalog);
            MainMenuStrip = msCatalog;
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ParkWay";
            WindowState = FormWindowState.Maximized;
            msCatalog.ResumeLayout(false);
            msCatalog.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip msCatalog;
        private ToolStripMenuItem catalogToolStripMenuItem;
        private ToolStripMenuItem floorsToolStripMenuItem;
        private ToolStripMenuItem parkingSpotsToolStripMenuItem;
        private ToolStripMenuItem usersToolStripMenuItem;
        private ToolStrip toolStrip1;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem profileToolStripMenuItem;
        private ToolStripMenuItem viewReservationsToolStripMenuItem;
        private ToolStripMenuItem changepasswordOutToolStripMenuItem;
        private Label lblLogUser;
        private ToolStripMenuItem logOutToolStripMenuItem1;
    }
}