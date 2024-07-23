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
            lblFrom = new Label();
            lblTo = new Label();
            lblReference = new Label();
            txtFromTime = new TextBox();
            txtToTime = new TextBox();
            txtNotice = new TextBox();
            btnReserve = new Button();
            lblOptional = new Label();
            SuspendLayout();
            // 
            // lblFrom
            // 
            lblFrom.AutoSize = true;
            lblFrom.Location = new Point(134, 87);
            lblFrom.Name = "lblFrom";
            lblFrom.Size = new Size(46, 20);
            lblFrom.TabIndex = 0;
            lblFrom.Text = "From:";
            // 
            // lblTo
            // 
            lblTo.AutoSize = true;
            lblTo.Location = new Point(568, 87);
            lblTo.Name = "lblTo";
            lblTo.Size = new Size(28, 20);
            lblTo.TabIndex = 1;
            lblTo.Text = "To:";
            // 
            // lblReference
            // 
            lblReference.AutoSize = true;
            lblReference.Location = new Point(118, 279);
            lblReference.Name = "lblReference";
            lblReference.Size = new Size(62, 20);
            lblReference.TabIndex = 2;
            lblReference.Text = "Notice:*";
            // 
            // txtFromTime
            // 
            txtFromTime.Location = new Point(102, 141);
            txtFromTime.Name = "txtFromTime";
            txtFromTime.Size = new Size(145, 27);
            txtFromTime.TabIndex = 3;
            // 
            // txtToTime
            // 
            txtToTime.Location = new Point(503, 141);
            txtToTime.Name = "txtToTime";
            txtToTime.Size = new Size(145, 27);
            txtToTime.TabIndex = 4;
            // 
            // txtNotice
            // 
            txtNotice.Location = new Point(102, 335);
            txtNotice.Name = "txtNotice";
            txtNotice.Size = new Size(546, 27);
            txtNotice.TabIndex = 5;
            // 
            // btnReserve
            // 
            btnReserve.Location = new Point(326, 414);
            btnReserve.Name = "btnReserve";
            btnReserve.Size = new Size(94, 29);
            btnReserve.TabIndex = 6;
            btnReserve.Text = "Reserve";
            btnReserve.UseVisualStyleBackColor = true;
            btnReserve.Click += btnReserve_Click;
            // 
            // lblOptional
            // 
            lblOptional.AutoSize = true;
            lblOptional.BackColor = SystemColors.Control;
            lblOptional.ForeColor = SystemColors.ControlDarkDark;
            lblOptional.Location = new Point(531, 279);
            lblOptional.Name = "lblOptional";
            lblOptional.Size = new Size(117, 20);
            lblOptional.TabIndex = 7;
            lblOptional.Text = "Optional field(*)";
            // 
            // ReservePS
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(819, 492);
            Controls.Add(lblOptional);
            Controls.Add(btnReserve);
            Controls.Add(txtNotice);
            Controls.Add(txtToTime);
            Controls.Add(txtFromTime);
            Controls.Add(lblReference);
            Controls.Add(lblTo);
            Controls.Add(lblFrom);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ReservePS";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ParkWay";
            TopMost = true;
            Load += ReservePS_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFrom;
        private Label lblTo;
        private Label lblReference;
        private TextBox txtFromTime;
        private TextBox txtToTime;
        private TextBox txtNotice;
        private Button btnReserve;
        private Label lblOptional;
    }
}