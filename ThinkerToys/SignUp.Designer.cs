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
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            textBoxUsername = new TextBox();
            panel2 = new Panel();
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
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            resources.ApplyResources(panel1, "panel1");
            panel1.Name = "panel1";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.toys_and_kid_s_fashion__1__removebg_preview;
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            // 
            // textBoxUsername
            // 
            textBoxUsername.ForeColor = Color.Navy;
            resources.ApplyResources(textBoxUsername, "textBoxUsername");
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.UseWaitCursor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(IDLabel);
            panel2.Controls.Add(textBoxUsername);
            panel2.Controls.Add(SignUpButton);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(GenderLabel);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(textBoxIDNumber);
            panel2.Controls.Add(textBoxPassword);
            panel2.Controls.Add(textBoxConfirmPassword);
            panel2.Controls.Add(textBoxParentPhone);
            panel2.Controls.Add(radioButtonBoy);
            panel2.Controls.Add(radioButtonGirl);
            resources.ApplyResources(panel2, "panel2");
            panel2.Name = "panel2";
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
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Signup";
            Load += Signup_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel2;
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
    }
}