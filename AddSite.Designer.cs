namespace TouristManagement
{
    partial class AddSite
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            TxtSiteName = new TextBox();
            TxtSiteDesc = new TextBox();
            TxtSiteLoc = new TextBox();
            cmbAvailability = new ComboBox();
            DtpAvailFrom = new DateTimePicker();
            BtnAddSite = new Button();
            LblError = new Label();
            BtnBack = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Javanese Text", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(107, 46);
            label2.Name = "label2";
            label2.Size = new Size(142, 41);
            label2.TabIndex = 1;
            label2.Text = "Enter site name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Javanese Text", 11F);
            label3.Location = new Point(107, 102);
            label3.Name = "label3";
            label3.Size = new Size(198, 43);
            label3.TabIndex = 2;
            label3.Text = "Enter site description";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Javanese Text", 11F);
            label4.Location = new Point(107, 151);
            label4.Name = "label4";
            label4.Size = new Size(171, 43);
            label4.TabIndex = 3;
            label4.Text = "Enter site location";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Javanese Text", 11F);
            label5.Location = new Point(107, 194);
            label5.Name = "label5";
            label5.Size = new Size(172, 43);
            label5.TabIndex = 4;
            label5.Text = "Choose availability";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Javanese Text", 11F);
            label6.Location = new Point(113, 248);
            label6.Name = "label6";
            label6.Size = new Size(136, 43);
            label6.TabIndex = 5;
            label6.Text = "Available from";
            // 
            // TxtSiteName
            // 
            TxtSiteName.Font = new Font("Segoe UI", 11F);
            TxtSiteName.Location = new Point(315, 46);
            TxtSiteName.Name = "TxtSiteName";
            TxtSiteName.Size = new Size(251, 32);
            TxtSiteName.TabIndex = 7;
            // 
            // TxtSiteDesc
            // 
            TxtSiteDesc.Font = new Font("Segoe UI", 11F);
            TxtSiteDesc.Location = new Point(315, 102);
            TxtSiteDesc.Name = "TxtSiteDesc";
            TxtSiteDesc.Size = new Size(251, 32);
            TxtSiteDesc.TabIndex = 8;
            // 
            // TxtSiteLoc
            // 
            TxtSiteLoc.Font = new Font("Segoe UI", 11F);
            TxtSiteLoc.Location = new Point(315, 151);
            TxtSiteLoc.Name = "TxtSiteLoc";
            TxtSiteLoc.Size = new Size(251, 32);
            TxtSiteLoc.TabIndex = 9;
            // 
            // cmbAvailability
            // 
            cmbAvailability.Font = new Font("Segoe UI", 11F);
            cmbAvailability.FormattingEnabled = true;
            cmbAvailability.Items.AddRange(new object[] { "Y", "N" });
            cmbAvailability.Location = new Point(315, 204);
            cmbAvailability.Name = "cmbAvailability";
            cmbAvailability.Size = new Size(251, 33);
            cmbAvailability.TabIndex = 10;
            // 
            // DtpAvailFrom
            // 
            DtpAvailFrom.Font = new Font("Segoe UI", 11F);
            DtpAvailFrom.Location = new Point(315, 259);
            DtpAvailFrom.Name = "DtpAvailFrom";
            DtpAvailFrom.Size = new Size(250, 32);
            DtpAvailFrom.TabIndex = 11;
            // 
            // BtnAddSite
            // 
            BtnAddSite.BackColor = Color.SkyBlue;
            BtnAddSite.Font = new Font("Segoe UI", 11F);
            BtnAddSite.ForeColor = Color.Black;
            BtnAddSite.Location = new Point(218, 328);
            BtnAddSite.Name = "BtnAddSite";
            BtnAddSite.Size = new Size(180, 34);
            BtnAddSite.TabIndex = 12;
            BtnAddSite.Text = "Add Site";
            BtnAddSite.UseVisualStyleBackColor = false;
            BtnAddSite.Click += BtnAddSite_Click;
            // 
            // LblError
            // 
            LblError.AutoSize = true;
            LblError.Location = new Point(126, 362);
            LblError.Name = "LblError";
            LblError.Size = new Size(0, 20);
            LblError.TabIndex = 13;
            // 
            // BtnBack
            // 
            BtnBack.BackColor = Color.SkyBlue;
            BtnBack.Location = new Point(12, 12);
            BtnBack.Name = "BtnBack";
            BtnBack.Size = new Size(68, 29);
            BtnBack.TabIndex = 14;
            BtnBack.Text = "Back";
            BtnBack.UseVisualStyleBackColor = false;
            BtnBack.Click += BtnBack_Click;
            // 
            // AddSite
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(687, 404);
            Controls.Add(BtnBack);
            Controls.Add(LblError);
            Controls.Add(BtnAddSite);
            Controls.Add(DtpAvailFrom);
            Controls.Add(cmbAvailability);
            Controls.Add(TxtSiteLoc);
            Controls.Add(TxtSiteDesc);
            Controls.Add(TxtSiteName);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            MaximizeBox = false;
            Name = "AddSite";
            Text = "AddSite";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox TxtSiteName;
        private TextBox TxtSiteDesc;
        private TextBox TxtSiteLoc;
        private ComboBox cmbAvailability;
        private DateTimePicker DtpAvailFrom;
        private Button BtnAddSite;
        private Label LblError;
        private Button BtnBack;
    }
}