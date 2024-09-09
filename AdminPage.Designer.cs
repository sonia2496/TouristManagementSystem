namespace TouristManagement
{
    partial class AdminPage
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
            BtnAddSite = new Button();
            BtnRemoveSite = new Button();
            BtnUpdateSite = new Button();
            BtnViewAllSites = new Button();
            BtnLogOut = new Button();
            BtnViewAllUsers = new Button();
            BtnRemoveUser = new Button();
            BtnViewAllReservations = new Button();
            SuspendLayout();
            // 
            // BtnAddSite
            // 
            BtnAddSite.BackColor = Color.PaleTurquoise;
            BtnAddSite.Location = new Point(217, 37);
            BtnAddSite.Name = "BtnAddSite";
            BtnAddSite.Size = new Size(169, 29);
            BtnAddSite.TabIndex = 0;
            BtnAddSite.Text = "Add site";
            BtnAddSite.UseVisualStyleBackColor = false;
            BtnAddSite.Click += BtnAddSite_Click;
            // 
            // BtnRemoveSite
            // 
            BtnRemoveSite.BackColor = Color.PaleTurquoise;
            BtnRemoveSite.Location = new Point(217, 84);
            BtnRemoveSite.Name = "BtnRemoveSite";
            BtnRemoveSite.Size = new Size(169, 29);
            BtnRemoveSite.TabIndex = 1;
            BtnRemoveSite.Text = "Remove site";
            BtnRemoveSite.UseVisualStyleBackColor = false;
            BtnRemoveSite.Click += BtnRemoveSite_Click;
            // 
            // BtnUpdateSite
            // 
            BtnUpdateSite.BackColor = Color.PaleTurquoise;
            BtnUpdateSite.Location = new Point(213, 131);
            BtnUpdateSite.Name = "BtnUpdateSite";
            BtnUpdateSite.Size = new Size(173, 29);
            BtnUpdateSite.TabIndex = 2;
            BtnUpdateSite.Text = "Update site";
            BtnUpdateSite.UseVisualStyleBackColor = false;
            BtnUpdateSite.Click += BtnUpdateSite_Click;
            // 
            // BtnViewAllSites
            // 
            BtnViewAllSites.BackColor = Color.PaleTurquoise;
            BtnViewAllSites.Location = new Point(213, 179);
            BtnViewAllSites.Name = "BtnViewAllSites";
            BtnViewAllSites.Size = new Size(173, 29);
            BtnViewAllSites.TabIndex = 3;
            BtnViewAllSites.Text = "View all sites";
            BtnViewAllSites.UseVisualStyleBackColor = false;
            BtnViewAllSites.Click += BtnViewAllSites_Click;
            // 
            // BtnLogOut
            // 
            BtnLogOut.BackColor = Color.SkyBlue;
            BtnLogOut.Location = new Point(496, 414);
            BtnLogOut.Name = "BtnLogOut";
            BtnLogOut.Size = new Size(94, 29);
            BtnLogOut.TabIndex = 4;
            BtnLogOut.Text = "Log out";
            BtnLogOut.UseVisualStyleBackColor = false;
            BtnLogOut.Click += BtnLogOut_Click;
            // 
            // BtnViewAllUsers
            // 
            BtnViewAllUsers.BackColor = Color.PaleTurquoise;
            BtnViewAllUsers.Location = new Point(212, 227);
            BtnViewAllUsers.Name = "BtnViewAllUsers";
            BtnViewAllUsers.Size = new Size(169, 29);
            BtnViewAllUsers.TabIndex = 5;
            BtnViewAllUsers.Text = "View all users";
            BtnViewAllUsers.UseVisualStyleBackColor = false;
            BtnViewAllUsers.Click += BtnViewAllUsers_Click;
            // 
            // BtnRemoveUser
            // 
            BtnRemoveUser.BackColor = Color.PaleTurquoise;
            BtnRemoveUser.Location = new Point(217, 280);
            BtnRemoveUser.Name = "BtnRemoveUser";
            BtnRemoveUser.Size = new Size(169, 29);
            BtnRemoveUser.TabIndex = 6;
            BtnRemoveUser.Text = "Remove user";
            BtnRemoveUser.UseVisualStyleBackColor = false;
            BtnRemoveUser.Click += BtnRemoveUser_Click;
            // 
            // BtnViewAllReservations
            // 
            BtnViewAllReservations.BackColor = Color.PaleTurquoise;
            BtnViewAllReservations.Location = new Point(217, 332);
            BtnViewAllReservations.Name = "BtnViewAllReservations";
            BtnViewAllReservations.Size = new Size(169, 29);
            BtnViewAllReservations.TabIndex = 7;
            BtnViewAllReservations.Text = "View all reservations";
            BtnViewAllReservations.UseVisualStyleBackColor = false;
            BtnViewAllReservations.Click += BtnViewAllReservations_Click;
            // 
            // AdminPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(616, 466);
            Controls.Add(BtnViewAllReservations);
            Controls.Add(BtnRemoveUser);
            Controls.Add(BtnViewAllUsers);
            Controls.Add(BtnLogOut);
            Controls.Add(BtnViewAllSites);
            Controls.Add(BtnUpdateSite);
            Controls.Add(BtnRemoveSite);
            Controls.Add(BtnAddSite);
            MaximizeBox = false;
            Name = "AdminPage";
            Text = "AdminPage";
            ResumeLayout(false);
        }

        #endregion

        private Button BtnAddSite;
        private Button BtnRemoveSite;
        private Button BtnUpdateSite;
        private Button BtnViewAllSites;
        private Button BtnLogOut;
        private Button BtnViewAllUsers;
        private Button BtnRemoveUser;
        private Button BtnViewAllReservations;
    }
}