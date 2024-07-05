namespace ParkWay
{
    partial class Floor
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
            dgvOverviewofParkingSpaces = new DataGridView();
            btnBack = new Button();
            msFloor = new MenuStrip();
            floorToolStripMenuItem = new ToolStripMenuItem();
            stFloorToolStripMenuItem = new ToolStripMenuItem();
            ndFloorToolStripMenuItem = new ToolStripMenuItem();
            rdFloorToolStripMenuItem = new ToolStripMenuItem();
            lblFloor = new Label();
            txtFloor = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvOverviewofParkingSpaces).BeginInit();
            msFloor.SuspendLayout();
            SuspendLayout();
            // 
            // dgvOverviewofParkingSpaces
            // 
            dgvOverviewofParkingSpaces.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOverviewofParkingSpaces.Location = new Point(35, 94);
            dgvOverviewofParkingSpaces.Name = "dgvOverviewofParkingSpaces";
            dgvOverviewofParkingSpaces.RowHeadersWidth = 51;
            dgvOverviewofParkingSpaces.Size = new Size(1357, 380);
            dgvOverviewofParkingSpaces.TabIndex = 0;
            //
            // btnBack
            // 
            btnBack.Location = new Point(35, 480);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 1;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // msFloor
            // 
            msFloor.ImageScalingSize = new Size(20, 20);
            msFloor.Items.AddRange(new ToolStripItem[] { floorToolStripMenuItem });
            msFloor.Location = new Point(0, 0);
            msFloor.Name = "msFloor";
            msFloor.Size = new Size(1437, 28);
            msFloor.TabIndex = 3;
            msFloor.Text = "msFloor";
            // 
            // floorToolStripMenuItem
            // 
            floorToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { stFloorToolStripMenuItem, ndFloorToolStripMenuItem, rdFloorToolStripMenuItem });
            floorToolStripMenuItem.Name = "floorToolStripMenuItem";
            floorToolStripMenuItem.Size = new Size(57, 24);
            floorToolStripMenuItem.Text = "Floor";
            // 
            // stFloorToolStripMenuItem
            // 
            stFloorToolStripMenuItem.Name = "stFloorToolStripMenuItem";
            stFloorToolStripMenuItem.Size = new Size(155, 26);
            stFloorToolStripMenuItem.Text = "1st Floor";
            // 
            // ndFloorToolStripMenuItem
            // 
            ndFloorToolStripMenuItem.Name = "ndFloorToolStripMenuItem";
            ndFloorToolStripMenuItem.Size = new Size(155, 26);
            ndFloorToolStripMenuItem.Text = "2nd Floor";
            // 
            // rdFloorToolStripMenuItem
            // 
            rdFloorToolStripMenuItem.Name = "rdFloorToolStripMenuItem";
            rdFloorToolStripMenuItem.Size = new Size(155, 26);
            rdFloorToolStripMenuItem.Text = "3rd Floor";
            // 
            // lblFloor
            // 
            lblFloor.AutoSize = true;
            lblFloor.Location = new Point(37, 44);
            lblFloor.Name = "lblFloor";
            lblFloor.Size = new Size(50, 20);
            lblFloor.TabIndex = 4;
            lblFloor.Text = "Floor: ";
            // 
            // txtFloor
            // 
            txtFloor.Location = new Point(93, 44);
            txtFloor.Name = "txtFloor";
            txtFloor.Size = new Size(125, 27);
            txtFloor.TabIndex = 5;
            // 
            // Floor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1437, 521);
            Controls.Add(txtFloor);
            Controls.Add(lblFloor);
            Controls.Add(btnBack);
            Controls.Add(dgvOverviewofParkingSpaces);
            Controls.Add(msFloor);
            MainMenuStrip = msFloor;
            Name = "Floor";
            Text = "OverviewofParkingSpaces";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dgvOverviewofParkingSpaces).EndInit();
            msFloor.ResumeLayout(false);
            msFloor.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvOverviewofParkingSpaces;
        private Button btnBack;
        private MenuStrip msFloor;
        private ToolStripMenuItem floorToolStripMenuItem;
        private ToolStripMenuItem stFloorToolStripMenuItem;
        private ToolStripMenuItem ndFloorToolStripMenuItem;
        private ToolStripMenuItem rdFloorToolStripMenuItem;
        private Label lblFloor;
        private TextBox txtFloor;
    }
}