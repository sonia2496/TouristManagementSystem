namespace TouristManagement
{
    partial class UpdateSite
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
            LblSiteName = new Label();
            LblNewSiteName = new Label();
            LblNewDescription = new Label();
            lblNewLocation = new Label();
            LblAvailability = new Label();
            LblAvailableDate = new Label();
            TxtNewSiteName = new TextBox();
            TxtNewDescription = new TextBox();
            TxtNewLocation = new TextBox();
            CmbSiteName = new ComboBox();
            CmbAvailability = new ComboBox();
            DtpAvailableDate = new DateTimePicker();
            BtnUpdateSite = new Button();
            label1 = new Label();
            BtnBack = new Button();
            SuspendLayout();
            // 
            // LblSiteName
            // 
            LblSiteName.AutoSize = true;
            LblSiteName.Font = new Font("Javanese Text", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblSiteName.Location = new Point(146, 62);
            LblSiteName.Name = "LblSiteName";
            LblSiteName.Size = new Size(193, 41);
            LblSiteName.TabIndex = 1;
            LblSiteName.Text = "Choose Site to update ";
            // 
            // LblNewSiteName
            // 
            LblNewSiteName.AutoSize = true;
            LblNewSiteName.Font = new Font("Javanese Text", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblNewSiteName.Location = new Point(151, 113);
            LblNewSiteName.Name = "LblNewSiteName";
            LblNewSiteName.Size = new Size(142, 41);
            LblNewSiteName.TabIndex = 3;
            LblNewSiteName.Text = "New Site Name";
            // 
            // LblNewDescription
            // 
            LblNewDescription.AutoSize = true;
            LblNewDescription.Font = new Font("Javanese Text", 10.8F);
            LblNewDescription.Location = new Point(146, 179);
            LblNewDescription.Name = "LblNewDescription";
            LblNewDescription.Size = new Size(149, 41);
            LblNewDescription.TabIndex = 4;
            LblNewDescription.Text = "New Description";
            // 
            // lblNewLocation
            // 
            lblNewLocation.AutoSize = true;
            lblNewLocation.Font = new Font("Javanese Text", 10.8F);
            lblNewLocation.Location = new Point(151, 237);
            lblNewLocation.Name = "lblNewLocation";
            lblNewLocation.Size = new Size(127, 41);
            lblNewLocation.TabIndex = 5;
            lblNewLocation.Text = "New Location";
            // 
            // LblAvailability
            // 
            LblAvailability.AutoSize = true;
            LblAvailability.Font = new Font("Javanese Text", 10.8F);
            LblAvailability.Location = new Point(146, 298);
            LblAvailability.Name = "LblAvailability";
            LblAvailability.Size = new Size(106, 41);
            LblAvailability.TabIndex = 6;
            LblAvailability.Text = "Availability";
            // 
            // LblAvailableDate
            // 
            LblAvailableDate.AutoSize = true;
            LblAvailableDate.Font = new Font("Javanese Text", 10.8F);
            LblAvailableDate.Location = new Point(146, 359);
            LblAvailableDate.Name = "LblAvailableDate";
            LblAvailableDate.Size = new Size(132, 41);
            LblAvailableDate.TabIndex = 7;
            LblAvailableDate.Text = "Available Date";
            // 
            // TxtNewSiteName
            // 
            TxtNewSiteName.Location = new Point(358, 117);
            TxtNewSiteName.Name = "TxtNewSiteName";
            TxtNewSiteName.Size = new Size(246, 27);
            TxtNewSiteName.TabIndex = 8;
            // 
            // TxtNewDescription
            // 
            TxtNewDescription.Location = new Point(358, 183);
            TxtNewDescription.Name = "TxtNewDescription";
            TxtNewDescription.Size = new Size(246, 27);
            TxtNewDescription.TabIndex = 9;
            // 
            // TxtNewLocation
            // 
            TxtNewLocation.Location = new Point(358, 241);
            TxtNewLocation.Name = "TxtNewLocation";
            TxtNewLocation.Size = new Size(246, 27);
            TxtNewLocation.TabIndex = 10;
            // 
            // CmbSiteName
            // 
            CmbSiteName.FormattingEnabled = true;
            CmbSiteName.Location = new Point(358, 62);
            CmbSiteName.Name = "CmbSiteName";
            CmbSiteName.Size = new Size(246, 28);
            CmbSiteName.TabIndex = 13;
            CmbSiteName.SelectedIndexChanged += CmbSiteName_SelectedIndexChanged;
            // 
            // CmbAvailability
            // 
            CmbAvailability.FormattingEnabled = true;
            CmbAvailability.Location = new Point(354, 302);
            CmbAvailability.Name = "CmbAvailability";
            CmbAvailability.Size = new Size(250, 28);
            CmbAvailability.TabIndex = 14;
            // 
            // DtpAvailableDate
            // 
            DtpAvailableDate.Location = new Point(354, 359);
            DtpAvailableDate.Name = "DtpAvailableDate";
            DtpAvailableDate.Size = new Size(250, 27);
            DtpAvailableDate.TabIndex = 15;
            // 
            // BtnUpdateSite
            // 
            BtnUpdateSite.BackColor = Color.SkyBlue;
            BtnUpdateSite.Location = new Point(253, 416);
            BtnUpdateSite.Name = "BtnUpdateSite";
            BtnUpdateSite.Size = new Size(167, 33);
            BtnUpdateSite.TabIndex = 16;
            BtnUpdateSite.Text = "Update Site";
            BtnUpdateSite.UseVisualStyleBackColor = false;
            BtnUpdateSite.Click += BtnUpdateSite_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlDark;
            label1.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(635, 120);
            label1.Name = "label1";
            label1.Size = new Size(184, 17);
            label1.TabIndex = 17;
            label1.Text = "Site name cannot be changed.";
            // 
            // BtnBack
            // 
            BtnBack.BackColor = Color.SkyBlue;
            BtnBack.Location = new Point(12, 12);
            BtnBack.Name = "BtnBack";
            BtnBack.Size = new Size(94, 29);
            BtnBack.TabIndex = 18;
            BtnBack.Text = "Back";
            BtnBack.UseVisualStyleBackColor = false;
            BtnBack.Click += BtnBack_Click;
            // 
            // UpdateSite
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(885, 522);
            Controls.Add(BtnBack);
            Controls.Add(label1);
            Controls.Add(BtnUpdateSite);
            Controls.Add(DtpAvailableDate);
            Controls.Add(CmbAvailability);
            Controls.Add(CmbSiteName);
            Controls.Add(TxtNewLocation);
            Controls.Add(TxtNewDescription);
            Controls.Add(TxtNewSiteName);
            Controls.Add(LblAvailableDate);
            Controls.Add(LblAvailability);
            Controls.Add(lblNewLocation);
            Controls.Add(LblNewDescription);
            Controls.Add(LblNewSiteName);
            Controls.Add(LblSiteName);
            MaximizeBox = false;
            Name = "UpdateSite";
            Text = "UpdateSite";
            Load += UpdateSite_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label LblSiteName;
        private Label LblNewSiteName;
        private Label LblNewDescription;
        private Label lblNewLocation;
        private Label LblAvailability;
        private Label LblAvailableDate;
        private TextBox TxtNewSiteName;
        private TextBox TxtNewDescription;
        private TextBox TxtNewLocation;
        private ComboBox CmbSiteName;
        private ComboBox CmbAvailability;
        private DateTimePicker DtpAvailableDate;
        private Button BtnUpdateSite;
        private Label label1;
        private Button BtnBack;
    }
}