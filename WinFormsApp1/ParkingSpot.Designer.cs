namespace ParkWay
{
    partial class ParkingSpot
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
            dgvParkingspot = new DataGridView();
            lblParkingspot = new Label();
            txtParkingSpot = new TextBox();
            lblID = new Label();
            txtParkingSpotID = new TextBox();
            menuStrip1 = new MenuStrip();
            newToolStripMenuItem1 = new ToolStripMenuItem();
            saveToolStripMenuItem1 = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem1 = new ToolStripMenuItem();
            cbFloor = new ComboBox();
            lblFloor = new Label();
            lblAvailable = new Label();
            chbAvailable = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dgvParkingspot).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvParkingspot
            // 
            dgvParkingspot.AllowUserToResizeColumns = false;
            dgvParkingspot.AllowUserToResizeRows = false;
            dgvParkingspot.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvParkingspot.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvParkingspot.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvParkingspot.BackgroundColor = SystemColors.ScrollBar;
            dgvParkingspot.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvParkingspot.Location = new Point(41, 123);
            dgvParkingspot.Name = "dgvParkingspot";
            dgvParkingspot.ReadOnly = true;
            dgvParkingspot.RowHeadersWidth = 51;
            dgvParkingspot.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvParkingspot.Size = new Size(1289, 383);
            dgvParkingspot.TabIndex = 4;
            dgvParkingspot.SelectionChanged += dgvParkingspot_SelectionChanged;
            // 
            // lblParkingspot
            // 
            lblParkingspot.AutoSize = true;
            lblParkingspot.Location = new Point(41, 76);
            lblParkingspot.Name = "lblParkingspot";
            lblParkingspot.Size = new Size(97, 20);
            lblParkingspot.TabIndex = 2;
            lblParkingspot.Text = "Parking spot: ";
            // 
            // txtParkingSpot
            // 
            txtParkingSpot.Location = new Point(141, 73);
            txtParkingSpot.Name = "txtParkingSpot";
            txtParkingSpot.Size = new Size(125, 27);
            txtParkingSpot.TabIndex = 0;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(41, 42);
            lblID.Name = "lblID";
            lblID.Size = new Size(27, 20);
            lblID.TabIndex = 5;
            lblID.Text = "ID:";
            // 
            // txtParkingSpotID
            // 
            txtParkingSpotID.Location = new Point(141, 35);
            txtParkingSpotID.Name = "txtParkingSpotID";
            txtParkingSpotID.ReadOnly = true;
            txtParkingSpotID.Size = new Size(125, 27);
            txtParkingSpotID.TabIndex = 6;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { newToolStripMenuItem1, saveToolStripMenuItem1, deleteToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1353, 28);
            menuStrip1.TabIndex = 10;
            // 
            // newToolStripMenuItem1
            // 
            newToolStripMenuItem1.Name = "newToolStripMenuItem1";
            newToolStripMenuItem1.Size = new Size(53, 24);
            newToolStripMenuItem1.Text = "New";
            newToolStripMenuItem1.Click += newToolStripMenuItem1_Click;
            // 
            // saveToolStripMenuItem1
            // 
            saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
            saveToolStripMenuItem1.Size = new Size(54, 24);
            saveToolStripMenuItem1.Text = "Save";
            saveToolStripMenuItem1.Click += saveToolStripMenuItem1_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(67, 24);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(49, 24);
            editToolStripMenuItem.Text = "Edit";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new Size(32, 19);
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(32, 19);
            // 
            // deleteToolStripMenuItem1
            // 
            deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            deleteToolStripMenuItem1.Size = new Size(32, 19);
            // 
            // cbFloor
            // 
            cbFloor.Location = new Point(376, 39);
            cbFloor.Name = "cbFloor";
            cbFloor.Size = new Size(121, 28);
            cbFloor.TabIndex = 10;
            cbFloor.SelectedIndexChanged += cbFloor_SelectedIndexChanged;
            // 
            // lblFloor
            // 
            lblFloor.AutoSize = true;
            lblFloor.Location = new Point(308, 38);
            lblFloor.Name = "lblFloor";
            lblFloor.Size = new Size(46, 20);
            lblFloor.TabIndex = 9;
            lblFloor.Text = "Floor:";
            // 
            // lblAvailable
            // 
            lblAvailable.AutoSize = true;
            lblAvailable.Location = new Point(308, 76);
            lblAvailable.Name = "lblAvailable";
            lblAvailable.Size = new Size(74, 20);
            lblAvailable.TabIndex = 12;
            lblAvailable.Text = "Available:";
            // 
            // chbAvailable
            // 
            chbAvailable.AutoSize = true;
            chbAvailable.Location = new Point(388, 76);
            chbAvailable.Name = "chbAvailable";
            chbAvailable.Size = new Size(18, 17);
            chbAvailable.TabIndex = 14;
            chbAvailable.UseVisualStyleBackColor = true;
            chbAvailable.CheckedChanged += chbAvailable_CheckedChanged;
            // 
            // ParkingSpot
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1353, 562);
            Controls.Add(chbAvailable);
            Controls.Add(lblAvailable);
            Controls.Add(lblFloor);
            Controls.Add(cbFloor);
            Controls.Add(txtParkingSpotID);
            Controls.Add(lblID);
            Controls.Add(txtParkingSpot);
            Controls.Add(lblParkingspot);
            Controls.Add(dgvParkingspot);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "ParkingSpot";
            Text = "ParkingSpot";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dgvParkingspot).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgvParkingspot;
        private Label lblParkingspot;
        private TextBox txtParkingSpot;
        private Label lblID;
        private TextBox txtParkingSpotID;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem1;
        private ComboBox cbFloor;
        private Label lblFloor;
        private ToolStripMenuItem newToolStripMenuItem1;
        private ToolStripMenuItem saveToolStripMenuItem1;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private Label lblAvailable;
        private CheckBox chbAvailable;
    }
}