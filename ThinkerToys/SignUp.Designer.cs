namespace ThinkerToys
{
    partial class Signup
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Signup));
            RightPanel = new Panel();
            LogoPicture = new PictureBox();
            textBoxUsername = new TextBox();
            LeftPanel = new Panel();
            LoginAccLabel = new Label();
            AlreadyHaveAccLabel = new Label();
            IDLabel = new Label();
            SignUpButton = new Button();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            GenderLabel = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBoxIDNumber = new TextBox();
            textBoxPassword = new TextBox();
            textBoxConfirmPassword = new TextBox();
            textBoxParentPhone = new TextBox();
            radioButtonBoy = new RadioButton();
            radioButtonGirl = new RadioButton();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            RightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)LogoPicture).BeginInit();
            LeftPanel.SuspendLayout();
            SuspendLayout();
            // 
            // RightPanel
            // 
            RightPanel.Controls.Add(LogoPicture);
            resources.ApplyResources(RightPanel, "RightPanel");
            RightPanel.Name = "RightPanel";
            // 
            // LogoPicture
            // 
            LogoPicture.Image = Properties.Resources.toys_and_kid_s_fashion__1__removebg_preview;
            resources.ApplyResources(LogoPicture, "LogoPicture");
            LogoPicture.Name = "LogoPicture";
            LogoPicture.TabStop = false;
            // 
            // textBoxUsername
            // 
            textBoxUsername.ForeColor = Color.Navy;
            resources.ApplyResources(textBoxUsername, "textBoxUsername");
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.UseWaitCursor = true;
            // 
            // LeftPanel
            // 
            LeftPanel.Controls.Add(LoginAccLabel);
            LeftPanel.Controls.Add(AlreadyHaveAccLabel);
            LeftPanel.Controls.Add(IDLabel);
            LeftPanel.Controls.Add(textBoxUsername);
            LeftPanel.Controls.Add(SignUpButton);
            LeftPanel.Controls.Add(label9);
            LeftPanel.Controls.Add(label8);
            LeftPanel.Controls.Add(label7);
            LeftPanel.Controls.Add(GenderLabel);
            LeftPanel.Controls.Add(label5);
            LeftPanel.Controls.Add(label4);
            LeftPanel.Controls.Add(label3);
            LeftPanel.Controls.Add(label2);
            LeftPanel.Controls.Add(label1);
            LeftPanel.Controls.Add(textBoxIDNumber);
            LeftPanel.Controls.Add(textBoxPassword);
            LeftPanel.Controls.Add(textBoxConfirmPassword);
            LeftPanel.Controls.Add(textBoxParentPhone);
            LeftPanel.Controls.Add(radioButtonBoy);
            LeftPanel.Controls.Add(radioButtonGirl);
            resources.ApplyResources(LeftPanel, "LeftPanel");
            LeftPanel.Name = "LeftPanel";
            // 
            // LoginAccLabel
            // 
            resources.ApplyResources(LoginAccLabel, "LoginAccLabel");
            LoginAccLabel.ForeColor = Color.Red;
            LoginAccLabel.Name = "LoginAccLabel";
            LoginAccLabel.Click += LoginAccLabel_Click;
            // 
            // AlreadyHaveAccLabel
            // 
            resources.ApplyResources(AlreadyHaveAccLabel, "AlreadyHaveAccLabel");
            AlreadyHaveAccLabel.BackColor = SystemColors.Control;
            AlreadyHaveAccLabel.Cursor = Cursors.No;
            AlreadyHaveAccLabel.ForeColor = Color.Navy;
            AlreadyHaveAccLabel.Name = "AlreadyHaveAccLabel";
            AlreadyHaveAccLabel.Click += AlreadyHaveAccLabel_Click;
            // 
            // IDLabel
            // 
            resources.ApplyResources(IDLabel, "IDLabel");
            IDLabel.ForeColor = Color.Navy;
            IDLabel.Name = "IDLabel";
            // 
            // SignUpButton
            // 
            resources.ApplyResources(SignUpButton, "SignUpButton");
            SignUpButton.Name = "SignUpButton";
            SignUpButton.UseVisualStyleBackColor = true;
            SignUpButton.Click += SignUpButton_Click;
            // 
            // label9
            // 
            resources.ApplyResources(label9, "label9");
            label9.ForeColor = Color.Green;
            label9.Name = "label9";
            // 
            // label8
            // 
            resources.ApplyResources(label8, "label8");
            label8.ForeColor = Color.Red;
            label8.Name = "label8";
            // 
            // label7
            // 
            resources.ApplyResources(label7, "label7");
            label7.ForeColor = Color.Red;
            label7.Name = "label7";
            // 
            // GenderLabel
            // 
            resources.ApplyResources(GenderLabel, "GenderLabel");
            GenderLabel.ForeColor = Color.Navy;
            GenderLabel.Name = "GenderLabel";
            // 
            // label5
            // 
            resources.ApplyResources(label5, "label5");
            label5.ForeColor = Color.Navy;
            label5.Name = "label5";
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.ForeColor = Color.Navy;
            label4.Name = "label4";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.ForeColor = Color.Navy;
            label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.ForeColor = Color.Navy;
            label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.ForeColor = Color.Navy;
            label1.Name = "label1";
            // 
            // textBoxIDNumber
            // 
            textBoxIDNumber.ForeColor = Color.Navy;
            resources.ApplyResources(textBoxIDNumber, "textBoxIDNumber");
            textBoxIDNumber.Name = "textBoxIDNumber";
            textBoxIDNumber.UseWaitCursor = true;
            textBoxIDNumber.TextChanged += textBoxIDNumber_TextChanged_1;
            // 
            // textBoxPassword
            // 
            textBoxPassword.ForeColor = Color.Navy;
            resources.ApplyResources(textBoxPassword, "textBoxPassword");
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.UseSystemPasswordChar = true;
            textBoxPassword.UseWaitCursor = true;
            textBoxPassword.TextChanged += textBoxPassword_TextChanged_1;
            // 
            // textBoxConfirmPassword
            // 
            textBoxConfirmPassword.ForeColor = Color.Navy;
            resources.ApplyResources(textBoxConfirmPassword, "textBoxConfirmPassword");
            textBoxConfirmPassword.Name = "textBoxConfirmPassword";
            textBoxConfirmPassword.UseSystemPasswordChar = true;
            textBoxConfirmPassword.UseWaitCursor = true;
            // 
            // textBoxParentPhone
            // 
            textBoxParentPhone.ForeColor = Color.Navy;
            resources.ApplyResources(textBoxParentPhone, "textBoxParentPhone");
            textBoxParentPhone.Name = "textBoxParentPhone";
            textBoxParentPhone.UseWaitCursor = true;
            // 
            // radioButtonBoy
            // 
            resources.ApplyResources(radioButtonBoy, "radioButtonBoy");
            radioButtonBoy.ForeColor = Color.Navy;
            radioButtonBoy.Name = "radioButtonBoy";
            radioButtonBoy.TabStop = true;
            radioButtonBoy.UseVisualStyleBackColor = true;
            // 
            // radioButtonGirl
            // 
            resources.ApplyResources(radioButtonGirl, "radioButtonGirl");
            radioButtonGirl.ForeColor = Color.Navy;
            radioButtonGirl.Name = "radioButtonGirl";
            radioButtonGirl.TabStop = true;
            radioButtonGirl.UseVisualStyleBackColor = true;
            // 
            // Signup
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(LeftPanel);
            Controls.Add(RightPanel);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Signup";
            Load += Signup_Load;
            RightPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)LogoPicture).EndInit();
            LeftPanel.ResumeLayout(false);
            LeftPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel RightPanel;
        private PictureBox LogoPicture;
        private Panel LeftPanel;
        private TextBox textBoxIDNumber;
        private TextBox textBoxUsername;
        private TextBox textBoxConfirmPassword;
        private TextBox textBoxParentPhone;
        private RadioButton radioButtonBoy;
        private RadioButton radioButtonGirl;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label GenderLabel;
        private Label label7;
        private Label label8;
        private Label label9;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button SignUpButton;
        private TextBox textBoxPassword;
        private Label IDLabel;
        private Label LoginAccLabel;
        private Label AlreadyHaveAccLabel;
    }
}