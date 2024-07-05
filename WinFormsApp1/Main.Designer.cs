namespace ParkWay
{
    partial class Main
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
            btnCancel = new Button();
            btnOverviewofParkingSpaces = new Button();
            btnAcountOverview = new Button();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(505, 219);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 0;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btn_Cancel_Click;
            // 
            // btnOverviewofParkingSpaces
            // 
            btnOverviewofParkingSpaces.Location = new Point(32, 75);
            btnOverviewofParkingSpaces.Name = "btnOverviewofParkingSpaces";
            btnOverviewofParkingSpaces.Size = new Size(248, 29);
            btnOverviewofParkingSpaces.TabIndex = 1;
            btnOverviewofParkingSpaces.Text = "Overview of parking spaces";
            btnOverviewofParkingSpaces.UseVisualStyleBackColor = true;
            btnOverviewofParkingSpaces.Click += btnOverviewofParkingSpaces_Click;
            // 
            // btnAcountOverview
            // 
            btnAcountOverview.Location = new Point(351, 75);
            btnAcountOverview.Name = "btnAcountOverview";
            btnAcountOverview.Size = new Size(248, 29);
            btnAcountOverview.TabIndex = 3;
            btnAcountOverview.Text = "Account overview";
            btnAcountOverview.UseVisualStyleBackColor = true;
            btnAcountOverview.Click += btnAcountOverview_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(634, 299);
            Controls.Add(btnAcountOverview);
            Controls.Add(btnOverviewofParkingSpaces);
            Controls.Add(btnCancel);
            Name = "Main";
            Text = "Main";
            ResumeLayout(false);
        }

        #endregion

        private Button btnCancel;
        private Button btnOverviewofParkingSpaces;
        private Button btnAcountOverview;
    }
}