namespace ParkWay
{
    partial class ListofParkingSpots
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
            dgvListParkingSpots = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvListParkingSpots).BeginInit();
            SuspendLayout();
            // 
            // dgvListParkingSpots
            // 
            dgvListParkingSpots.AllowUserToAddRows = false;
            dgvListParkingSpots.AllowUserToDeleteRows = false;
            dgvListParkingSpots.AllowUserToResizeColumns = false;
            dgvListParkingSpots.AllowUserToResizeRows = false;
            dgvListParkingSpots.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvListParkingSpots.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvListParkingSpots.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListParkingSpots.Location = new Point(29, 30);
            dgvListParkingSpots.Name = "dgvListParkingSpots";
            dgvListParkingSpots.ReadOnly = true;
            dgvListParkingSpots.RowHeadersWidth = 51;
            dgvListParkingSpots.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvListParkingSpots.Size = new Size(742, 379);
            dgvListParkingSpots.TabIndex = 0;
            // 
            // ListofParkingSpots
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvListParkingSpots);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ListofParkingSpots";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ParkWay";
            TopMost = true;
            Load += ListofParkingSpots_Load;
            ((System.ComponentModel.ISupportInitialize)dgvListParkingSpots).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvListParkingSpots;
    }
}