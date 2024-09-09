namespace TouristManagement
{
    partial class RemoveUser
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
            CmbUserName = new ComboBox();
            BtnBack = new Button();
            BtnRemoveUser = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Javanese Text", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(176, 91);
            label1.Name = "label1";
            label1.Size = new Size(186, 41);
            label1.TabIndex = 0;
            label1.Text = "Select user to remove";
            // 
            // CmbUserName
            // 
            CmbUserName.FormattingEnabled = true;
            CmbUserName.Location = new Point(393, 95);
            CmbUserName.Name = "CmbUserName";
            CmbUserName.Size = new Size(205, 28);
            CmbUserName.TabIndex = 1;
            CmbUserName.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // BtnBack
            // 
            BtnBack.BackColor = Color.SkyBlue;
            BtnBack.Location = new Point(32, 28);
            BtnBack.Name = "BtnBack";
            BtnBack.Size = new Size(94, 29);
            BtnBack.TabIndex = 2;
            BtnBack.Text = "Back";
            BtnBack.UseVisualStyleBackColor = false;
            BtnBack.Click += BtnBack_Click;
            // 
            // BtnRemoveUser
            // 
            BtnRemoveUser.BackColor = Color.SkyBlue;
            BtnRemoveUser.Location = new Point(306, 166);
            BtnRemoveUser.Name = "BtnRemoveUser";
            BtnRemoveUser.Size = new Size(131, 29);
            BtnRemoveUser.TabIndex = 3;
            BtnRemoveUser.Text = "Remove User";
            BtnRemoveUser.UseVisualStyleBackColor = false;
            BtnRemoveUser.Click += BtnRemoveUser_Click;
            // 
            // RemoveUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnRemoveUser);
            Controls.Add(BtnBack);
            Controls.Add(CmbUserName);
            Controls.Add(label1);
            Name = "RemoveUser";
            Text = "RemoveUser";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox CmbUserName;
        private Button BtnBack;
        private Button BtnRemoveUser;
    }
}