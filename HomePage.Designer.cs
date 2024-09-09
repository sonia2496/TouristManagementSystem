namespace TouristManagement
{
    partial class HomePage
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
            btnReserve = new Button();
            btnEditProfile = new Button();
            btnLogout = new Button();
            SuspendLayout();
            // 
            // btnReserve
            // 
            btnReserve.BackColor = Color.SkyBlue;
            btnReserve.Location = new Point(304, 126);
            btnReserve.Name = "btnReserve";
            btnReserve.Size = new Size(189, 29);
            btnReserve.TabIndex = 0;
            btnReserve.Text = "Reservations";
            btnReserve.UseVisualStyleBackColor = false;
            btnReserve.Click += btnReserve_Click;
            // 
            // btnEditProfile
            // 
            btnEditProfile.BackColor = Color.SkyBlue;
            btnEditProfile.Location = new Point(304, 213);
            btnEditProfile.Name = "btnEditProfile";
            btnEditProfile.Size = new Size(189, 29);
            btnEditProfile.TabIndex = 1;
            btnEditProfile.Text = "Edit Profile";
            btnEditProfile.UseVisualStyleBackColor = false;
            btnEditProfile.Click += btnEditProfile_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.SkyBlue;
            btnLogout.Location = new Point(304, 300);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(189, 29);
            btnLogout.TabIndex = 2;
            btnLogout.Text = "Log out";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLogout);
            Controls.Add(btnEditProfile);
            Controls.Add(btnReserve);
            MaximizeBox = false;
            Name = "HomePage";
            Text = "HomePage";
            ResumeLayout(false);
        }

        #endregion

        private Button btnReserve;
        private Button btnEditProfile;
        private Button btnLogout;
    }
}