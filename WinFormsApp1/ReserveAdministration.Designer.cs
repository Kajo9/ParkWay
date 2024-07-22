namespace ParkWay
{
    partial class ReserveAdministration
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
            newToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            label2 = new Label();
            lblFirstName = new Label();
            lblLastName = new Label();
            txtPosition = new TextBox();
            txtParkingSpot = new TextBox();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            dgvReserveAdministration = new DataGridView();
            lblReservationDate = new Label();
            txtReservationDate = new TextBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReserveAdministration).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { newToolStripMenuItem, saveToolStripMenuItem, deleteToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1214, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Image = Properties.Resources.paper_24935_640;
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new Size(73, 24);
            newToolStripMenuItem.Text = "New";
            newToolStripMenuItem.Click += newToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Image = Properties.Resources.floppy_disk_98413_640;
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(74, 24);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Image = Properties.Resources.delete_4980658;
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(87, 24);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 86);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 1;
            label1.Text = "Position:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 157);
            label2.Name = "label2";
            label2.Size = new Size(93, 20);
            label2.TabIndex = 2;
            label2.Text = "Parking spot:";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(30, 223);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(80, 20);
            lblFirstName.TabIndex = 3;
            lblFirstName.Text = "First name:";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(30, 291);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(79, 20);
            lblLastName.TabIndex = 4;
            lblLastName.Text = "Last name:";
            // 
            // txtPosition
            // 
            txtPosition.Location = new Point(195, 79);
            txtPosition.Name = "txtPosition";
            txtPosition.ReadOnly = true;
            txtPosition.Size = new Size(47, 27);
            txtPosition.TabIndex = 5;
            // 
            // txtParkingSpot
            // 
            txtParkingSpot.Location = new Point(195, 154);
            txtParkingSpot.Name = "txtParkingSpot";
            txtParkingSpot.Size = new Size(175, 27);
            txtParkingSpot.TabIndex = 6;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(195, 223);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(172, 27);
            txtFirstName.TabIndex = 7;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(195, 291);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(172, 27);
            txtLastName.TabIndex = 8;
            // 
            // dgvReserveAdministration
            // 
            dgvReserveAdministration.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvReserveAdministration.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReserveAdministration.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvReserveAdministration.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReserveAdministration.Location = new Point(524, 79);
            dgvReserveAdministration.Name = "dgvReserveAdministration";
            dgvReserveAdministration.ReadOnly = true;
            dgvReserveAdministration.RowHeadersWidth = 51;
            dgvReserveAdministration.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReserveAdministration.Size = new Size(650, 407);
            dgvReserveAdministration.TabIndex = 9;
            // 
            // lblReservationDate
            // 
            lblReservationDate.AutoSize = true;
            lblReservationDate.Location = new Point(30, 363);
            lblReservationDate.Name = "lblReservationDate";
            lblReservationDate.Size = new Size(123, 20);
            lblReservationDate.TabIndex = 10;
            lblReservationDate.Text = "Reservation date:";
            // 
            // txtReservationDate
            // 
            txtReservationDate.Location = new Point(195, 360);
            txtReservationDate.Name = "txtReservationDate";
            txtReservationDate.Size = new Size(172, 27);
            txtReservationDate.TabIndex = 11;
            // 
            // ReserveAdministration
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1214, 544);
            Controls.Add(txtReservationDate);
            Controls.Add(lblReservationDate);
            Controls.Add(dgvReserveAdministration);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(txtParkingSpot);
            Controls.Add(txtPosition);
            Controls.Add(lblLastName);
            Controls.Add(lblFirstName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "ReserveAdministration";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ReserveAdministration";
            WindowState = FormWindowState.Maximized;
            Load += ReserveAdministration_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReserveAdministration).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private Label label1;
        private Label label2;
        private Label lblFirstName;
        private Label lblLastName;
        private TextBox txtPosition;
        private TextBox txtParkingSpot;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private DataGridView dgvReserveAdministration;
        private Label lblReservationDate;
        private TextBox txtReservationDate;
    }
}