namespace TouristManagement
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblWelcome = new Label();
            lblUserName = new Label();
            txtUserName = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            btnregister = new Button();
            cboxRole = new ComboBox();
            lblRole = new Label();
            btnSignIn = new Button();
            lblLoginError = new Label();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.BackColor = SystemColors.ScrollBar;
            lblWelcome.Font = new Font("Showcard Gothic", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWelcome.Location = new Point(243, 47);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(250, 59);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Welcome";
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Javanese Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUserName.Location = new Point(190, 156);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(113, 45);
            lblUserName.TabIndex = 1;
            lblUserName.Text = "User name";
            // 
            // txtUserName
            // 
            txtUserName.BackColor = Color.White;
            txtUserName.Location = new Point(358, 162);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(125, 27);
            txtUserName.TabIndex = 2;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Javanese Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPassword.Location = new Point(190, 206);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(101, 45);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.White;
            txtPassword.Location = new Point(358, 212);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(125, 27);
            txtPassword.TabIndex = 4;
            // 
            // btnregister
            // 
            btnregister.BackColor = Color.SkyBlue;
            btnregister.Location = new Point(193, 329);
            btnregister.Name = "btnregister";
            btnregister.Size = new Size(108, 36);
            btnregister.TabIndex = 5;
            btnregister.Text = "Register";
            btnregister.UseVisualStyleBackColor = false;
            btnregister.Click += btnregister_Click;
            // 
            // cboxRole
            // 
            cboxRole.BackColor = Color.White;
            cboxRole.FormattingEnabled = true;
            cboxRole.Items.AddRange(new object[] { "Admin", "Tourist" });
            cboxRole.Location = new Point(358, 263);
            cboxRole.Name = "cboxRole";
            cboxRole.Size = new Size(125, 28);
            cboxRole.TabIndex = 6;
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Font = new Font("Javanese Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRole.Location = new Point(190, 257);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(59, 45);
            lblRole.TabIndex = 7;
            lblRole.Text = "Role";
            // 
            // btnSignIn
            // 
            btnSignIn.BackColor = Color.SkyBlue;
            btnSignIn.Location = new Point(345, 329);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(103, 36);
            btnSignIn.TabIndex = 8;
            btnSignIn.Text = "Sign In";
            btnSignIn.UseVisualStyleBackColor = false;
            btnSignIn.Click += btnSignIn_Click;
            // 
            // lblLoginError
            // 
            lblLoginError.AutoSize = true;
            lblLoginError.Location = new Point(190, 386);
            lblLoginError.Name = "lblLoginError";
            lblLoginError.Size = new Size(0, 20);
            lblLoginError.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(746, 530);
            Controls.Add(lblLoginError);
            Controls.Add(btnSignIn);
            Controls.Add(lblRole);
            Controls.Add(cboxRole);
            Controls.Add(btnregister);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtUserName);
            Controls.Add(lblUserName);
            Controls.Add(lblWelcome);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWelcome;
        private Label lblUserName;
        private TextBox txtUserName;
        private Label lblPassword;
        private TextBox txtPassword;
        private Button btnregister;
        private ComboBox cboxRole;
        private Label lblRole;
        private Button btnSignIn;
        private Label lblLoginError;
    }
}
