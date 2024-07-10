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
            label1 = new Label();
            txtParkingSpotID = new TextBox();
            menuStrip1 = new MenuStrip();
            editToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem1 = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dgvParkingspot).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvParkingspot
            // 
            dgvParkingspot.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvParkingspot.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvParkingspot.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvParkingspot.BackgroundColor = SystemColors.ScrollBar;
            dgvParkingspot.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvParkingspot.Location = new Point(41, 123);
            dgvParkingspot.Name = "dgvParkingspot";
            dgvParkingspot.RowHeadersWidth = 51;
            dgvParkingspot.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvParkingspot.Size = new Size(1289, 385);
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 42);
            label1.Name = "label1";
            label1.Size = new Size(27, 20);
            label1.TabIndex = 5;
            label1.Text = "ID:";
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
            menuStrip1.Items.AddRange(new ToolStripItem[] { editToolStripMenuItem, newToolStripMenuItem, saveToolStripMenuItem, deleteToolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1353, 28);
            menuStrip1.TabIndex = 7;
            menuStrip1.Text = "menuStrip1";
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
            // ParkingSpot
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1353, 564);
            Controls.Add(txtParkingSpotID);
            Controls.Add(label1);
            Controls.Add(txtParkingSpot);
            Controls.Add(lblParkingspot);
            Controls.Add(dgvParkingspot);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "ParkingSpot";
            Text = "ParkingSpot";
            WindowState = FormWindowState.Maximized;
            Load += ParkingSpace_Load;
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
        private Label label1;
        private TextBox txtParkingSpotID;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem1;
    }
}