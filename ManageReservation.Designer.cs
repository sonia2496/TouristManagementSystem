namespace TouristManagement
{
    partial class ManageReservation
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
            cmbMyReservations = new ComboBox();
            BtnUpdateReservation = new Button();
            DtpNewStartDate = new DateTimePicker();
            DtpNewEndDate = new DateTimePicker();
            label3 = new Label();
            label4 = new Label();
            DtpCurrentStartDate = new DateTimePicker();
            DtpCurrentEndDate = new DateTimePicker();
            label5 = new Label();
            label6 = new Label();
            BtnBack = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 13F);
            label1.Location = new Point(280, 56);
            label1.Name = "label1";
            label1.Size = new Size(233, 28);
            label1.TabIndex = 0;
            label1.Text = "Your reservations";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Javanese Text", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(109, 129);
            label2.Name = "label2";
            label2.Size = new Size(249, 41);
            label2.TabIndex = 1;
            label2.Text = "Select a reservation to modify";
            // 
            // cmbMyReservations
            // 
            cmbMyReservations.FormattingEnabled = true;
            cmbMyReservations.Location = new Point(387, 129);
            cmbMyReservations.Name = "cmbMyReservations";
            cmbMyReservations.Size = new Size(250, 28);
            cmbMyReservations.TabIndex = 2;
            cmbMyReservations.SelectedIndexChanged += CmbMyReservations_SelectedIndexChanged;
            // 
            // BtnUpdateReservation
            // 
            BtnUpdateReservation.BackColor = Color.SkyBlue;
            BtnUpdateReservation.Location = new Point(267, 430);
            BtnUpdateReservation.Name = "BtnUpdateReservation";
            BtnUpdateReservation.Size = new Size(184, 29);
            BtnUpdateReservation.TabIndex = 3;
            BtnUpdateReservation.Text = "Update Reservation";
            BtnUpdateReservation.UseVisualStyleBackColor = false;
            BtnUpdateReservation.Click += BtnUpdateReservation_Click;
            // 
            // DtpNewStartDate
            // 
            DtpNewStartDate.Location = new Point(387, 294);
            DtpNewStartDate.Name = "DtpNewStartDate";
            DtpNewStartDate.Size = new Size(250, 27);
            DtpNewStartDate.TabIndex = 4;
            // 
            // DtpNewEndDate
            // 
            DtpNewEndDate.Location = new Point(387, 359);
            DtpNewEndDate.Name = "DtpNewEndDate";
            DtpNewEndDate.Size = new Size(250, 27);
            DtpNewEndDate.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Javanese Text", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(109, 301);
            label3.Name = "label3";
            label3.Size = new Size(201, 41);
            label3.TabIndex = 6;
            label3.Text = "Choose New Start Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Javanese Text", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(109, 364);
            label4.Name = "label4";
            label4.Size = new Size(195, 41);
            label4.TabIndex = 7;
            label4.Text = "Choose New End Date";
            // 
            // DtpCurrentStartDate
            // 
            DtpCurrentStartDate.Location = new Point(387, 183);
            DtpCurrentStartDate.Name = "DtpCurrentStartDate";
            DtpCurrentStartDate.Size = new Size(250, 27);
            DtpCurrentStartDate.TabIndex = 8;
            // 
            // DtpCurrentEndDate
            // 
            DtpCurrentEndDate.Location = new Point(387, 242);
            DtpCurrentEndDate.Name = "DtpCurrentEndDate";
            DtpCurrentEndDate.Size = new Size(250, 27);
            DtpCurrentEndDate.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Javanese Text", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(109, 181);
            label5.Name = "label5";
            label5.Size = new Size(164, 41);
            label5.TabIndex = 10;
            label5.Text = "Current Start Date";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Javanese Text", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(109, 242);
            label6.Name = "label6";
            label6.Size = new Size(158, 41);
            label6.TabIndex = 11;
            label6.Text = "Current End Date";
            // 
            // BtnBack
            // 
            BtnBack.BackColor = Color.SkyBlue;
            BtnBack.Location = new Point(21, 21);
            BtnBack.Name = "BtnBack";
            BtnBack.Size = new Size(94, 29);
            BtnBack.TabIndex = 12;
            BtnBack.Text = "Back";
            BtnBack.UseVisualStyleBackColor = false;
            BtnBack.Click += BtnBack_Click;
            // 
            // ManageReservation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(769, 532);
            Controls.Add(BtnBack);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(DtpCurrentEndDate);
            Controls.Add(DtpCurrentStartDate);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(DtpNewEndDate);
            Controls.Add(DtpNewStartDate);
            Controls.Add(BtnUpdateReservation);
            Controls.Add(cmbMyReservations);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "ManageReservation";
            Text = "ManageReservation";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cmbMyReservations;
        private Button BtnUpdateReservation;
        private DateTimePicker DtpNewStartDate;
        private DateTimePicker DtpNewEndDate;
        private Label label3;
        private Label label4;
        private DateTimePicker DtpCurrentStartDate;
        private DateTimePicker DtpCurrentEndDate;
        private Label label5;
        private Label label6;
        private Button BtnBack;
    }
}