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
            btnBack = new Button();
            dgvParkingspot = new DataGridView();
            lblParkingspot = new Label();
            txtParkingspot = new TextBox();
            btnSave = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvParkingspot).BeginInit();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Location = new Point(41, 400);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 3;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // dgvParkingspot
            // 
            dgvParkingspot.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvParkingspot.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvParkingspot.BackgroundColor = SystemColors.ScrollBar;
            dgvParkingspot.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvParkingspot.Location = new Point(41, 86);
            dgvParkingspot.Name = "dgvParkingspot";
            dgvParkingspot.RowHeadersWidth = 51;
            dgvParkingspot.Size = new Size(1006, 294);
            dgvParkingspot.TabIndex = 4;
            // 
            // lblParkingspot
            // 
            lblParkingspot.AutoSize = true;
            lblParkingspot.Location = new Point(41, 32);
            lblParkingspot.Name = "lblParkingspot";
            lblParkingspot.Size = new Size(97, 20);
            lblParkingspot.TabIndex = 2;
            lblParkingspot.Text = "Parking spot: ";
            // 
            // txtParkingspot
            // 
            txtParkingspot.Location = new Point(144, 32);
            txtParkingspot.Name = "txtParkingspot";
            txtParkingspot.Size = new Size(125, 27);
            txtParkingspot.TabIndex = 0;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(312, 32);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 1;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(451, 32);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // ParkingSpot
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1102, 450);
            Controls.Add(btnDelete);
            Controls.Add(btnSave);
            Controls.Add(txtParkingspot);
            Controls.Add(lblParkingspot);
            Controls.Add(dgvParkingspot);
            Controls.Add(btnBack);
            Name = "ParkingSpot";
            Text = "ParkingSpot";
            WindowState = FormWindowState.Maximized;
            Load += ParkingSpace_Load;
            ((System.ComponentModel.ISupportInitialize)dgvParkingspot).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBack;
        private DataGridView dgvParkingspot;
        private Label lblParkingspot;
        private TextBox txtParkingspot;
        private Button btnSave;
        private Button btnDelete;
    }
}