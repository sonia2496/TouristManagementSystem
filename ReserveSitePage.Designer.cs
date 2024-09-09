namespace TouristManagement
{
    partial class ReserveSitePage
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
            cmbChooseSite = new ComboBox();
            label3 = new Label();
            dtpReservationDate = new DateTimePicker();
            label4 = new Label();
            label5 = new Label();
            dtpStartDate = new DateTimePicker();
            dtpEndDate = new DateTimePicker();
            btnBookReservation = new Button();
            label6 = new Label();
            LstNotifications = new ListBox();
            label7 = new Label();
            Back = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlDark;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(193, 44);
            label1.Name = "label1";
            label1.Size = new Size(214, 20);
            label1.TabIndex = 0;
            label1.Text = "Please select the details below:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Javanese Text", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(99, 178);
            label2.Name = "label2";
            label2.Size = new Size(106, 41);
            label2.TabIndex = 1;
            label2.Text = "Choose site";
            // 
            // cmbChooseSite
            // 
            cmbChooseSite.FormattingEnabled = true;
            cmbChooseSite.Items.AddRange(new object[] { "CN Tower", "Taj Mahal", "Eiffel Tower", "Statue of Liberty" });
            cmbChooseSite.Location = new Point(266, 178);
            cmbChooseSite.Name = "cmbChooseSite";
            cmbChooseSite.Size = new Size(265, 28);
            cmbChooseSite.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Javanese Text", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(99, 114);
            label3.Name = "label3";
            label3.Size = new Size(152, 41);
            label3.TabIndex = 3;
            label3.Text = "Reservation Date";
            // 
            // dtpReservationDate
            // 
            dtpReservationDate.Location = new Point(266, 114);
            dtpReservationDate.Name = "dtpReservationDate";
            dtpReservationDate.Size = new Size(265, 27);
            dtpReservationDate.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Javanese Text", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(101, 237);
            label4.Name = "label4";
            label4.Size = new Size(95, 41);
            label4.TabIndex = 5;
            label4.Text = "Start date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Javanese Text", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(101, 301);
            label5.Name = "label5";
            label5.Size = new Size(89, 41);
            label5.TabIndex = 6;
            label5.Text = "End date";
            // 
            // dtpStartDate
            // 
            dtpStartDate.Location = new Point(266, 239);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(265, 27);
            dtpStartDate.TabIndex = 7;
            // 
            // dtpEndDate
            // 
            dtpEndDate.Location = new Point(266, 303);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(265, 27);
            dtpEndDate.TabIndex = 8;
            // 
            // btnBookReservation
            // 
            btnBookReservation.BackColor = Color.SkyBlue;
            btnBookReservation.Location = new Point(214, 367);
            btnBookReservation.Name = "btnBookReservation";
            btnBookReservation.Size = new Size(166, 29);
            btnBookReservation.TabIndex = 9;
            btnBookReservation.Text = "Book reservation";
            btnBookReservation.UseVisualStyleBackColor = false;
            btnBookReservation.Click += btnBookReservation_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ControlDark;
            label6.Location = new Point(541, 181);
            label6.Name = "label6";
            label6.Size = new Size(210, 20);
            label6.TabIndex = 10;
            label6.Text = "Only available sites are shown.";
            // 
            // LstNotifications
            // 
            LstNotifications.FormattingEnabled = true;
            LstNotifications.Location = new Point(101, 480);
            LstNotifications.Name = "LstNotifications";
            LstNotifications.Size = new Size(430, 124);
            LstNotifications.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.ControlDark;
            label7.Location = new Point(101, 434);
            label7.Name = "label7";
            label7.Size = new Size(212, 20);
            label7.TabIndex = 12;
            label7.Text = "Notification on site availability";
            // 
            // Back
            // 
            Back.BackColor = Color.SkyBlue;
            Back.Location = new Point(12, 12);
            Back.Name = "Back";
            Back.Size = new Size(68, 29);
            Back.TabIndex = 13;
            Back.Text = "Back";
            Back.UseVisualStyleBackColor = false;
            Back.Click += Back_Click;
            // 
            // ReserveSitePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 629);
            Controls.Add(Back);
            Controls.Add(label7);
            Controls.Add(LstNotifications);
            Controls.Add(label6);
            Controls.Add(btnBookReservation);
            Controls.Add(dtpEndDate);
            Controls.Add(dtpStartDate);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(dtpReservationDate);
            Controls.Add(label3);
            Controls.Add(cmbChooseSite);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "ReserveSitePage";
            Text = "ReserveSitePage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cmbChooseSite;
        private Label label3;
        private DateTimePicker dtpReservationDate;
        private Label label4;
        private Label label5;
        private DateTimePicker dtpStartDate;
        private DateTimePicker dtpEndDate;
        private Button btnBookReservation;
        private Label label6;
        private ListBox LstNotifications;
        private Label label7;
        private Button Back;
    }
}