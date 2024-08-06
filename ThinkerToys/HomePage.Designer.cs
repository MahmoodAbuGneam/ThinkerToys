
namespace ThinkerToys
{
    partial class HomePage
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
            usernameLabel = new Label();
            coinsLabel = new Label();
            logoutButton = new Button();
            mathGameButton = new Button();
            hebrewGameButton = new Button();
            englishGameButton = new Button();
            storeButton = new Button();
            profileButton = new Button();
            logoName = new PictureBox();
            coinsPictureBox = new PictureBox();
            ProfilePicture = new PictureBox();
            debugButton = new Button();
            ((System.ComponentModel.ISupportInitialize)logoName).BeginInit();
            ((System.ComponentModel.ISupportInitialize)coinsPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ProfilePicture).BeginInit();
            SuspendLayout();
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usernameLabel.Location = new Point(73, 69);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(125, 33);
            usernameLabel.TabIndex = 0;
            usernameLabel.Text = "Username";
            usernameLabel.TextAlign = ContentAlignment.TopCenter;
            usernameLabel.Click += usernameLabel_Click;
            // 
            // coinsLabel
            // 
            coinsLabel.AutoSize = true;
            coinsLabel.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            coinsLabel.Location = new Point(73, 121);
            coinsLabel.Name = "coinsLabel";
            coinsLabel.Size = new Size(74, 33);
            coinsLabel.TabIndex = 1;
            coinsLabel.Text = "Coins";
            // 
            // logoutButton
            // 
            logoutButton.Location = new Point(354, 665);
            logoutButton.Margin = new Padding(3, 4, 3, 4);
            logoutButton.Name = "logoutButton";
            logoutButton.Size = new Size(171, 67);
            logoutButton.TabIndex = 2;
            logoutButton.Text = "Logout";
            logoutButton.UseVisualStyleBackColor = true;
            logoutButton.Click += logoutButton_Click;
            // 
            // mathGameButton
            // 
            mathGameButton.Location = new Point(354, 209);
            mathGameButton.Margin = new Padding(3, 4, 3, 4);
            mathGameButton.Name = "mathGameButton";
            mathGameButton.Size = new Size(171, 67);
            mathGameButton.TabIndex = 3;
            mathGameButton.Text = "Math Game";
            mathGameButton.UseVisualStyleBackColor = true;
            mathGameButton.Click += mathGameButton_Click;
            // 
            // hebrewGameButton
            // 
            hebrewGameButton.Location = new Point(14, 209);
            hebrewGameButton.Margin = new Padding(3, 4, 3, 4);
            hebrewGameButton.Name = "hebrewGameButton";
            hebrewGameButton.Size = new Size(171, 67);
            hebrewGameButton.TabIndex = 4;
            hebrewGameButton.Text = "Hebrew Game";
            hebrewGameButton.UseVisualStyleBackColor = true;
            hebrewGameButton.Click += hebrewGameButton_Click;
            // 
            // englishGameButton
            // 
            englishGameButton.Location = new Point(711, 209);
            englishGameButton.Margin = new Padding(3, 4, 3, 4);
            englishGameButton.Name = "englishGameButton";
            englishGameButton.Size = new Size(171, 67);
            englishGameButton.TabIndex = 5;
            englishGameButton.Text = "English Game";
            englishGameButton.UseVisualStyleBackColor = true;
            englishGameButton.Click += englishGameButton_Click;
            // 
            // storeButton
            // 
            storeButton.Location = new Point(354, 579);
            storeButton.Margin = new Padding(3, 4, 3, 4);
            storeButton.Name = "storeButton";
            storeButton.Size = new Size(171, 67);
            storeButton.TabIndex = 6;
            storeButton.Text = "Store";
            storeButton.UseVisualStyleBackColor = true;
            storeButton.Click += storeButton_Click;
            // 
            // profileButton
            // 
            profileButton.Location = new Point(734, 73);
            profileButton.Margin = new Padding(3, 4, 3, 4);
            profileButton.Name = "profileButton";
            profileButton.Size = new Size(149, 51);
            profileButton.TabIndex = 7;
            profileButton.Text = "Profile";
            profileButton.UseVisualStyleBackColor = true;
            profileButton.Click += profileButton_Click;
            // 
            // logoName
            // 
            logoName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            logoName.Image = Properties.Resources.logo_name_only;
            logoName.Location = new Point(0, 0);
            logoName.Margin = new Padding(3, 4, 3, 4);
            logoName.Name = "logoName";
            logoName.Size = new Size(896, 65);
            logoName.SizeMode = PictureBoxSizeMode.CenterImage;
            logoName.TabIndex = 8;
            logoName.TabStop = false;
            logoName.Click += pictureBox1_Click;
            // 
            // coinsPictureBox
            // 
            coinsPictureBox.Image = Properties.Resources.coins_stack;
            coinsPictureBox.Location = new Point(14, 123);
            coinsPictureBox.Margin = new Padding(3, 4, 3, 4);
            coinsPictureBox.Name = "coinsPictureBox";
            coinsPictureBox.Size = new Size(31, 33);
            coinsPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            coinsPictureBox.TabIndex = 9;
            coinsPictureBox.TabStop = false;
            // 
            // ProfilePicture
            // 
            ProfilePicture.Image = Properties.Resources.profile;
            ProfilePicture.Location = new Point(6, 61);
            ProfilePicture.Margin = new Padding(3, 4, 3, 4);
            ProfilePicture.Name = "ProfilePicture";
            ProfilePicture.Size = new Size(46, 53);
            ProfilePicture.SizeMode = PictureBoxSizeMode.StretchImage;
            ProfilePicture.TabIndex = 10;
            ProfilePicture.TabStop = false;
            // 
            // debugButton
            // 
            debugButton.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold);
            debugButton.Location = new Point(14, 573);
            debugButton.Margin = new Padding(3, 4, 3, 4);
            debugButton.Name = "debugButton";
            debugButton.Size = new Size(171, 53);
            debugButton.TabIndex = 9;
            debugButton.Text = "Debug Coins";
            debugButton.UseVisualStyleBackColor = true;
            debugButton.Click += debugButton_Click;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(896, 748);
            Controls.Add(debugButton);
            Controls.Add(ProfilePicture);
            Controls.Add(coinsPictureBox);
            Controls.Add(logoName);
            Controls.Add(profileButton);
            Controls.Add(storeButton);
            Controls.Add(englishGameButton);
            Controls.Add(hebrewGameButton);
            Controls.Add(mathGameButton);
            Controls.Add(logoutButton);
            Controls.Add(coinsLabel);
            Controls.Add(usernameLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            Name = "HomePage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HomePage";
            Load += HomePage_Load;
            ((System.ComponentModel.ISupportInitialize)logoName).EndInit();
            ((System.ComponentModel.ISupportInitialize)coinsPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)ProfilePicture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label coinsLabel;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Button mathGameButton;
        private System.Windows.Forms.Button hebrewGameButton;
        private System.Windows.Forms.Button englishGameButton;
        private System.Windows.Forms.Button storeButton;
        private System.Windows.Forms.Button profileButton;
        private PictureBox logoName;
        private PictureBox coinsPictureBox;
        private PictureBox ProfilePicture;
        private Button debugButton;
    }
}
