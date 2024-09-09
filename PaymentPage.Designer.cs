namespace TouristManagement
{
    partial class PaymentPage
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
            BtnCreditCard = new Button();
            BtnETransfer = new Button();
            BtnPayPal = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlDark;
            label1.Location = new Point(218, 38);
            label1.Name = "label1";
            label1.Size = new Size(214, 20);
            label1.TabIndex = 0;
            label1.Text = "Choose your mode of payment";
            // 
            // BtnCreditCard
            // 
            BtnCreditCard.BackColor = Color.SkyBlue;
            BtnCreditCard.Location = new Point(263, 94);
            BtnCreditCard.Name = "BtnCreditCard";
            BtnCreditCard.Size = new Size(112, 29);
            BtnCreditCard.TabIndex = 1;
            BtnCreditCard.Text = "Credit card";
            BtnCreditCard.UseVisualStyleBackColor = false;
            BtnCreditCard.Click += BtnCreditCard_Click;
            // 
            // BtnETransfer
            // 
            BtnETransfer.BackColor = Color.SkyBlue;
            BtnETransfer.Location = new Point(263, 158);
            BtnETransfer.Name = "BtnETransfer";
            BtnETransfer.Size = new Size(112, 29);
            BtnETransfer.TabIndex = 2;
            BtnETransfer.Text = "ETransfer";
            BtnETransfer.UseVisualStyleBackColor = false;
            BtnETransfer.Click += BtnETransfer_Click;
            // 
            // BtnPayPal
            // 
            BtnPayPal.BackColor = Color.SkyBlue;
            BtnPayPal.Location = new Point(263, 222);
            BtnPayPal.Name = "BtnPayPal";
            BtnPayPal.Size = new Size(112, 29);
            BtnPayPal.TabIndex = 3;
            BtnPayPal.Text = "Pay Pal";
            BtnPayPal.UseVisualStyleBackColor = false;
            BtnPayPal.Click += BtnPayPal_Click;
            // 
            // PaymentPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(691, 306);
            Controls.Add(BtnPayPal);
            Controls.Add(BtnETransfer);
            Controls.Add(BtnCreditCard);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "PaymentPage";
            Text = "PaymentPage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button BtnCreditCard;
        private Button BtnETransfer;
        private Button BtnPayPal;
    }
}