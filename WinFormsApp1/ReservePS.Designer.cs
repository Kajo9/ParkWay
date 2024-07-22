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
            lblFloor = new Label();
            cbFloor = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvReservePS).BeginInit();
            SuspendLayout();
            // 
            // dgvReservePS
            // 
            dgvReservePS.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvReservePS.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReservePS.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvReservePS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReservePS.Location = new Point(23, 71);
            dgvReservePS.Name = "dgvReservePS";
            dgvReservePS.ReadOnly = true;
            dgvReservePS.RowHeadersWidth = 51;
            dgvReservePS.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReservePS.Size = new Size(900, 380);
            dgvReservePS.TabIndex = 0;
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
            // 
            // ReservePS
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(952, 481);
            Controls.Add(cbFloor);
            Controls.Add(lblFloor);
            Controls.Add(dgvReservePS);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ReservePS";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ReservePS";
            WindowState = FormWindowState.Maximized;
            Load += ReservePS_Load;
            ((System.ComponentModel.ISupportInitialize)dgvReservePS).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvReservePS;
        private Label lblFloor;
        private ComboBox cbFloor;
    }
}