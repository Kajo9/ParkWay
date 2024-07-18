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
            menuStrip1 = new MenuStrip();
            catalogToolStripMenuItem = new ToolStripMenuItem();
            floorsToolStripMenuItem = new ToolStripMenuItem();
            parkingSpotsToolStripMenuItem = new ToolStripMenuItem();
            usersToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            toolStripDropDownButton1 = new ToolStripDropDownButton();
            profileToolStripMenuItem = new ToolStripMenuItem();
            viewReservationsToolStripMenuItem = new ToolStripMenuItem();
            myReservationsToolStripMenuItem = new ToolStripMenuItem();
            logOutToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.GradientInactiveCaption;
            menuStrip1.Dock = DockStyle.Left;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { catalogToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(101, 424);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
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
            toolStripDropDownButton1.DropDownItems.AddRange(new ToolStripItem[] { profileToolStripMenuItem, viewReservationsToolStripMenuItem, myReservationsToolStripMenuItem, logOutToolStripMenuItem });
            toolStripDropDownButton1.Image = Properties.Resources.avatar_12124771;
            toolStripDropDownButton1.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            toolStripDropDownButton1.Size = new Size(37, 29);
            toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // profileToolStripMenuItem
            // 
            profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            profileToolStripMenuItem.Size = new Size(268, 26);
            profileToolStripMenuItem.Text = "Profile";
            profileToolStripMenuItem.Click += profileToolStripMenuItem_Click;
            // 
            // viewReservationsToolStripMenuItem
            // 
            viewReservationsToolStripMenuItem.Name = "viewReservationsToolStripMenuItem";
            viewReservationsToolStripMenuItem.Size = new Size(268, 26);
            viewReservationsToolStripMenuItem.Text = "View/Reserve Parking Spot";
            viewReservationsToolStripMenuItem.Click += viewReservationsToolStripMenuItem_Click;
            // 
            // myReservationsToolStripMenuItem
            // 
            myReservationsToolStripMenuItem.Name = "myReservationsToolStripMenuItem";
            myReservationsToolStripMenuItem.Size = new Size(268, 26);
            myReservationsToolStripMenuItem.Text = "My Reservations";
            // 
            // logOutToolStripMenuItem
            // 
            logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            logOutToolStripMenuItem.Size = new Size(268, 26);
            logOutToolStripMenuItem.Text = "Log out";
            logOutToolStripMenuItem.Click += logOutToolStripMenuItem_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1159, 424);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Main";
            Text = "ParkWay";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem catalogToolStripMenuItem;
        private ToolStripMenuItem floorsToolStripMenuItem;
        private ToolStripMenuItem parkingSpotsToolStripMenuItem;
        private ToolStripMenuItem usersToolStripMenuItem;
        private ToolStrip toolStrip1;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem profileToolStripMenuItem;
        private ToolStripMenuItem viewReservationsToolStripMenuItem;
        private ToolStripMenuItem myReservationsToolStripMenuItem;
        private ToolStripMenuItem logOutToolStripMenuItem;
    }
}