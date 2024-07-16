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
            msFloor = new MenuStrip();
            floorToolStripMenuItem = new ToolStripMenuItem();
            stFloorToolStripMenuItem = new ToolStripMenuItem();
            ndFloorToolStripMenuItem = new ToolStripMenuItem();
            rdFloorToolStripMenuItem = new ToolStripMenuItem();
            lblFloor = new Label();
            txtFloorName = new TextBox();
            dgvFloors = new DataGridView();
            txtFloorID = new TextBox();
            lblID = new Label();
            menuStrip1 = new MenuStrip();
            newToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem1 = new ToolStripMenuItem();
            btnListAllFloor = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvOverviewofParkingSpaces).BeginInit();
            msFloor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFloors).BeginInit();
            menuStrip1.SuspendLayout();
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
            lblFloor.Location = new Point(41, 76);
            lblFloor.Name = "lblFloor";
            lblFloor.Size = new Size(50, 20);
            lblFloor.TabIndex = 4;
            lblFloor.Text = "Floor: ";
            // 
            // txtFloorName
            // 
            txtFloorName.Location = new Point(141, 76);
            txtFloorName.Name = "txtFloorName";
            txtFloorName.Size = new Size(125, 27);
            txtFloorName.TabIndex = 1;
            // 
            // dgvFloors
            // 
            dgvFloors.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvFloors.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvFloors.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dgvFloors.BackgroundColor = SystemColors.ScrollBar;
            dgvFloors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFloors.Location = new Point(41, 123);
            dgvFloors.Name = "dgvFloors";
            dgvFloors.ReadOnly = true;
            dgvFloors.RowHeadersWidth = 51;
            dgvFloors.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFloors.Size = new Size(1289, 385);
            dgvFloors.TabIndex = 4;
            dgvFloors.SelectionChanged += dgvFloors_SelectionChanged;
            // 
            // txtFloorID
            // 
            txtFloorID.Location = new Point(141, 39);
            txtFloorID.Name = "txtFloorID";
            txtFloorID.ReadOnly = true;
            txtFloorID.Size = new Size(125, 27);
            txtFloorID.TabIndex = 6;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(41, 42);
            lblID.Name = "lblID";
            lblID.Size = new Size(27, 20);
            lblID.TabIndex = 7;
            lblID.Text = "ID:";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { newToolStripMenuItem, saveToolStripMenuItem, deleteToolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1350, 28);
            menuStrip1.TabIndex = 8;
            menuStrip1.Text = "menuStrip1";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new Size(53, 24);
            newToolStripMenuItem.Text = "New";
            newToolStripMenuItem.Click += newToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(54, 24);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem1
            // 
            deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            deleteToolStripMenuItem1.Size = new Size(67, 24);
            deleteToolStripMenuItem1.Text = "Delete";
            deleteToolStripMenuItem1.Click += deleteToolStripMenuItem1_Click;
            // 
            // btnListAllFloor
            // 
            btnListAllFloor.Location = new Point(1118, 76);
            btnListAllFloor.Name = "btnListAllFloor";
            btnListAllFloor.Size = new Size(212, 27);
            btnListAllFloor.TabIndex = 9;
            btnListAllFloor.Text = "Izlistaj sva parkirna mjesta";
            btnListAllFloor.UseVisualStyleBackColor = true;
            btnListAllFloor.Click += btnListAllFloor_Click;
            // 
            // Floor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1350, 534);
            Controls.Add(btnListAllFloor);
            Controls.Add(lblID);
            Controls.Add(txtFloorID);
            Controls.Add(dgvFloors);
            Controls.Add(txtFloorName);
            Controls.Add(lblFloor);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Floor";
            Text = "Floors";
            WindowState = FormWindowState.Maximized;
            Load += Floor_Load;
            ((System.ComponentModel.ISupportInitialize)dgvOverviewofParkingSpaces).EndInit();
            msFloor.ResumeLayout(false);
            msFloor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFloors).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvOverviewofParkingSpaces;
        private MenuStrip msFloor;
        private ToolStripMenuItem floorToolStripMenuItem;
        private ToolStripMenuItem stFloorToolStripMenuItem;
        private ToolStripMenuItem ndFloorToolStripMenuItem;
        private ToolStripMenuItem rdFloorToolStripMenuItem;
        private Label lblFloor;
        private TextBox txtFloorName;
        private DataGridView dgvFloors;
        private TextBox txtFloorID;
        private Label lblID;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem1;
        private Button btnListAllFloor;
    }
}