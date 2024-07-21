
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
            usernameLabel.Location = new Point(64, 52);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(99, 26);
            usernameLabel.TabIndex = 0;
            usernameLabel.Text = "Username";
            usernameLabel.TextAlign = ContentAlignment.TopCenter;
            usernameLabel.Click += usernameLabel_Click;
            // 
            // coinsLabel
            // 
            coinsLabel.AutoSize = true;
            coinsLabel.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            coinsLabel.Location = new Point(64, 91);
            coinsLabel.Name = "coinsLabel";
            coinsLabel.Size = new Size(56, 26);
            coinsLabel.TabIndex = 1;
            coinsLabel.Text = "Coins";
            // 
            // logoutButton
            // 
            logoutButton.Location = new Point(310, 499);
            logoutButton.Name = "logoutButton";
            logoutButton.Size = new Size(150, 50);
            logoutButton.TabIndex = 2;
            logoutButton.Text = "Logout";
            logoutButton.UseVisualStyleBackColor = true;
            logoutButton.Click += logoutButton_Click;
            // 
            // mathGameButton
            // 
            mathGameButton.Location = new Point(310, 157);
            mathGameButton.Name = "mathGameButton";
            mathGameButton.Size = new Size(150, 50);
            mathGameButton.TabIndex = 3;
            mathGameButton.Text = "Math Game";
            mathGameButton.UseVisualStyleBackColor = true;
            mathGameButton.Click += mathGameButton_Click;
            // 
            // hebrewGameButton
            // 
            hebrewGameButton.Location = new Point(12, 157);
            hebrewGameButton.Name = "hebrewGameButton";
            hebrewGameButton.Size = new Size(150, 50);
            hebrewGameButton.TabIndex = 4;
            hebrewGameButton.Text = "Hebrew Game";
            hebrewGameButton.UseVisualStyleBackColor = true;
            hebrewGameButton.Click += hebrewGameButton_Click;
            // 
            // englishGameButton
            // 
            englishGameButton.Location = new Point(622, 157);
            englishGameButton.Name = "englishGameButton";
            englishGameButton.Size = new Size(150, 50);
            englishGameButton.TabIndex = 5;
            englishGameButton.Text = "English Game";
            englishGameButton.UseVisualStyleBackColor = true;
            englishGameButton.Click += englishGameButton_Click;
            // 
            // storeButton
            // 
            storeButton.Location = new Point(310, 434);
            storeButton.Name = "storeButton";
            storeButton.Size = new Size(150, 50);
            storeButton.TabIndex = 6;
            storeButton.Text = "Store";
            storeButton.UseVisualStyleBackColor = true;
            storeButton.Click += storeButton_Click;
            // 
            // profileButton
            // 
            profileButton.Location = new Point(642, 55);
            profileButton.Name = "profileButton";
            profileButton.Size = new Size(130, 38);
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
            logoName.Name = "logoName";
            logoName.Size = new Size(784, 49);
            logoName.SizeMode = PictureBoxSizeMode.CenterImage;
            logoName.TabIndex = 8;
            logoName.TabStop = false;
            logoName.Click += pictureBox1_Click;
            // 
            // coinsPictureBox
            // 
            coinsPictureBox.Image = Properties.Resources.coins_stack;
            coinsPictureBox.Location = new Point(12, 92);
            coinsPictureBox.Name = "coinsPictureBox";
            coinsPictureBox.Size = new Size(27, 25);
            coinsPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            coinsPictureBox.TabIndex = 9;
            coinsPictureBox.TabStop = false;
            // 
            // ProfilePicture
            // 
            ProfilePicture.Image = Properties.Resources.profile;
            ProfilePicture.Location = new Point(5, 46);
            ProfilePicture.Name = "ProfilePicture";
            ProfilePicture.Size = new Size(40, 40);
            ProfilePicture.SizeMode = PictureBoxSizeMode.StretchImage;
            ProfilePicture.TabIndex = 10;
            ProfilePicture.TabStop = false;
            // 
            // debugButton
            // 
            debugButton.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold);
            debugButton.Location = new Point(12, 430);
            debugButton.Name = "debugButton";
            debugButton.Size = new Size(150, 40);
            debugButton.TabIndex = 9;
            debugButton.Text = "Debug Coins";
            debugButton.UseVisualStyleBackColor = true;
            debugButton.Click += debugButton_Click;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
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
