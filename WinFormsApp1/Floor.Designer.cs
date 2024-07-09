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
            btnBack = new Button();
            lblFloor = new Label();
            txtFloor = new TextBox();
            dgvFloors = new DataGridView();
            btnSave = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvFloors).BeginInit();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Location = new Point(37, 487);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 5;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // lblFloor
            // 
            lblFloor.AutoSize = true;
            lblFloor.Location = new Point(37, 44);
            lblFloor.Name = "lblFloor";
            lblFloor.Size = new Size(50, 20);
            lblFloor.TabIndex = 4;
            lblFloor.Text = "Floor: ";
            // 
            // txtFloor
            // 
            txtFloor.Location = new Point(93, 44);
            txtFloor.Name = "txtFloor";
            txtFloor.Size = new Size(125, 27);
            txtFloor.TabIndex = 1;
            // 
            // dgvFloors
            // 
            dgvFloors.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvFloors.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvFloors.BackgroundColor = SystemColors.ScrollBar;
            dgvFloors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFloors.Location = new Point(37, 128);
            dgvFloors.Name = "dgvFloors";
            dgvFloors.RowHeadersWidth = 51;
            dgvFloors.Size = new Size(1230, 324);
            dgvFloors.TabIndex = 4;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(260, 43);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 2;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(411, 44);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // Floor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1350, 534);
            Controls.Add(btnDelete);
            Controls.Add(btnSave);
            Controls.Add(dgvFloors);
            Controls.Add(txtFloor);
            Controls.Add(lblFloor);
            Controls.Add(btnBack);
            Name = "Floor";
            Text = "Floors";
            WindowState = FormWindowState.Maximized;
            Load += Floor_Load;
            ((System.ComponentModel.ISupportInitialize)dgvFloors).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnBack;
        private Label lblFloor;
        private TextBox txtFloor;
        private DataGridView dgvFloors;
        private Button btnSave;
        private Button btnDelete;
    }
}