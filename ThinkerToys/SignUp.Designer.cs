namespace ThinkerToys
{
    partial class SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            panel1 = new Panel();
            ID_textbox = new TextBox();
            radioButtonFemale = new RadioButton();
            radioButtonMale = new RadioButton();
            RePassword_textbox = new TextBox();
            RePassword = new Label();
            Password_textbox = new TextBox();
            Password = new Label();
            Username_textbox = new TextBox();
            Username = new Label();
            ID_Label = new Label();
            SignUpForm_label = new Label();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            resources.ApplyResources(panel1, "panel1");
            panel1.BackColor = Color.FromArgb(250, 252, 252);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(ID_textbox);
            panel1.Controls.Add(radioButtonFemale);
            panel1.Controls.Add(radioButtonMale);
            panel1.Controls.Add(RePassword_textbox);
            panel1.Controls.Add(RePassword);
            panel1.Controls.Add(Password_textbox);
            panel1.Controls.Add(Password);
            panel1.Controls.Add(Username_textbox);
            panel1.Controls.Add(Username);
            panel1.Controls.Add(ID_Label);
            panel1.Controls.Add(SignUpForm_label);
            panel1.Name = "panel1";
            // 
            // ID_textbox
            // 
            resources.ApplyResources(ID_textbox, "ID_textbox");
            ID_textbox.Name = "ID_textbox";
            // 
            // radioButtonFemale
            // 
            resources.ApplyResources(radioButtonFemale, "radioButtonFemale");
            radioButtonFemale.Name = "radioButtonFemale";
            radioButtonFemale.TabStop = true;
            radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // radioButtonMale
            // 
            resources.ApplyResources(radioButtonMale, "radioButtonMale");
            radioButtonMale.Name = "radioButtonMale";
            radioButtonMale.TabStop = true;
            radioButtonMale.UseVisualStyleBackColor = true;
            radioButtonMale.CheckedChanged += radioButtonMale_CheckedChanged;
            // 
            // RePassword_textbox
            // 
            resources.ApplyResources(RePassword_textbox, "RePassword_textbox");
            RePassword_textbox.Name = "RePassword_textbox";
            // 
            // RePassword
            // 
            resources.ApplyResources(RePassword, "RePassword");
            RePassword.ForeColor = Color.FromArgb(1, 73, 175);
            RePassword.Name = "RePassword";
            // 
            // Password_textbox
            // 
            resources.ApplyResources(Password_textbox, "Password_textbox");
            Password_textbox.Name = "Password_textbox";
            // 
            // Password
            // 
            resources.ApplyResources(Password, "Password");
            Password.ForeColor = Color.FromArgb(1, 73, 175);
            Password.Name = "Password";
            // 
            // Username_textbox
            // 
            resources.ApplyResources(Username_textbox, "Username_textbox");
            Username_textbox.Name = "Username_textbox";
            // 
            // Username
            // 
            resources.ApplyResources(Username, "Username");
            Username.ForeColor = Color.FromArgb(1, 73, 175);
            Username.Name = "Username";
            // 
            // ID_Label
            // 
            resources.ApplyResources(ID_Label, "ID_Label");
            ID_Label.ForeColor = Color.FromArgb(1, 73, 175);
            ID_Label.Name = "ID_Label";
            ID_Label.Click += label1_Click_1;
            // 
            // SignUpForm_label
            // 
            resources.ApplyResources(SignUpForm_label, "SignUpForm_label");
            SignUpForm_label.ForeColor = Color.FromArgb(1, 73, 175);
            SignUpForm_label.Name = "SignUpForm_label";
            SignUpForm_label.Click += label1_Click;
            // 
            // panel2
            // 
            resources.ApplyResources(panel2, "panel2");
            panel2.BackColor = Color.FromArgb(250, 252, 252);
            panel2.Controls.Add(pictureBox1);
            panel2.Name = "panel2";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(1, 73, 175);
            resources.ApplyResources(button1, "button1");
            button1.Name = "button1";
            button1.UseVisualStyleBackColor = false;
            // 
            // SignUp
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "SignUp";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label SignUpForm_label;
        private Label ID_Label;
        private RadioButton radioButtonMale;
        private TextBox RePassword_textbox;
        private Label RePassword;
        private TextBox Password_textbox;
        private Label Password;
        private TextBox Username_textbox;
        private Label Username;
        private RadioButton radioButtonFemale;
        private TextBox ID_textbox;
        private Button button1;
    }
}
