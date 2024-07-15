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
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            LoginLabel = new Label();
            panel1 = new Panel();
            showPassCheckBox = new CheckBox();
            SignUpLabel = new Label();
            PasswordLabel = new Label();
            CreateAccountLabel = new Label();
            UsernameLabel = new Label();
            PasswordTextBox = new TextBox();
            UsernameTextBox = new TextBox();
            kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.toys_and_kid_s_fashion__1__removebg_preview;
            pictureBox1.Location = new Point(-56, -11);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(425, 415);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(showPassCheckBox);
            panel2.Controls.Add(SignUpLabel);
            panel2.Controls.Add(PasswordLabel);
            panel2.Controls.Add(CreateAccountLabel);
            panel2.Controls.Add(UsernameLabel);
            panel2.Controls.Add(PasswordTextBox);
            panel2.Controls.Add(UsernameTextBox);
            panel2.Controls.Add(kryptonButton1);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(LoginLabel);
            panel2.Location = new Point(10, 9);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(368, 437);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.Green;
            label9.Location = new Point(3, 250);
            label9.Name = "label9";
            label9.Size = new Size(0, 15);
            label9.TabIndex = 29;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.Red;
            label8.Location = new Point(3, 179);
            label8.Name = "label8";
            label8.Size = new Size(0, 15);
            label8.TabIndex = 28;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.Control;
            label7.ForeColor = Color.Red;
            label7.Location = new Point(3, 116);
            label7.Name = "label7";
            label7.Size = new Size(0, 15);
            label7.TabIndex = 27;
            label7.Click += label7_Click;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.ForeColor = Color.CadetBlue;
            label6.Location = new Point(122, 528);
            label6.Name = "label6";
            label6.Size = new Size(127, 15);
            label6.TabIndex = 22;
            label6.Text = "Dont Have an Account";
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
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(383, 9);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(385, 437);
            panel1.TabIndex = 0;
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
            // 
            // SignUpLabel
            // 
            SignUpLabel.AutoSize = true;
            SignUpLabel.Font = new Font("Microsoft Tai Le", 7.8F);
            SignUpLabel.ForeColor = Color.Red;
            SignUpLabel.Location = new Point(119, 360);
            SignUpLabel.Name = "SignUpLabel";
            SignUpLabel.Size = new Size(71, 14);
            SignUpLabel.TabIndex = 36;
            SignUpLabel.Text = "Signup Here";
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
            CreateAccountLabel.Click += label3_Click;
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
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PasswordTextBox.ForeColor = Color.Navy;
            PasswordTextBox.Location = new Point(67, 190);
            PasswordTextBox.Margin = new Padding(3, 2, 3, 2);
            PasswordTextBox.Multiline = true;
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(213, 21);
            PasswordTextBox.TabIndex = 33;
            PasswordTextBox.UseWaitCursor = true;
            // 
            // UsernameTextBox
            // 
            UsernameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            UsernameTextBox.ForeColor = Color.Navy;
            UsernameTextBox.Location = new Point(67, 116);
            UsernameTextBox.Margin = new Padding(3, 2, 3, 2);
            UsernameTextBox.Multiline = true;
            UsernameTextBox.Name = "UsernameTextBox";
            UsernameTextBox.Size = new Size(213, 21);
            UsernameTextBox.TabIndex = 30;
            UsernameTextBox.UseWaitCursor = true;
            // 
            // kryptonButton1
            // 
            kryptonButton1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            kryptonButton1.Location = new Point(67, 272);
            kryptonButton1.Margin = new Padding(3, 2, 3, 2);
            kryptonButton1.Name = "kryptonButton1";
            kryptonButton1.OverrideDefault.Back.Color1 = Color.FromArgb(1, 73, 175);
            kryptonButton1.OverrideDefault.Back.Color2 = Color.FromArgb(1, 73, 175);
            kryptonButton1.OverrideDefault.Back.ColorAngle = 45F;
            kryptonButton1.OverrideDefault.Border.Color1 = Color.FromArgb(1, 73, 175);
            kryptonButton1.OverrideDefault.Border.Color2 = Color.FromArgb(1, 73, 175);
            kryptonButton1.OverrideDefault.Border.ColorAngle = 45F;
            kryptonButton1.OverrideDefault.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonButton1.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonButton1.OverrideDefault.Border.Rounding = 20;
            kryptonButton1.OverrideDefault.Border.Width = 1;
            kryptonButton1.OverrideFocus.Back.Color1 = Color.FromArgb(1, 73, 175);
            kryptonButton1.OverrideFocus.Back.Color2 = Color.FromArgb(1, 73, 175);
            kryptonButton1.OverrideFocus.Back.ColorAngle = 45F;
            kryptonButton1.OverrideFocus.Border.ColorAngle = 45F;
            kryptonButton1.OverrideFocus.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonButton1.OverrideFocus.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonButton1.OverrideFocus.Border.Rounding = 100;
            kryptonButton1.OverrideFocus.Border.Width = 1;
            kryptonButton1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            kryptonButton1.Size = new Size(200, 38);
            kryptonButton1.StateCommon.Back.Color1 = Color.FromArgb(1, 73, 175);
            kryptonButton1.StateCommon.Back.Color2 = Color.FromArgb(1, 73, 175);
            kryptonButton1.StateCommon.Back.ColorAngle = 45F;
            kryptonButton1.StateCommon.Border.Color1 = Color.FromArgb(1, 73, 175);
            kryptonButton1.StateCommon.Border.Color2 = Color.FromArgb(1, 73, 175);
            kryptonButton1.StateCommon.Border.ColorAngle = 45F;
            kryptonButton1.StateCommon.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonButton1.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonButton1.StateCommon.Border.Rounding = 20;
            kryptonButton1.StateCommon.Border.Width = 1;
            kryptonButton1.StateCommon.Content.ShortText.Color1 = Color.White;
            kryptonButton1.StateCommon.Content.ShortText.Color2 = Color.White;
            kryptonButton1.StateCommon.Content.ShortText.Font = new Font("Microsoft Tai Le", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonButton1.StatePressed.Back.Color1 = Color.FromArgb(1, 73, 175);
            kryptonButton1.StatePressed.Back.Color2 = Color.FromArgb(1, 73, 175);
            kryptonButton1.StatePressed.Back.ColorAngle = 135F;
            kryptonButton1.StatePressed.Border.Color1 = Color.FromArgb(1, 73, 175);
            kryptonButton1.StatePressed.Border.Color2 = Color.FromArgb(1, 73, 175);
            kryptonButton1.StatePressed.Border.ColorAngle = 135F;
            kryptonButton1.StatePressed.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonButton1.StatePressed.Border.Rounding = 20;
            kryptonButton1.StatePressed.Border.Width = 1;
            kryptonButton1.StateTracking.Back.Color1 = Color.FromArgb(1, 73, 175);
            kryptonButton1.StateTracking.Back.Color2 = Color.FromArgb(1, 73, 175);
            kryptonButton1.StateTracking.Back.ColorAngle = 45F;
            kryptonButton1.StateTracking.Border.Color1 = Color.FromArgb(1, 73, 175);
            kryptonButton1.StateTracking.Border.Color2 = Color.FromArgb(1, 73, 175);
            kryptonButton1.StateTracking.Border.ColorAngle = 45F;
            kryptonButton1.StateTracking.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonButton1.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonButton1.StateTracking.Border.Rounding = 20;
            kryptonButton1.StateTracking.Border.Width = 1;
            kryptonButton1.TabIndex = 32;
            kryptonButton1.Values.Text = "awd";
            kryptonButton1.Click += kryptonButton1_Click_1;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(780, 457);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox1;
        private Panel panel2;
        private Label LoginLabel;
        private Label label6;
        private Label label7;
        private Label label9;
        private Label label8;
        private Panel panel1;
        private CheckBox showPassCheckBox;
        private Label SignUpLabel;
        private Label PasswordLabel;
        private Label CreateAccountLabel;
        private Label UsernameLabel;
        private TextBox PasswordTextBox;
        private TextBox UsernameTextBox;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
    }
}