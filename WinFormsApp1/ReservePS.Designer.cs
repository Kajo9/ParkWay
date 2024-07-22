namespace ParkWay
{
    partial class ReservePS
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
            dgvReservePS = new DataGridView();
            cbFloor = new ComboBox();
            lblFloor = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvReservePS).BeginInit();
            SuspendLayout();
            // 
            // dgvReservePS
            // 
            dgvReservePS.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvReservePS.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReservePS.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvReservePS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReservePS.Location = new Point(29, 82);
            dgvReservePS.Name = "dgvReservePS";
            dgvReservePS.ReadOnly = true;
            dgvReservePS.RowHeadersWidth = 51;
            dgvReservePS.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReservePS.Size = new Size(797, 384);
            dgvReservePS.TabIndex = 0;
            dgvReservePS.CellContentClick += dgvReservePS_CellContentClick;
            // 
            // cbFloor
            // 
            cbFloor.FormattingEnabled = true;
            cbFloor.Location = new Point(105, 33);
            cbFloor.Name = "cbFloor";
            cbFloor.Size = new Size(151, 28);
            cbFloor.TabIndex = 1;
            // 
            // lblFloor
            // 
            lblFloor.AutoSize = true;
            lblFloor.Location = new Point(29, 36);
            lblFloor.Name = "lblFloor";
            lblFloor.Size = new Size(46, 20);
            lblFloor.TabIndex = 2;
            lblFloor.Text = "Floor:";
            // 
            // ReservePS
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(852, 499);
            Controls.Add(lblFloor);
            Controls.Add(cbFloor);
            Controls.Add(dgvReservePS);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ReservePS";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ParkWay";
            WindowState = FormWindowState.Maximized;
            Load += ReservePS_Load;
            ((System.ComponentModel.ISupportInitialize)dgvReservePS).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvReservePS;
        private ComboBox cbFloor;
        private Label lblFloor;
    }
}