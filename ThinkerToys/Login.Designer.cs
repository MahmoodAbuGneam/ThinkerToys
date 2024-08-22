namespace ThinkerToys
{
    partial class Login
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
            LeftSidePanel = new Panel();
            LoginButton = new Button();
            showPassCheckBox = new CheckBox();
            SignUpLabel = new Label();
            PasswordLabel = new Label();
            CreateAccountLabel = new Label();
            UsernameLabel = new Label();
            PasswordTextBox = new TextBox();
            UsernameTextBox = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            LoginLabel = new Label();
            LogoBackPanel = new Panel();
            LogoPicture = new PictureBox();
            LeftSidePanel.SuspendLayout();
            LogoBackPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)LogoPicture).BeginInit();
            SuspendLayout();
            // 
            // LeftSidePanel
            // 
            LeftSidePanel.Controls.Add(LoginButton);
            LeftSidePanel.Controls.Add(showPassCheckBox);
            LeftSidePanel.Controls.Add(SignUpLabel);
            LeftSidePanel.Controls.Add(PasswordLabel);
            LeftSidePanel.Controls.Add(CreateAccountLabel);
            LeftSidePanel.Controls.Add(UsernameLabel);
            LeftSidePanel.Controls.Add(PasswordTextBox);
            LeftSidePanel.Controls.Add(UsernameTextBox);
            LeftSidePanel.Controls.Add(label9);
            LeftSidePanel.Controls.Add(label8);
            LeftSidePanel.Controls.Add(label7);
            LeftSidePanel.Controls.Add(label6);
            LeftSidePanel.Controls.Add(LoginLabel);
            LeftSidePanel.Location = new Point(10, 9);
            LeftSidePanel.Margin = new Padding(3, 2, 3, 2);
            LeftSidePanel.Name = "LeftSidePanel";
            LeftSidePanel.Size = new Size(368, 437);
            LeftSidePanel.TabIndex = 1;
            LeftSidePanel.Paint += LeftPanel_Paint;
            // 
            // LoginButton
            // 
            LoginButton.Location = new Point(96, 259);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(147, 40);
            LoginButton.TabIndex = 2;
            LoginButton.Text = "LOGIN";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += LoginButton_Click;
            // 
            // showPassCheckBox
            // 
            showPassCheckBox.AutoSize = true;
            showPassCheckBox.Location = new Point(67, 215);
            showPassCheckBox.Margin = new Padding(3, 2, 3, 2);
            showPassCheckBox.Name = "showPassCheckBox";
            showPassCheckBox.Size = new Size(108, 19);
            showPassCheckBox.TabIndex = 37;
            showPassCheckBox.Text = "Show Password";
            showPassCheckBox.UseVisualStyleBackColor = true;
            showPassCheckBox.CheckedChanged += showPassCheckBox_CheckedChanged;
            // 
            // SignUpLabel
            // 
            SignUpLabel.AutoSize = true;
            SignUpLabel.Font = new Font("Microsoft Tai Le", 7.8F);
            SignUpLabel.ForeColor = Color.Red;
            SignUpLabel.Location = new Point(131, 359);
            SignUpLabel.Name = "SignUpLabel";
            SignUpLabel.Size = new Size(71, 14);
            SignUpLabel.TabIndex = 36;
            SignUpLabel.Text = "Signup Here";
            SignUpLabel.Click += SignUpLabel_Click;
            // 
            // PasswordLabel
            // 
            PasswordLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PasswordLabel.AutoSize = true;
            PasswordLabel.Font = new Font("Microsoft Tai Le", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PasswordLabel.ForeColor = Color.Navy;
            PasswordLabel.Location = new Point(67, 166);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(86, 23);
            PasswordLabel.TabIndex = 31;
            PasswordLabel.Text = "Password";
            PasswordLabel.Click += PasswordLabel_Click;
            // 
            // CreateAccountLabel
            // 
            CreateAccountLabel.AutoSize = true;
            CreateAccountLabel.BackColor = SystemColors.Control;
            CreateAccountLabel.Cursor = Cursors.No;
            CreateAccountLabel.Font = new Font("Microsoft Tai Le", 7.8F);
            CreateAccountLabel.ForeColor = Color.Navy;
            CreateAccountLabel.Location = new Point(105, 330);
            CreateAccountLabel.Name = "CreateAccountLabel";
            CreateAccountLabel.Size = new Size(128, 14);
            CreateAccountLabel.TabIndex = 34;
            CreateAccountLabel.Text = "Dont have an account ?";
            CreateAccountLabel.Click += CreateAccountLabel_Click;
            // 
            // UsernameLabel
            // 
            UsernameLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            UsernameLabel.AutoSize = true;
            UsernameLabel.Font = new Font("Microsoft Tai Le", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UsernameLabel.ForeColor = Color.Navy;
            UsernameLabel.Location = new Point(67, 91);
            UsernameLabel.Name = "UsernameLabel";
            UsernameLabel.Size = new Size(89, 23);
            UsernameLabel.TabIndex = 35;
            UsernameLabel.Text = "Username";
            UsernameLabel.Click += UsernameLabel_Click;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PasswordTextBox.ForeColor = Color.Navy;
            PasswordTextBox.Location = new Point(67, 190);
            PasswordTextBox.Margin = new Padding(3, 2, 3, 2);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.PasswordChar = '•';
            PasswordTextBox.Size = new Size(213, 23);
            PasswordTextBox.TabIndex = 33;
            PasswordTextBox.TextChanged += PasswordTextBox_TextChanged;
            // 
            // UsernameTextBox
            // 
            UsernameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            UsernameTextBox.ForeColor = Color.Navy;
            UsernameTextBox.Location = new Point(67, 116);
            UsernameTextBox.Margin = new Padding(3, 2, 3, 2);
            UsernameTextBox.Name = "UsernameTextBox";
            UsernameTextBox.Size = new Size(213, 23);
            UsernameTextBox.TabIndex = 30;
            UsernameTextBox.TextChanged += UsernameTextBox_TextChanged;
            // 
            // label9
            // 
            label9.Location = new Point(0, 0);
            label9.Name = "label9";
            label9.Size = new Size(100, 23);
            label9.TabIndex = 38;
            // 
            // label8
            // 
            label8.Location = new Point(0, 0);
            label8.Name = "label8";
            label8.Size = new Size(100, 23);
            label8.TabIndex = 39;
            // 
            // label7
            // 
            label7.Location = new Point(0, 0);
            label7.Name = "label7";
            label7.Size = new Size(100, 23);
            label7.TabIndex = 40;
            // 
            // label6
            // 
            label6.Location = new Point(0, 0);
            label6.Name = "label6";
            label6.Size = new Size(100, 23);
            label6.TabIndex = 41;
            // 
            // LoginLabel
            // 
            LoginLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LoginLabel.AutoSize = true;
            LoginLabel.Font = new Font("Microsoft Tai Le", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoginLabel.ForeColor = Color.Navy;
            LoginLabel.Location = new Point(29, 32);
            LoginLabel.Name = "LoginLabel";
            LoginLabel.Size = new Size(73, 26);
            LoginLabel.TabIndex = 12;
            LoginLabel.Text = "LOGIN";
            LoginLabel.Click += LoginLabel_Click;
            // 
            // LogoBackPanel
            // 
            LogoBackPanel.Controls.Add(LogoPicture);
            LogoBackPanel.Location = new Point(383, 9);
            LogoBackPanel.Margin = new Padding(3, 2, 3, 2);
            LogoBackPanel.Name = "LogoBackPanel";
            LogoBackPanel.Size = new Size(385, 437);
            LogoBackPanel.TabIndex = 0;
            // 
            // LogoPicture
            // 
            LogoPicture.Image = Properties.Resources.toys_and_kid_s_fashion__1__removebg_preview;
            LogoPicture.Location = new Point(-56, -11);
            LogoPicture.Margin = new Padding(3, 2, 3, 2);
            LogoPicture.Name = "LogoPicture";
            LogoPicture.Size = new Size(425, 415);
            LogoPicture.TabIndex = 0;
            LogoPicture.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(780, 457);
            Controls.Add(LeftSidePanel);
            Controls.Add(LogoBackPanel);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            LeftSidePanel.ResumeLayout(false);
            LeftSidePanel.PerformLayout();
            LogoBackPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)LogoPicture).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel LeftSidePanel;
        private Label LoginLabel;
        private Label label6;
        private Label label7;
        private Label label9;
        private Label label8;
        private Panel LogoBackPanel;
        private CheckBox showPassCheckBox;
        private Label SignUpLabel;
        private Label PasswordLabel;
        private Label CreateAccountLabel;
        private Label UsernameLabel;
        private TextBox PasswordTextBox;
        private TextBox UsernameTextBox;
        private Button LoginButton;
        private PictureBox LogoPicture;
    }
}