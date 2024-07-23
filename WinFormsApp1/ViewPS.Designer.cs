namespace ParkWay
{
    partial class ViewPS
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
            dgvViewPS = new DataGridView();
            lblFloor = new Label();
            cbFloor = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvViewPS).BeginInit();
            SuspendLayout();
            // 
            // dgvViewPS
            // 
            dgvViewPS.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvViewPS.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvViewPS.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvViewPS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvViewPS.Location = new Point(23, 71);
            dgvViewPS.Name = "dgvViewPS";
            dgvViewPS.ReadOnly = true;
            dgvViewPS.RowHeadersWidth = 51;
            dgvViewPS.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvViewPS.Size = new Size(900, 380);
            dgvViewPS.TabIndex = 0;
            dgvViewPS.CellContentClick += dgvViewPS_CellContentClick;
            // 
            // lblFloor
            // 
            lblFloor.AutoSize = true;
            lblFloor.Location = new Point(23, 30);
            lblFloor.Name = "lblFloor";
            lblFloor.Size = new Size(46, 20);
            lblFloor.TabIndex = 1;
            lblFloor.Text = "Floor:";
            // 
            // cbFloor
            // 
            cbFloor.FormattingEnabled = true;
            cbFloor.Location = new Point(92, 30);
            cbFloor.Name = "cbFloor";
            cbFloor.Size = new Size(151, 28);
            cbFloor.TabIndex = 2;
            cbFloor.SelectedIndexChanged += cbFloor_SelectedIndexChanged;
            // 
            // ViewPS
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(952, 481);
            Controls.Add(cbFloor);
            Controls.Add(lblFloor);
            Controls.Add(dgvViewPS);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ViewPS";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ParkWay";
            WindowState = FormWindowState.Maximized;
            Load += ReservePS_Load;
            ((System.ComponentModel.ISupportInitialize)dgvViewPS).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvViewPS;
        private Label lblFloor;
        private ComboBox cbFloor;
    }
}