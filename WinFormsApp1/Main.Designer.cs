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
            btnCancel = new Button();
            menuStrip1 = new MenuStrip();
            catalogToolStripMenuItem = new ToolStripMenuItem();
            floorsToolStripMenuItem = new ToolStripMenuItem();
            parkingSpacesToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(1091, 415);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 0;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btn_Cancel_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { catalogToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1226, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // catalogToolStripMenuItem
            // 
            catalogToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { floorsToolStripMenuItem, parkingSpacesToolStripMenuItem });
            catalogToolStripMenuItem.Name = "catalogToolStripMenuItem";
            catalogToolStripMenuItem.Size = new Size(75, 24);
            catalogToolStripMenuItem.Text = "Catalog";
            // 
            // floorsToolStripMenuItem
            // 
            floorsToolStripMenuItem.Name = "floorsToolStripMenuItem";
            floorsToolStripMenuItem.Size = new Size(188, 26);
            floorsToolStripMenuItem.Text = "Floors";
            floorsToolStripMenuItem.Click += floorsToolStripMenuItem_Click;
            // 
            // parkingSpacesToolStripMenuItem
            // 
            parkingSpacesToolStripMenuItem.Name = "parkingSpacesToolStripMenuItem";
            parkingSpacesToolStripMenuItem.Size = new Size(188, 26);
            parkingSpacesToolStripMenuItem.Text = "Parking spaces";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1226, 471);
            Controls.Add(btnCancel);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Main";
            Text = "Main";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancel;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem catalogToolStripMenuItem;
        private ToolStripMenuItem floorsToolStripMenuItem;
        private ToolStripMenuItem parkingSpacesToolStripMenuItem;
    }
}