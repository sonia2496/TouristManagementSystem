namespace TouristManagement
{
    partial class UpdateProfile
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
            label4 = new Label();
            label5 = new Label();
            txtCurrentUserName = new TextBox();
            txtNewUserName = new TextBox();
            txtCurrentPwd = new TextBox();
            txtNewPwd = new TextBox();
            txtReTypeNewPwd = new TextBox();
            btnUpdateUserName = new Button();
            btnUpdatePassword = new Button();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Javanese Text", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(177, 128);
            label1.Name = "label1";
            label1.Size = new Size(205, 41);
            label1.TabIndex = 0;
            label1.Text = "Enter current username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Javanese Text", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(177, 360);
            label2.Name = "label2";
            label2.Size = new Size(178, 41);
            label2.TabIndex = 1;
            label2.Text = "Enter new password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Javanese Text", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(177, 182);
            label3.Name = "label3";
            label3.Size = new Size(181, 41);
            label3.TabIndex = 2;
            label3.Text = "Enter new username";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Javanese Text", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(177, 311);
            label4.Name = "label4";
            label4.Size = new Size(202, 41);
            label4.TabIndex = 3;
            label4.Text = "Enter current password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Javanese Text", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(177, 426);
            label5.Name = "label5";
            label5.Size = new Size(196, 41);
            label5.TabIndex = 4;
            label5.Text = "Re-type new password";
            // 
            // txtCurrentUserName
            // 
            txtCurrentUserName.Location = new Point(399, 128);
            txtCurrentUserName.Name = "txtCurrentUserName";
            txtCurrentUserName.Size = new Size(228, 27);
            txtCurrentUserName.TabIndex = 5;
            // 
            // txtNewUserName
            // 
            txtNewUserName.Location = new Point(399, 182);
            txtNewUserName.Name = "txtNewUserName";
            txtNewUserName.Size = new Size(228, 27);
            txtNewUserName.TabIndex = 6;
            // 
            // txtCurrentPwd
            // 
            txtCurrentPwd.Location = new Point(399, 308);
            txtCurrentPwd.Name = "txtCurrentPwd";
            txtCurrentPwd.PasswordChar = '*';
            txtCurrentPwd.Size = new Size(228, 27);
            txtCurrentPwd.TabIndex = 7;
            // 
            // txtNewPwd
            // 
            txtNewPwd.Location = new Point(399, 364);
            txtNewPwd.Name = "txtNewPwd";
            txtNewPwd.PasswordChar = '*';
            txtNewPwd.Size = new Size(228, 27);
            txtNewPwd.TabIndex = 8;
            // 
            // txtReTypeNewPwd
            // 
            txtReTypeNewPwd.Location = new Point(399, 430);
            txtReTypeNewPwd.Name = "txtReTypeNewPwd";
            txtReTypeNewPwd.PasswordChar = '*';
            txtReTypeNewPwd.Size = new Size(228, 27);
            txtReTypeNewPwd.TabIndex = 9;
            // 
            // btnUpdateUserName
            // 
            btnUpdateUserName.BackColor = Color.SkyBlue;
            btnUpdateUserName.Location = new Point(291, 241);
            btnUpdateUserName.Name = "btnUpdateUserName";
            btnUpdateUserName.Size = new Size(171, 29);
            btnUpdateUserName.TabIndex = 10;
            btnUpdateUserName.Text = "Update Username";
            btnUpdateUserName.UseVisualStyleBackColor = false;
            btnUpdateUserName.Click += btnUpdateUserName_Click;
            // 
            // btnUpdatePassword
            // 
            btnUpdatePassword.BackColor = Color.SkyBlue;
            btnUpdatePassword.Location = new Point(291, 492);
            btnUpdatePassword.Name = "btnUpdatePassword";
            btnUpdatePassword.Size = new Size(157, 29);
            btnUpdatePassword.TabIndex = 11;
            btnUpdatePassword.Text = "Update password";
            btnUpdatePassword.UseVisualStyleBackColor = false;
            btnUpdatePassword.Click += btnUpdatePassword_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.Control;
            label6.Font = new Font("Showcard Gothic", 14F);
            label6.Location = new Point(317, 63);
            label6.Name = "label6";
            label6.Size = new Size(208, 30);
            label6.TabIndex = 12;
            label6.Text = "Update Profile";
            // 
            // UpdateProfile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(854, 569);
            Controls.Add(label6);
            Controls.Add(btnUpdatePassword);
            Controls.Add(btnUpdateUserName);
            Controls.Add(txtReTypeNewPwd);
            Controls.Add(txtNewPwd);
            Controls.Add(txtCurrentPwd);
            Controls.Add(txtNewUserName);
            Controls.Add(txtCurrentUserName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "UpdateProfile";
            Text = "UpdateProfile";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtCurrentUserName;
        private TextBox txtNewUserName;
        private TextBox txtCurrentPwd;
        private TextBox txtNewPwd;
        private TextBox txtReTypeNewPwd;
        private Button btnUpdateUserName;
        private Button btnUpdatePassword;
        private Label label6;
    }
}