using System;
using System.Drawing;
using System.Windows.Forms;

namespace ThinkerToys
{
    partial class EnglishGamesTogether
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
            headerPanel = new Panel();
            headerLabel = new Label();
            subHeaderLabel = new Label();
            gameCard1 = new Panel();
            gameButton1 = new Button();
            gameLabel1 = new Label();
            gameImage1 = new PictureBox();
            gameCategoryLabel1 = new Label();
            gameCard2 = new Panel();
            gameButton2 = new Button();
            gameLabel2 = new Label();
            gameImage2 = new PictureBox();
            gameCategoryLabel2 = new Label();
            button2 = new Button();
            button1 = new Button();
            stHomeBtn = new Button();
            button3 = new Button();
            headerPanel.SuspendLayout();
            gameCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gameImage1).BeginInit();
            gameCard2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gameImage2).BeginInit();
            SuspendLayout();
            // 
            // headerPanel
            // 
            headerPanel.BackColor = Color.FromArgb(50, 100, 200);
            headerPanel.Controls.Add(headerLabel);
            headerPanel.Controls.Add(subHeaderLabel);
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Location = new Point(0, 0);
            headerPanel.Margin = new Padding(2);
            headerPanel.Name = "headerPanel";
            headerPanel.Padding = new Padding(0, 0, 0, 20);
            headerPanel.Size = new Size(1404, 180);
            headerPanel.TabIndex = 1;
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            headerLabel.ForeColor = Color.White;
            headerLabel.Location = new Point(507, 37);
            headerLabel.Margin = new Padding(2, 0, 2, 0);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(394, 51);
            headerLabel.TabIndex = 0;
            headerLabel.Text = "English Games Menu";
            // 
            // subHeaderLabel
            // 
            subHeaderLabel.AutoSize = true;
            subHeaderLabel.Font = new Font("Segoe UI", 16F);
            subHeaderLabel.ForeColor = Color.White;
            subHeaderLabel.Location = new Point(541, 126);
            subHeaderLabel.Margin = new Padding(2, 0, 2, 0);
            subHeaderLabel.Name = "subHeaderLabel";
            subHeaderLabel.Size = new Size(340, 30);
            subHeaderLabel.TabIndex = 1;
            subHeaderLabel.Text = "Learn English by playing fun gams";
            // 
            // gameCard1
            // 
            gameCard1.BackColor = Color.White;
            gameCard1.Controls.Add(gameButton1);
            gameCard1.Controls.Add(gameLabel1);
            gameCard1.Controls.Add(gameImage1);
            gameCard1.Controls.Add(gameCategoryLabel1);
            gameCard1.Location = new Point(313, 382);
            gameCard1.Margin = new Padding(2);
            gameCard1.Name = "gameCard1";
            gameCard1.Size = new Size(262, 403);
            gameCard1.TabIndex = 16;
            // 
            // gameButton1
            // 
            gameButton1.BackColor = Color.FromArgb(32, 148, 243);
            gameButton1.Cursor = Cursors.Hand;
            gameButton1.FlatAppearance.BorderSize = 0;
            gameButton1.FlatStyle = FlatStyle.Flat;
            gameButton1.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold);
            gameButton1.ForeColor = Color.White;
            gameButton1.Location = new Point(0, 357);
            gameButton1.Margin = new Padding(2);
            gameButton1.Name = "gameButton1";
            gameButton1.Size = new Size(262, 47);
            gameButton1.TabIndex = 0;
            gameButton1.Text = "Start";
            gameButton1.UseVisualStyleBackColor = false;
            gameButton1.Click += gameButton1_Click_1;
            // 
            // gameLabel1
            // 
            gameLabel1.AutoSize = true;
            gameLabel1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gameLabel1.Location = new Point(22, 234);
            gameLabel1.Margin = new Padding(2, 0, 2, 0);
            gameLabel1.Name = "gameLabel1";
            gameLabel1.Size = new Size(133, 19);
            gameLabel1.TabIndex = 1;
            gameLabel1.Text = "Matching Letters";
            // 
            // gameImage1
            // 
            gameImage1.Image = Properties.Resources.Matching_Letters_Large;
            gameImage1.Location = new Point(0, 0);
            gameImage1.Margin = new Padding(2);
            gameImage1.Name = "gameImage1";
            gameImage1.Size = new Size(262, 234);
            gameImage1.SizeMode = PictureBoxSizeMode.Zoom;
            gameImage1.TabIndex = 2;
            gameImage1.TabStop = false;
            gameImage1.Click += gameImage1_Click;
            // 
            // gameCategoryLabel1
            // 
            gameCategoryLabel1.AutoSize = true;
            gameCategoryLabel1.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gameCategoryLabel1.ForeColor = SystemColors.GrayText;
            gameCategoryLabel1.Location = new Point(22, 272);
            gameCategoryLabel1.Margin = new Padding(2, 0, 2, 0);
            gameCategoryLabel1.Name = "gameCategoryLabel1";
            gameCategoryLabel1.Size = new Size(103, 19);
            gameCategoryLabel1.TabIndex = 3;
            gameCategoryLabel1.Text = "English Game";
            // 
            // gameCard2
            // 
            gameCard2.BackColor = Color.White;
            gameCard2.Controls.Add(gameButton2);
            gameCard2.Controls.Add(gameLabel2);
            gameCard2.Controls.Add(gameImage2);
            gameCard2.Controls.Add(gameCategoryLabel2);
            gameCard2.Location = new Point(579, 382);
            gameCard2.Margin = new Padding(2);
            gameCard2.Name = "gameCard2";
            gameCard2.Size = new Size(264, 403);
            gameCard2.TabIndex = 17;
            // 
            // gameButton2
            // 
            gameButton2.BackColor = Color.FromArgb(32, 148, 243);
            gameButton2.Cursor = Cursors.Hand;
            gameButton2.FlatAppearance.BorderSize = 0;
            gameButton2.FlatStyle = FlatStyle.Flat;
            gameButton2.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold);
            gameButton2.ForeColor = Color.White;
            gameButton2.Location = new Point(0, 357);
            gameButton2.Margin = new Padding(2);
            gameButton2.Name = "gameButton2";
            gameButton2.Size = new Size(262, 47);
            gameButton2.TabIndex = 0;
            gameButton2.Text = "Start";
            gameButton2.UseVisualStyleBackColor = false;
            gameButton2.Click += gameButton2_Click_1;
            // 
            // gameLabel2
            // 
            gameLabel2.AutoSize = true;
            gameLabel2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gameLabel2.Location = new Point(22, 234);
            gameLabel2.Margin = new Padding(2, 0, 2, 0);
            gameLabel2.Name = "gameLabel2";
            gameLabel2.Size = new Size(117, 19);
            gameLabel2.TabIndex = 1;
            gameLabel2.Text = "Pop the Letters";
            // 
            // gameImage2
            // 
            gameImage2.Image = Properties.Resources.Pop_the_Letters_Large;
            gameImage2.Location = new Point(0, 0);
            gameImage2.Margin = new Padding(2);
            gameImage2.Name = "gameImage2";
            gameImage2.Size = new Size(264, 234);
            gameImage2.SizeMode = PictureBoxSizeMode.Zoom;
            gameImage2.TabIndex = 2;
            gameImage2.TabStop = false;
            // 
            // gameCategoryLabel2
            // 
            gameCategoryLabel2.AutoSize = true;
            gameCategoryLabel2.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gameCategoryLabel2.ForeColor = SystemColors.GrayText;
            gameCategoryLabel2.Location = new Point(22, 272);
            gameCategoryLabel2.Margin = new Padding(2, 0, 2, 0);
            gameCategoryLabel2.Name = "gameCategoryLabel2";
            gameCategoryLabel2.Size = new Size(103, 19);
            gameCategoryLabel2.TabIndex = 3;
            gameCategoryLabel2.Text = "English Game";
            // 
            // button2
            // 
            button2.AccessibleDescription = "";
            button2.AccessibleName = "";
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseOverBackColor = SystemColors.Menu;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.GrayText;
            button2.Image = Properties.Resources.coin__1_;
            button2.Location = new Point(274, 186);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.RightToLeft = RightToLeft.No;
            button2.Size = new Size(239, 59);
            button2.TabIndex = 22;
            button2.Text = "   100";
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.AccessibleDescription = "";
            button1.AccessibleName = "";
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = SystemColors.Menu;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.GrayText;
            button1.Image = Properties.Resources.cart_43_32;
            button1.Location = new Point(762, 186);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.RightToLeft = RightToLeft.No;
            button1.Size = new Size(239, 59);
            button1.TabIndex = 19;
            button1.Text = "   Store";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // stHomeBtn
            // 
            stHomeBtn.AccessibleDescription = "";
            stHomeBtn.AccessibleName = "";
            stHomeBtn.Cursor = Cursors.Hand;
            stHomeBtn.FlatAppearance.BorderSize = 0;
            stHomeBtn.FlatAppearance.MouseOverBackColor = SystemColors.Menu;
            stHomeBtn.FlatStyle = FlatStyle.Flat;
            stHomeBtn.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            stHomeBtn.ForeColor = SystemColors.GrayText;
            stHomeBtn.Image = Properties.Resources.home_7_32;
            stHomeBtn.Location = new Point(518, 186);
            stHomeBtn.Margin = new Padding(2);
            stHomeBtn.Name = "stHomeBtn";
            stHomeBtn.RightToLeft = RightToLeft.No;
            stHomeBtn.Size = new Size(239, 59);
            stHomeBtn.TabIndex = 18;
            stHomeBtn.Text = "   Home";
            stHomeBtn.TextAlign = ContentAlignment.MiddleRight;
            stHomeBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            stHomeBtn.UseVisualStyleBackColor = false;
            stHomeBtn.Click += stHomeBtn_Click;
            // 
            // button3
            // 
            button3.AccessibleDescription = "";
            button3.AccessibleName = "";
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseOverBackColor = SystemColors.Menu;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.GrayText;
            button3.Image = Properties.Resources.account_logout_32;
            button3.Location = new Point(1006, 186);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.RightToLeft = RightToLeft.No;
            button3.Size = new Size(239, 59);
            button3.TabIndex = 23;
            button3.Text = "   Logout";
            button3.TextAlign = ContentAlignment.MiddleRight;
            button3.TextImageRelation = TextImageRelation.ImageBeforeText;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // EnglishGamesTogether
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1404, 813);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(stHomeBtn);
            Controls.Add(gameCard1);
            Controls.Add(gameCard2);
            Controls.Add(headerPanel);
            Margin = new Padding(2);
            Name = "EnglishGamesTogether";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Toy Store";
            Load += Form1_Load_1;
            SizeChanged += Form1_SizeChanged;
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            gameCard1.ResumeLayout(false);
            gameCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gameImage1).EndInit();
            gameCard2.ResumeLayout(false);
            gameCard2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gameImage2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel headerPanel;
        private Label headerLabel;
        private Label subHeaderLabel;
        private Button button1;
        private Button stHomeBtn;
        private Panel gameCard1;
        private Button gameButton1;
        private Label gameLabel1;
        private PictureBox gameImage1;
        private Label gameCategoryLabel1;
        private Panel gameCard2;
        private Button gameButton2;
        private Label gameLabel2;
        private PictureBox gameImage2;
        private Label gameCategoryLabel2;
        private Button button2;
        private Button button3;
    }
}