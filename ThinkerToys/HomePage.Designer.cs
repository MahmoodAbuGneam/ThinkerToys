using System.Drawing;
using System.Windows.Forms;

namespace ThinkerToys
{
    partial class HomePage
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

        private void InitializeComponent()
        {
            mainPanel = new Panel();
            headerPanel = new Panel();
            usernameLabel = new Label();
            headerLabel = new Label();
            subHeaderLabel = new Label();
            coinsLabel = new RoundedButton();
            tableLayoutPanel = new TableLayoutPanel();
            roundedPanel1 = new RoundedPanel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            storeCard = new RoundedPanel();
            storeImage = new PictureBox();
            storeLabel = new Label();
            englishGamesCard = new RoundedPanel();
            englishGamesImage = new PictureBox();
            englishGamesLabel = new Label();
            mathGamesCard = new RoundedPanel();
            mathGamesImage = new PictureBox();
            mathGamesLabel = new Label();
            hebrewGamesCard = new RoundedPanel();
            hebrewGamesImage = new PictureBox();
            hebrewGamesLabel = new Label();
            profileCard = new RoundedPanel();
            profileImage = new PictureBox();
            profileLabel = new Label();
            mainPanel.SuspendLayout();
            headerPanel.SuspendLayout();
            tableLayoutPanel.SuspendLayout();
            roundedPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            storeCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)storeImage).BeginInit();
            englishGamesCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)englishGamesImage).BeginInit();
            mathGamesCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)mathGamesImage).BeginInit();
            hebrewGamesCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)hebrewGamesImage).BeginInit();
            profileCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)profileImage).BeginInit();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.White;
            mainPanel.Controls.Add(headerPanel);
            mainPanel.Controls.Add(tableLayoutPanel);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(0, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1213, 685);
            mainPanel.TabIndex = 0;
            // 
            // headerPanel
            // 
            headerPanel.BackColor = Color.FromArgb(50, 100, 200);
            headerPanel.Controls.Add(usernameLabel);
            headerPanel.Controls.Add(headerLabel);
            headerPanel.Controls.Add(subHeaderLabel);
            headerPanel.Controls.Add(coinsLabel);
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Location = new Point(0, 0);
            headerPanel.Name = "headerPanel";
            headerPanel.Padding = new Padding(0, 0, 0, 20);
            headerPanel.Size = new Size(1213, 180);
            headerPanel.TabIndex = 0;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            usernameLabel.ForeColor = Color.White;
            usernameLabel.Location = new Point(673, 33);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(41, 51);
            usernameLabel.TabIndex = 4;
            usernameLabel.Text = "\"";
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            headerLabel.ForeColor = Color.White;
            headerLabel.Location = new Point(193, 30);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(483, 51);
            headerLabel.TabIndex = 0;
            headerLabel.Text = "Welcome to Thinker-Toys,";
            headerLabel.Click += headerLabel_Click;
            // 
            // subHeaderLabel
            // 
            subHeaderLabel.AutoSize = true;
            subHeaderLabel.Font = new Font("Segoe UI", 16F);
            subHeaderLabel.ForeColor = Color.White;
            subHeaderLabel.Location = new Point(414, 90);
            subHeaderLabel.Name = "subHeaderLabel";
            subHeaderLabel.Size = new Size(290, 30);
            subHeaderLabel.TabIndex = 1;
            subHeaderLabel.Text = "Your gateway to fun learning";
            // 
            // coinsLabel
            // 
            coinsLabel.BackColor = Color.FromArgb(0, 120, 215);
            coinsLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            coinsLabel.ForeColor = Color.White;
            coinsLabel.Location = new Point(500, 128);
            coinsLabel.Name = "coinsLabel";
            coinsLabel.Size = new Size(150, 40);
            coinsLabel.TabIndex = 2;
            coinsLabel.Text = "Coins credit: 100";
            coinsLabel.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.ColumnCount = 3;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            tableLayoutPanel.Controls.Add(roundedPanel1, 2, 1);
            tableLayoutPanel.Controls.Add(storeCard, 0, 0);
            tableLayoutPanel.Controls.Add(englishGamesCard, 1, 0);
            tableLayoutPanel.Controls.Add(mathGamesCard, 2, 0);
            tableLayoutPanel.Controls.Add(hebrewGamesCard, 0, 1);
            tableLayoutPanel.Controls.Add(profileCard, 1, 1);
            tableLayoutPanel.Location = new Point(3, 186);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.Padding = new Padding(10);
            tableLayoutPanel.RowCount = 2;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel.Size = new Size(1208, 497);
            tableLayoutPanel.TabIndex = 1;
            // 
            // roundedPanel1
            // 
            roundedPanel1.Controls.Add(pictureBox1);
            roundedPanel1.Controls.Add(label1);
            roundedPanel1.Cursor = Cursors.Hand;
            roundedPanel1.Dock = DockStyle.Fill;
            roundedPanel1.Location = new Point(805, 251);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Padding = new Padding(5);
            roundedPanel1.Size = new Size(390, 233);
            roundedPanel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.logout;
            pictureBox1.Location = new Point(5, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(380, 193);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Bottom;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(5, 198);
            label1.Name = "label1";
            label1.Size = new Size(380, 30);
            label1.TabIndex = 1;
            label1.Text = "Log Out";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click_1;
            // 
            // storeCard
            // 
            storeCard.Controls.Add(storeImage);
            storeCard.Controls.Add(storeLabel);
            storeCard.Cursor = Cursors.Hand;
            storeCard.Dock = DockStyle.Fill;
            storeCard.Location = new Point(13, 13);
            storeCard.Name = "storeCard";
            storeCard.Padding = new Padding(5);
            storeCard.Size = new Size(390, 232);
            storeCard.TabIndex = 0;
            storeCard.Click += StoreCard_Click;
            // 
            // storeImage
            // 
            storeImage.Dock = DockStyle.Fill;
            storeImage.Image = Properties.Resources.store_icon;
            storeImage.Location = new Point(5, 5);
            storeImage.Name = "storeImage";
            storeImage.Size = new Size(380, 192);
            storeImage.SizeMode = PictureBoxSizeMode.Zoom;
            storeImage.TabIndex = 0;
            storeImage.TabStop = false;
            storeImage.Click += storeImage_Click;
            // 
            // storeLabel
            // 
            storeLabel.Dock = DockStyle.Bottom;
            storeLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            storeLabel.Location = new Point(5, 197);
            storeLabel.Name = "storeLabel";
            storeLabel.Size = new Size(380, 30);
            storeLabel.TabIndex = 1;
            storeLabel.Text = "Store";
            storeLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // englishGamesCard
            // 
            englishGamesCard.Controls.Add(englishGamesImage);
            englishGamesCard.Controls.Add(englishGamesLabel);
            englishGamesCard.Cursor = Cursors.Hand;
            englishGamesCard.Dock = DockStyle.Fill;
            englishGamesCard.Location = new Point(409, 13);
            englishGamesCard.Name = "englishGamesCard";
            englishGamesCard.Padding = new Padding(5);
            englishGamesCard.Size = new Size(390, 232);
            englishGamesCard.TabIndex = 1;
            englishGamesCard.Click += EnglishGamesCard_Click;
            // 
            // englishGamesImage
            // 
            englishGamesImage.Dock = DockStyle.Fill;
            englishGamesImage.Image = Properties.Resources.english_games_icon;
            englishGamesImage.Location = new Point(5, 5);
            englishGamesImage.Name = "englishGamesImage";
            englishGamesImage.Size = new Size(380, 192);
            englishGamesImage.SizeMode = PictureBoxSizeMode.Zoom;
            englishGamesImage.TabIndex = 0;
            englishGamesImage.TabStop = false;
            englishGamesImage.Click += englishGamesImage_Click;
            // 
            // englishGamesLabel
            // 
            englishGamesLabel.Dock = DockStyle.Bottom;
            englishGamesLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            englishGamesLabel.Location = new Point(5, 197);
            englishGamesLabel.Name = "englishGamesLabel";
            englishGamesLabel.Size = new Size(380, 30);
            englishGamesLabel.TabIndex = 1;
            englishGamesLabel.Text = "English Games";
            englishGamesLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // mathGamesCard
            // 
            mathGamesCard.Controls.Add(mathGamesImage);
            mathGamesCard.Controls.Add(mathGamesLabel);
            mathGamesCard.Cursor = Cursors.Hand;
            mathGamesCard.Dock = DockStyle.Fill;
            mathGamesCard.Location = new Point(805, 13);
            mathGamesCard.Name = "mathGamesCard";
            mathGamesCard.Padding = new Padding(5);
            mathGamesCard.Size = new Size(390, 232);
            mathGamesCard.TabIndex = 2;
            mathGamesCard.Click += MathGamesCard_Click;
            // 
            // mathGamesImage
            // 
            mathGamesImage.Dock = DockStyle.Fill;
            mathGamesImage.Image = Properties.Resources.math_games_icon;
            mathGamesImage.Location = new Point(5, 5);
            mathGamesImage.Name = "mathGamesImage";
            mathGamesImage.Size = new Size(380, 192);
            mathGamesImage.SizeMode = PictureBoxSizeMode.Zoom;
            mathGamesImage.TabIndex = 0;
            mathGamesImage.TabStop = false;
            mathGamesImage.Click += mathGamesImage_Click;
            // 
            // mathGamesLabel
            // 
            mathGamesLabel.Dock = DockStyle.Bottom;
            mathGamesLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            mathGamesLabel.Location = new Point(5, 197);
            mathGamesLabel.Name = "mathGamesLabel";
            mathGamesLabel.Size = new Size(380, 30);
            mathGamesLabel.TabIndex = 1;
            mathGamesLabel.Text = "Math Games";
            mathGamesLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // hebrewGamesCard
            // 
            hebrewGamesCard.Controls.Add(hebrewGamesImage);
            hebrewGamesCard.Controls.Add(hebrewGamesLabel);
            hebrewGamesCard.Cursor = Cursors.Hand;
            hebrewGamesCard.Dock = DockStyle.Fill;
            hebrewGamesCard.Location = new Point(13, 251);
            hebrewGamesCard.Name = "hebrewGamesCard";
            hebrewGamesCard.Padding = new Padding(5);
            hebrewGamesCard.Size = new Size(390, 233);
            hebrewGamesCard.TabIndex = 3;
            hebrewGamesCard.Click += HebrewGamesCard_Click;
            // 
            // hebrewGamesImage
            // 
            hebrewGamesImage.Dock = DockStyle.Fill;
            hebrewGamesImage.Image = Properties.Resources.hebrew_games_icon;
            hebrewGamesImage.Location = new Point(5, 5);
            hebrewGamesImage.Name = "hebrewGamesImage";
            hebrewGamesImage.Size = new Size(380, 193);
            hebrewGamesImage.SizeMode = PictureBoxSizeMode.Zoom;
            hebrewGamesImage.TabIndex = 0;
            hebrewGamesImage.TabStop = false;
            hebrewGamesImage.Click += hebrewGamesImage_Click;
            // 
            // hebrewGamesLabel
            // 
            hebrewGamesLabel.Dock = DockStyle.Bottom;
            hebrewGamesLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            hebrewGamesLabel.Location = new Point(5, 198);
            hebrewGamesLabel.Name = "hebrewGamesLabel";
            hebrewGamesLabel.Size = new Size(380, 30);
            hebrewGamesLabel.TabIndex = 1;
            hebrewGamesLabel.Text = "Hebrew Games";
            hebrewGamesLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // profileCard
            // 
            profileCard.Controls.Add(profileImage);
            profileCard.Controls.Add(profileLabel);
            profileCard.Cursor = Cursors.Hand;
            profileCard.Dock = DockStyle.Fill;
            profileCard.Location = new Point(409, 251);
            profileCard.Name = "profileCard";
            profileCard.Padding = new Padding(5);
            profileCard.Size = new Size(390, 233);
            profileCard.TabIndex = 4;
            profileCard.Click += ProfileCard_Click;
            // 
            // profileImage
            // 
            profileImage.Dock = DockStyle.Fill;
            profileImage.Image = Properties.Resources.profile_icon;
            profileImage.Location = new Point(5, 5);
            profileImage.Name = "profileImage";
            profileImage.Size = new Size(380, 193);
            profileImage.SizeMode = PictureBoxSizeMode.Zoom;
            profileImage.TabIndex = 0;
            profileImage.TabStop = false;
            profileImage.Click += profileImage_Click;
            // 
            // profileLabel
            // 
            profileLabel.Dock = DockStyle.Bottom;
            profileLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            profileLabel.Location = new Point(5, 198);
            profileLabel.Name = "profileLabel";
            profileLabel.Size = new Size(380, 30);
            profileLabel.TabIndex = 1;
            profileLabel.Text = "Show Profile";
            profileLabel.TextAlign = ContentAlignment.MiddleCenter;
            profileLabel.Click += profileLabel_Click;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1213, 685);
            Controls.Add(mainPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "HomePage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HomePage";
            Load += HomePage_Load;
            mainPanel.ResumeLayout(false);
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            tableLayoutPanel.ResumeLayout(false);
            roundedPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            storeCard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)storeImage).EndInit();
            englishGamesCard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)englishGamesImage).EndInit();
            mathGamesCard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)mathGamesImage).EndInit();
            hebrewGamesCard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)hebrewGamesImage).EndInit();
            profileCard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)profileImage).EndInit();
            ResumeLayout(false);
        }

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Label subHeaderLabel;
        private ThinkerToys.RoundedButton coinsLabel;

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;

        private ThinkerToys.RoundedPanel storeCard;
        private ThinkerToys.RoundedPanel englishGamesCard;
        private ThinkerToys.RoundedPanel mathGamesCard;
        private ThinkerToys.RoundedPanel hebrewGamesCard;
        private ThinkerToys.RoundedPanel profileCard;

        private System.Windows.Forms.PictureBox storeImage;
        private System.Windows.Forms.PictureBox englishGamesImage;
        private System.Windows.Forms.PictureBox mathGamesImage;
        private System.Windows.Forms.PictureBox hebrewGamesImage;
        private System.Windows.Forms.PictureBox profileImage;

        private System.Windows.Forms.Label storeLabel;
        private System.Windows.Forms.Label englishGamesLabel;
        private System.Windows.Forms.Label mathGamesLabel;
        private System.Windows.Forms.Label hebrewGamesLabel;
        private System.Windows.Forms.Label profileLabel;
        private Label usernameLabel;
        private RoundedPanel roundedPanel1;
        private PictureBox pictureBox1;
        private Label label1;
    }
}
