namespace TouristManagement
{
    partial class ViewAllSites
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
            LstViewAllSites = new ListView();
            BtnHome = new Button();
            BtnlogOut = new Button();
            SuspendLayout();
            // 
            // LstViewAllSites
            // 
            LstViewAllSites.Location = new Point(61, 58);
            LstViewAllSites.Name = "LstViewAllSites";
            LstViewAllSites.Size = new Size(1108, 213);
            LstViewAllSites.TabIndex = 0;
            LstViewAllSites.UseCompatibleStateImageBehavior = false;
            LstViewAllSites.SelectedIndexChanged += LstViewAllSites_SelectedIndexChanged;
            // 
            // BtnHome
            // 
            BtnHome.BackColor = Color.SkyBlue;
            BtnHome.Location = new Point(432, 308);
            BtnHome.Name = "BtnHome";
            BtnHome.Size = new Size(134, 29);
            BtnHome.TabIndex = 1;
            BtnHome.Text = "Home";
            BtnHome.UseVisualStyleBackColor = false;
            BtnHome.Click += BtnHome_Click;
            // 
            // BtnlogOut
            // 
            BtnlogOut.BackColor = Color.SkyBlue;
            BtnlogOut.Location = new Point(591, 308);
            BtnlogOut.Name = "BtnlogOut";
            BtnlogOut.Size = new Size(124, 29);
            BtnlogOut.TabIndex = 2;
            BtnlogOut.Text = "Logout";
            BtnlogOut.UseVisualStyleBackColor = false;
            BtnlogOut.Click += BtnlogOut_Click;
            // 
            // ViewAllSites
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1205, 369);
            Controls.Add(BtnlogOut);
            Controls.Add(BtnHome);
            Controls.Add(LstViewAllSites);
            MaximizeBox = false;
            Name = "ViewAllSites";
            Text = "ViewAllSites";
            Load += ViewAllSites_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListView LstViewAllSites;
        private Button BtnHome;
        private Button BtnlogOut;
    }
}