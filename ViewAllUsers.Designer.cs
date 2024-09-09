namespace TouristManagement
{
    partial class ViewAllUsers
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
            listView1 = new ListView();
            BtnBack = new Button();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Location = new Point(82, 114);
            listView1.Name = "listView1";
            listView1.Size = new Size(576, 121);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // BtnBack
            // 
            BtnBack.BackColor = Color.SkyBlue;
            BtnBack.Location = new Point(21, 12);
            BtnBack.Name = "BtnBack";
            BtnBack.Size = new Size(94, 29);
            BtnBack.TabIndex = 1;
            BtnBack.Text = "Back";
            BtnBack.UseVisualStyleBackColor = false;
            BtnBack.Click += BtnBack_Click;
            // 
            // ViewAllUsers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnBack);
            Controls.Add(listView1);
            Name = "ViewAllUsers";
            Text = "ViewAllUsers";
            ResumeLayout(false);
        }

        #endregion

        private ListView listView1;
        private Button BtnBack;
    }
}