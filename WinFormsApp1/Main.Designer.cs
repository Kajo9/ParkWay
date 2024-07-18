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
            changePasswordToolStripMenuItem = new ToolStripMenuItem();
            btnBack = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { catalogToolStripMenuItem, changePasswordToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1159, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // catalogToolStripMenuItem
            // 
            catalogToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { floorsToolStripMenuItem, parkingSpotsToolStripMenuItem, usersToolStripMenuItem });
            catalogToolStripMenuItem.Name = "catalogToolStripMenuItem";
            catalogToolStripMenuItem.Size = new Size(75, 24);
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
            // changePasswordToolStripMenuItem
            // 
            changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            changePasswordToolStripMenuItem.Size = new Size(140, 24);
            changePasswordToolStripMenuItem.Text = "Change password";
            // 
            // btnBack
            // 
            btnBack.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnBack.Location = new Point(1028, 368);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 2;
            btnBack.Text = "Log off";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1159, 424);
            Controls.Add(btnBack);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Main";
            Text = "ParkWay";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem catalogToolStripMenuItem;
        private ToolStripMenuItem floorsToolStripMenuItem;
        private ToolStripMenuItem parkingSpotsToolStripMenuItem;
        private Button btnBack;
        private ToolStripMenuItem usersToolStripMenuItem;
        private ToolStripMenuItem changePasswordToolStripMenuItem;
    }
}