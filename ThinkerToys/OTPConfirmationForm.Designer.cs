namespace ThinkerToys
{
    partial class OTPConfirmationForm
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
            lblInstructions = new Label();
            txtOTP = new TextBox();
            btnSubmitOTP = new Button();
            btnResendOTP = new Button();
            SuspendLayout();
            // 
            // lblInstructions
            // 
            lblInstructions.AutoSize = true;
            lblInstructions.Font = new Font("Microsoft Sans Serif", 10F);
            lblInstructions.Location = new Point(35, 24);
            lblInstructions.Name = "lblInstructions";
            lblInstructions.Size = new Size(308, 17);
            lblInstructions.TabIndex = 0;
            lblInstructions.Text = "Please enter the 6-digit OTP sent to your email:";
            // 
            // txtOTP
            // 
            txtOTP.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtOTP.Font = new Font("Microsoft Sans Serif", 12F);
            txtOTP.Location = new Point(129, 73);
            txtOTP.Name = "txtOTP";
            txtOTP.Size = new Size(100, 26);
            txtOTP.TabIndex = 1;
            // 
            // btnSubmitOTP
            // 
            btnSubmitOTP.Location = new Point(129, 125);
            btnSubmitOTP.Name = "btnSubmitOTP";
            btnSubmitOTP.Size = new Size(100, 30);
            btnSubmitOTP.TabIndex = 2;
            btnSubmitOTP.Text = "Submit OTP";
            btnSubmitOTP.UseVisualStyleBackColor = true;
            btnSubmitOTP.Click += btnSubmitOTP_Click_1;
            // 
            // btnResendOTP
            // 
            btnResendOTP.Location = new Point(129, 187);
            btnResendOTP.Name = "btnResendOTP";
            btnResendOTP.Size = new Size(100, 30);
            btnResendOTP.TabIndex = 3;
            btnResendOTP.Text = "Resend OTP";
            btnResendOTP.UseVisualStyleBackColor = true;
            btnResendOTP.Click += btnResendOTP_Click_1;
            // 
            // OTPConfirmationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 261);
            Controls.Add(btnResendOTP);
            Controls.Add(btnSubmitOTP);
            Controls.Add(txtOTP);
            Controls.Add(lblInstructions);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "OTPConfirmationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OTP Confirmation";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInstructions;
        private TextBox txtOTP;
        private Button btnSubmitOTP;
        private Button btnResendOTP;
    }
}