namespace TouristManagement
{
    partial class LoginPage
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
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            label3 = new Label();
            cboxRole = new ComboBox();
            label4 = new Label();
            lblLoginError = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Javanese Text", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(209, 118);
            label1.Name = "label1";
            label1.Size = new Size(102, 41);
            label1.TabIndex = 0;
            label1.Text = "User name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Javanese Text", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(209, 186);
            label2.Name = "label2";
            label2.Size = new Size(91, 41);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(344, 118);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(151, 27);
            txtUserName.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(344, 186);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(150, 27);
            txtPassword.TabIndex = 3;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.SkyBlue;
            btnLogin.Location = new Point(283, 330);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 29);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Javanese Text", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(209, 255);
            label3.Name = "label3";
            label3.Size = new Size(53, 41);
            label3.TabIndex = 5;
            label3.Text = "Role";
            // 
            // cboxRole
            // 
            cboxRole.FormattingEnabled = true;
            cboxRole.Items.AddRange(new object[] { "Admin", "Tourist" });
            cboxRole.Location = new Point(344, 259);
            cboxRole.Name = "cboxRole";
            cboxRole.Size = new Size(151, 28);
            cboxRole.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ControlDark;
            label4.Location = new Point(169, 42);
            label4.Name = "label4";
            label4.Size = new Size(430, 20);
            label4.TabIndex = 7;
            label4.Text = "Your registration is successful, please login with your credentials";
            // 
            // lblLoginError
            // 
            lblLoginError.AutoSize = true;
            lblLoginError.Location = new Point(170, 386);
            lblLoginError.Name = "lblLoginError";
            lblLoginError.Size = new Size(0, 20);
            lblLoginError.TabIndex = 8;
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 412);
            Controls.Add(lblLoginError);
            Controls.Add(label4);
            Controls.Add(cboxRole);
            Controls.Add(label3);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "LoginPage";
            Text = "LoginPage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtUserName;
        private TextBox txtPassword;
        private Button btnLogin;
        private Label label3;
        private ComboBox cboxRole;
        private Label label4;
        private Label lblLoginError;
    }
}