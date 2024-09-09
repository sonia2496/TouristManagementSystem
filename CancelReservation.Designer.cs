namespace TouristManagement
{
    partial class CancelReservation
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
            btnCancelReservation = new Button();
            cmbCancelReservation = new ComboBox();
            BtnBack = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Javanese Text", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(160, 133);
            label1.Name = "label1";
            label1.Size = new Size(166, 41);
            label1.TabIndex = 0;
            label1.Text = "Choose reservation";
            // 
            // btnCancelReservation
            // 
            btnCancelReservation.BackColor = Color.SkyBlue;
            btnCancelReservation.Location = new Point(229, 197);
            btnCancelReservation.Name = "btnCancelReservation";
            btnCancelReservation.Size = new Size(199, 29);
            btnCancelReservation.TabIndex = 2;
            btnCancelReservation.Text = "Cancel reservation";
            btnCancelReservation.UseVisualStyleBackColor = false;
            btnCancelReservation.Click += btnCancelReservation_Click;
            // 
            // cmbCancelReservation
            // 
            cmbCancelReservation.FormattingEnabled = true;
            cmbCancelReservation.Location = new Point(363, 133);
            cmbCancelReservation.Name = "cmbCancelReservation";
            cmbCancelReservation.Size = new Size(219, 28);
            cmbCancelReservation.TabIndex = 3;
            // 
            // BtnBack
            // 
            BtnBack.BackColor = Color.SkyBlue;
            BtnBack.Location = new Point(12, 12);
            BtnBack.Name = "BtnBack";
            BtnBack.Size = new Size(63, 29);
            BtnBack.TabIndex = 4;
            BtnBack.Text = "Back";
            BtnBack.UseVisualStyleBackColor = false;
            BtnBack.Click += BtnBack_Click;
            // 
            // CancelReservation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(713, 380);
            Controls.Add(BtnBack);
            Controls.Add(cmbCancelReservation);
            Controls.Add(btnCancelReservation);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "CancelReservation";
            Text = "CancelReservation";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnCancelReservation;
        private ComboBox cmbCancelReservation;
        private Button BtnBack;
    }
}