namespace TouristManagement
{
    partial class RemoveSite
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
            CmbForAllSites = new ComboBox();
            BtnDeleteSite = new Button();
            BtnBack = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Javanese Text", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(111, 132);
            label1.Name = "label1";
            label1.Size = new Size(170, 41);
            label1.TabIndex = 0;
            label1.Text = "Select site to delete";
            // 
            // CmbForAllSites
            // 
            CmbForAllSites.FormattingEnabled = true;
            CmbForAllSites.Location = new Point(307, 132);
            CmbForAllSites.Name = "CmbForAllSites";
            CmbForAllSites.Size = new Size(151, 28);
            CmbForAllSites.TabIndex = 1;
            // 
            // BtnDeleteSite
            // 
            BtnDeleteSite.BackColor = Color.SkyBlue;
            BtnDeleteSite.Location = new Point(222, 192);
            BtnDeleteSite.Name = "BtnDeleteSite";
            BtnDeleteSite.Size = new Size(94, 29);
            BtnDeleteSite.TabIndex = 2;
            BtnDeleteSite.Text = "Delete site";
            BtnDeleteSite.UseVisualStyleBackColor = false;
            BtnDeleteSite.Click += BtnDeleteSite_Click;
            // 
            // BtnBack
            // 
            BtnBack.BackColor = Color.SkyBlue;
            BtnBack.Location = new Point(27, 27);
            BtnBack.Name = "BtnBack";
            BtnBack.Size = new Size(68, 29);
            BtnBack.TabIndex = 3;
            BtnBack.Text = "Back";
            BtnBack.UseVisualStyleBackColor = false;
            BtnBack.Click += BtnBack_Click;
            // 
            // RemoveSite
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnBack);
            Controls.Add(BtnDeleteSite);
            Controls.Add(CmbForAllSites);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "RemoveSite";
            Text = "RemoveSite";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox CmbForAllSites;
        private Button BtnDeleteSite;
        private Button BtnBack;
    }
}