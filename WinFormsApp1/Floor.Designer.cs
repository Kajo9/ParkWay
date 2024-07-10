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
            editToolStripMenuItem = new ToolStripMenuItem();
            addToolStripMenuItem = new ToolStripMenuItem();
            updateToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
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
            menuStrip1.Items.AddRange(new ToolStripItem[] { editToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1350, 28);
            menuStrip1.TabIndex = 8;
            menuStrip1.Text = "menuStrip1";
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addToolStripMenuItem, updateToolStripMenuItem, deleteToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(49, 24);
            editToolStripMenuItem.Text = "Edit";
            // 
            // addToolStripMenuItem
            // 
            addToolStripMenuItem.Name = "addToolStripMenuItem";
            addToolStripMenuItem.Size = new Size(141, 26);
            addToolStripMenuItem.Text = "Add";
            addToolStripMenuItem.Click += addToolStripMenuItem_Click;
            // 
            // updateToolStripMenuItem
            // 
            updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            updateToolStripMenuItem.Size = new Size(141, 26);
            updateToolStripMenuItem.Text = "Update";
            updateToolStripMenuItem.Click += updateToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(141, 26);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // Floor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1350, 534);
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
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem addToolStripMenuItem;
        private ToolStripMenuItem updateToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
    }
}