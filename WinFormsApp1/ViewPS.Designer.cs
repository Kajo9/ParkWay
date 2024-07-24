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
            cbAvailablePS = new ComboBox();
            lblAvailablePS = new Label();
            lblNotice = new Label();
            txtNotice = new TextBox();
            btnClear = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvViewPS).BeginInit();
            SuspendLayout();
            // 
            // dgvViewPS
            // 
            dgvViewPS.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvViewPS.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvViewPS.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvViewPS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvViewPS.Location = new Point(23, 155);
            dgvViewPS.Name = "dgvViewPS";
            dgvViewPS.ReadOnly = true;
            dgvViewPS.RowHeadersWidth = 51;
            dgvViewPS.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvViewPS.Size = new Size(1079, 473);
            dgvViewPS.TabIndex = 0;
            dgvViewPS.CellContentClick += dgvViewPS_CellContentClick;
            dgvViewPS.CellFormatting += dgvViewPS_CellFormatting;
            dgvViewPS.DoubleClick += dgvViewPS_DoubleClick;
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
            // cbAvailablePS
            // 
            cbAvailablePS.FormattingEnabled = true;
            cbAvailablePS.Location = new Point(401, 30);
            cbAvailablePS.Name = "cbAvailablePS";
            cbAvailablePS.Size = new Size(151, 28);
            cbAvailablePS.TabIndex = 3;
            cbAvailablePS.SelectedIndexChanged += cbAvailablePS_SelectedIndexChanged;
            // 
            // lblAvailablePS
            // 
            lblAvailablePS.AutoSize = true;
            lblAvailablePS.Location = new Point(285, 33);
            lblAvailablePS.Name = "lblAvailablePS";
            lblAvailablePS.Size = new Size(74, 20);
            lblAvailablePS.TabIndex = 4;
            lblAvailablePS.Text = "Available:";
            // 
            // lblNotice
            // 
            lblNotice.AutoSize = true;
            lblNotice.Location = new Point(23, 91);
            lblNotice.Name = "lblNotice";
            lblNotice.Size = new Size(56, 20);
            lblNotice.TabIndex = 5;
            lblNotice.Text = "Notice:";
            // 
            // txtNotice
            // 
            txtNotice.Location = new Point(92, 88);
            txtNotice.Name = "txtNotice";
            txtNotice.Size = new Size(460, 27);
            txtNotice.TabIndex = 6;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(574, 88);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 7;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // ViewPS
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1131, 654);
            Controls.Add(btnClear);
            Controls.Add(txtNotice);
            Controls.Add(lblNotice);
            Controls.Add(lblAvailablePS);
            Controls.Add(cbAvailablePS);
            Controls.Add(cbFloor);
            Controls.Add(lblFloor);
            Controls.Add(dgvViewPS);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ViewPS";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ParkWay";
            WindowState = FormWindowState.Maximized;
            Load += ViewPS_Load;
            ((System.ComponentModel.ISupportInitialize)dgvViewPS).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvViewPS;
        private Label lblFloor;
        private ComboBox cbFloor;
        private ComboBox cbAvailablePS;
        private Label lblAvailablePS;
        private Label lblNotice;
        private TextBox txtNotice;
        private Button btnClear;
    }
}