namespace TouristManagement
{
    partial class Reservationpage
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
            btnReserveASite = new Button();
            btnCancelreservation = new Button();
            btnManagereservations = new Button();
            BtnDashboard = new Button();
            SuspendLayout();
            // 
            // btnReserveASite
            // 
            btnReserveASite.BackColor = Color.SkyBlue;
            btnReserveASite.Location = new Point(243, 120);
            btnReserveASite.Name = "btnReserveASite";
            btnReserveASite.Size = new Size(212, 29);
            btnReserveASite.TabIndex = 0;
            btnReserveASite.Text = "Reserve a site";
            btnReserveASite.UseVisualStyleBackColor = false;
            btnReserveASite.Click += btnReserveASite_Click;
            // 
            // btnCancelreservation
            // 
            btnCancelreservation.BackColor = Color.SkyBlue;
            btnCancelreservation.Location = new Point(250, 187);
            btnCancelreservation.Name = "btnCancelreservation";
            btnCancelreservation.RightToLeft = RightToLeft.No;
            btnCancelreservation.Size = new Size(205, 29);
            btnCancelreservation.TabIndex = 1;
            btnCancelreservation.Text = "Cancel reservation";
            btnCancelreservation.UseVisualStyleBackColor = false;
            btnCancelreservation.Click += btnCancelreservation_Click;
            // 
            // btnManagereservations
            // 
            btnManagereservations.BackColor = Color.SkyBlue;
            btnManagereservations.Location = new Point(250, 264);
            btnManagereservations.Name = "btnManagereservations";
            btnManagereservations.Size = new Size(205, 29);
            btnManagereservations.TabIndex = 2;
            btnManagereservations.Text = "Manage reservation";
            btnManagereservations.UseVisualStyleBackColor = false;
            btnManagereservations.Click += btnManagereservations_Click;
            // 
            // BtnDashboard
            // 
            BtnDashboard.BackColor = Color.SkyBlue;
            BtnDashboard.Location = new Point(250, 335);
            BtnDashboard.Name = "BtnDashboard";
            BtnDashboard.Size = new Size(205, 29);
            BtnDashboard.TabIndex = 3;
            BtnDashboard.Text = "Dashboard";
            BtnDashboard.UseVisualStyleBackColor = false;
            BtnDashboard.Click += BtnDashboard_Click;
            // 
            // Reservationpage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(770, 450);
            Controls.Add(BtnDashboard);
            Controls.Add(btnManagereservations);
            Controls.Add(btnCancelreservation);
            Controls.Add(btnReserveASite);
            MaximizeBox = false;
            Name = "Reservationpage";
            Text = "Reservationpage";
            ResumeLayout(false);
        }

        #endregion

        private Button btnReserveASite;
        private Button btnCancelreservation;
        private Button btnManagereservations;
        private Button BtnDashboard;
    }
}