namespace TouristManagement
{
    partial class DashboardPage
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            BtnGenerateReport = new Button();
            BtnLogOut = new Button();
            BtnMakeAnotherreservation = new Button();
            LstViewBookings = new ListView();
            LstViewPayments = new ListView();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 14F);
            label1.Location = new Point(496, 41);
            label1.Name = "label1";
            label1.Size = new Size(157, 30);
            label1.TabIndex = 1;
            label1.Text = "Dashboard";
            label1.TextAlign = ContentAlignment.TopRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Javanese Text", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(72, 70);
            label2.Name = "label2";
            label2.Size = new Size(128, 41);
            label2.TabIndex = 2;
            label2.Text = "Your bookings";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Javanese Text", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(72, 257);
            label3.Name = "label3";
            label3.Size = new Size(211, 41);
            label3.TabIndex = 3;
            label3.Text = "Overall Payment History";
            // 
            // BtnGenerateReport
            // 
            BtnGenerateReport.BackColor = Color.SkyBlue;
            BtnGenerateReport.Location = new Point(328, 432);
            BtnGenerateReport.Name = "BtnGenerateReport";
            BtnGenerateReport.Size = new Size(238, 29);
            BtnGenerateReport.TabIndex = 5;
            BtnGenerateReport.Text = "Generate Report";
            BtnGenerateReport.UseVisualStyleBackColor = false;
            BtnGenerateReport.Click += BtnGenerateReport_Click;
            // 
            // BtnLogOut
            // 
            BtnLogOut.BackColor = Color.SkyBlue;
            BtnLogOut.Location = new Point(595, 432);
            BtnLogOut.Name = "BtnLogOut";
            BtnLogOut.Size = new Size(94, 29);
            BtnLogOut.TabIndex = 6;
            BtnLogOut.Text = "Log out";
            BtnLogOut.UseVisualStyleBackColor = false;
            BtnLogOut.Click += BtnLogOut_Click;
            // 
            // BtnMakeAnotherreservation
            // 
            BtnMakeAnotherreservation.BackColor = Color.SkyBlue;
            BtnMakeAnotherreservation.Location = new Point(90, 432);
            BtnMakeAnotherreservation.Name = "BtnMakeAnotherreservation";
            BtnMakeAnotherreservation.Size = new Size(218, 29);
            BtnMakeAnotherreservation.TabIndex = 7;
            BtnMakeAnotherreservation.Text = "Make another reservation";
            BtnMakeAnotherreservation.UseVisualStyleBackColor = false;
            BtnMakeAnotherreservation.Click += BtnMakeAnotherreservation_Click;
            // 
            // LstViewBookings
            // 
            LstViewBookings.Location = new Point(72, 114);
            LstViewBookings.Name = "LstViewBookings";
            LstViewBookings.Size = new Size(1033, 136);
            LstViewBookings.TabIndex = 8;
            LstViewBookings.UseCompatibleStateImageBehavior = false;
            LstViewBookings.SelectedIndexChanged += LstViewBookings_SelectedIndexChanged;
            // 
            // LstViewPayments
            // 
            LstViewPayments.Location = new Point(72, 293);
            LstViewPayments.Name = "LstViewPayments";
            LstViewPayments.Size = new Size(1033, 121);
            LstViewPayments.TabIndex = 9;
            LstViewPayments.UseCompatibleStateImageBehavior = false;
            // 
            // DashboardPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1180, 514);
            Controls.Add(LstViewPayments);
            Controls.Add(LstViewBookings);
            Controls.Add(BtnMakeAnotherreservation);
            Controls.Add(BtnLogOut);
            Controls.Add(BtnGenerateReport);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "DashboardPage";
            Text = "DashboardPage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private Button BtnGenerateReport;
        private Button BtnLogOut;
        private Button BtnMakeAnotherreservation;
        private ListView LstViewBookings;
        private ListView LstViewPayments;
    }
}