namespace ThinkerToys
{
    partial class StoreSectForm1
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
            panel1StoreSectForm1 = new Panel();
            StorepictureBox1 = new PictureBox();
            storeLogoutBtn = new Button();
            storeSectionlabel1 = new Label();
            storeUserImage = new PictureBox();
            storeCoinsImage = new PictureBox();
            storeCoinsValueLabel = new Label();
            stCoinsLb = new Label();
            StoreSectForm1panel1 = new Panel();
            StorePurhacedCard = new Button();
            stHomeBtn = new Button();
            stHeroessBtn = new Button();
            stToysBtn = new Button();
            stStickersBtn = new Button();
            stClothesBtn = new Button();
            storeAllItemsButton = new Button();
            Storepanel1 = new Panel();
            panel1StoreSectForm1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)StorepictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)storeUserImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)storeCoinsImage).BeginInit();
            StoreSectForm1panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1StoreSectForm1
            // 
            panel1StoreSectForm1.BackColor = SystemColors.Highlight;
            panel1StoreSectForm1.Controls.Add(StorepictureBox1);
            panel1StoreSectForm1.Controls.Add(storeLogoutBtn);
            panel1StoreSectForm1.Controls.Add(storeSectionlabel1);
            panel1StoreSectForm1.Controls.Add(storeUserImage);
            panel1StoreSectForm1.Controls.Add(storeCoinsImage);
            panel1StoreSectForm1.Controls.Add(storeCoinsValueLabel);
            panel1StoreSectForm1.Controls.Add(stCoinsLb);
            panel1StoreSectForm1.Dock = DockStyle.Top;
            panel1StoreSectForm1.Location = new Point(0, 0);
            panel1StoreSectForm1.Name = "panel1StoreSectForm1";
            panel1StoreSectForm1.Size = new Size(1344, 63);
            panel1StoreSectForm1.TabIndex = 0;
            panel1StoreSectForm1.Paint += panel1StoreSectForm1_Paint;
            // 
            // StorepictureBox1
            // 
            StorepictureBox1.BackColor = SystemColors.Highlight;
            StorepictureBox1.Image = Properties.Resources.THINKERTOYS;
            StorepictureBox1.Location = new Point(414, 2);
            StorepictureBox1.Name = "StorepictureBox1";
            StorepictureBox1.Size = new Size(616, 63);
            StorepictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            StorepictureBox1.TabIndex = 2;
            StorepictureBox1.TabStop = false;
            // 
            // storeLogoutBtn
            // 
            storeLogoutBtn.AccessibleDescription = "";
            storeLogoutBtn.AccessibleName = "";
            storeLogoutBtn.BackColor = SystemColors.Highlight;
            storeLogoutBtn.Cursor = Cursors.Hand;
            storeLogoutBtn.FlatAppearance.BorderSize = 0;
            storeLogoutBtn.FlatAppearance.MouseOverBackColor = SystemColors.Menu;
            storeLogoutBtn.FlatStyle = FlatStyle.Flat;
            storeLogoutBtn.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            storeLogoutBtn.ForeColor = SystemColors.Desktop;
            storeLogoutBtn.Image = Properties.Resources.account_logout_32__1_;
            storeLogoutBtn.Location = new Point(1223, 2);
            storeLogoutBtn.Name = "storeLogoutBtn";
            storeLogoutBtn.RightToLeft = RightToLeft.No;
            storeLogoutBtn.Size = new Size(121, 59);
            storeLogoutBtn.TabIndex = 4;
            storeLogoutBtn.Text = "   Logout";
            storeLogoutBtn.TextAlign = ContentAlignment.MiddleRight;
            storeLogoutBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
            storeLogoutBtn.UseVisualStyleBackColor = false;
            storeLogoutBtn.Click += storeLogoutBtn_Click;
            // 
            // storeSectionlabel1
            // 
            storeSectionlabel1.AutoSize = true;
            storeSectionlabel1.BackColor = SystemColors.MenuHighlight;
            storeSectionlabel1.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            storeSectionlabel1.Location = new Point(61, 22);
            storeSectionlabel1.Name = "storeSectionlabel1";
            storeSectionlabel1.Size = new Size(77, 19);
            storeSectionlabel1.TabIndex = 3;
            storeSectionlabel1.Text = "Username";
            storeSectionlabel1.Click += storeSectionlabel1_Click;
            // 
            // storeUserImage
            // 
            storeUserImage.Image = Properties.Resources.user_48;
            storeUserImage.Location = new Point(0, 2);
            storeUserImage.Name = "storeUserImage";
            storeUserImage.Size = new Size(55, 53);
            storeUserImage.SizeMode = PictureBoxSizeMode.Zoom;
            storeUserImage.TabIndex = 5;
            storeUserImage.TabStop = false;
            storeUserImage.Click += storeUserImage_Click;
            // 
            // storeCoinsImage
            // 
            storeCoinsImage.Image = Properties.Resources.video_game_star_coin;
            storeCoinsImage.Location = new Point(222, 10);
            storeCoinsImage.Name = "storeCoinsImage";
            storeCoinsImage.Size = new Size(64, 47);
            storeCoinsImage.SizeMode = PictureBoxSizeMode.Zoom;
            storeCoinsImage.TabIndex = 7;
            storeCoinsImage.TabStop = false;
            // 
            // storeCoinsValueLabel
            // 
            storeCoinsValueLabel.AutoSize = true;
            storeCoinsValueLabel.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            storeCoinsValueLabel.Location = new Point(355, 24);
            storeCoinsValueLabel.Name = "storeCoinsValueLabel";
            storeCoinsValueLabel.Size = new Size(37, 21);
            storeCoinsValueLabel.TabIndex = 8;
            storeCoinsValueLabel.Text = "100";
            // 
            // stCoinsLb
            // 
            stCoinsLb.AutoSize = true;
            stCoinsLb.BackColor = SystemColors.Highlight;
            stCoinsLb.Font = new Font("Century Gothic", 12.2F);
            stCoinsLb.Location = new Point(292, 23);
            stCoinsLb.Name = "stCoinsLb";
            stCoinsLb.Size = new Size(65, 21);
            stCoinsLb.TabIndex = 6;
            stCoinsLb.Text = "Coins :";
            // 
            // StoreSectForm1panel1
            // 
            StoreSectForm1panel1.BackColor = SystemColors.ControlLightLight;
            StoreSectForm1panel1.Controls.Add(StorePurhacedCard);
            StoreSectForm1panel1.Controls.Add(stHomeBtn);
            StoreSectForm1panel1.Controls.Add(stHeroessBtn);
            StoreSectForm1panel1.Controls.Add(stToysBtn);
            StoreSectForm1panel1.Controls.Add(stStickersBtn);
            StoreSectForm1panel1.Controls.Add(stClothesBtn);
            StoreSectForm1panel1.Controls.Add(storeAllItemsButton);
            StoreSectForm1panel1.Dock = DockStyle.Left;
            StoreSectForm1panel1.Location = new Point(0, 63);
            StoreSectForm1panel1.Name = "StoreSectForm1panel1";
            StoreSectForm1panel1.Size = new Size(209, 615);
            StoreSectForm1panel1.TabIndex = 1;
            // 
            // StorePurhacedCard
            // 
            StorePurhacedCard.Cursor = Cursors.Hand;
            StorePurhacedCard.FlatAppearance.BorderSize = 0;
            StorePurhacedCard.FlatAppearance.MouseOverBackColor = SystemColors.Menu;
            StorePurhacedCard.FlatStyle = FlatStyle.Flat;
            StorePurhacedCard.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            StorePurhacedCard.ForeColor = SystemColors.GrayText;
            StorePurhacedCard.Image = Properties.Resources.cart_43_32;
            StorePurhacedCard.Location = new Point(10, 512);
            StorePurhacedCard.Name = "StorePurhacedCard";
            StorePurhacedCard.Size = new Size(151, 59);
            StorePurhacedCard.TabIndex = 69;
            StorePurhacedCard.Text = "My purchases";
            StorePurhacedCard.TextAlign = ContentAlignment.MiddleRight;
            StorePurhacedCard.TextImageRelation = TextImageRelation.ImageBeforeText;
            StorePurhacedCard.UseVisualStyleBackColor = true;
            StorePurhacedCard.Click += StorePurhacedCard_Click;
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
            stHomeBtn.Location = new Point(10, -1);
            stHomeBtn.Name = "stHomeBtn";
            stHomeBtn.RightToLeft = RightToLeft.No;
            stHomeBtn.Size = new Size(105, 59);
            stHomeBtn.TabIndex = 3;
            stHomeBtn.Text = "   Home";
            stHomeBtn.TextAlign = ContentAlignment.MiddleRight;
            stHomeBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            stHomeBtn.UseVisualStyleBackColor = false;
            stHomeBtn.Click += stHomeBtn_Click;
            // 
            // stHeroessBtn
            // 
            stHeroessBtn.Cursor = Cursors.Hand;
            stHeroessBtn.FlatAppearance.BorderSize = 0;
            stHeroessBtn.FlatAppearance.MouseOverBackColor = SystemColors.Menu;
            stHeroessBtn.FlatStyle = FlatStyle.Flat;
            stHeroessBtn.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            stHeroessBtn.ForeColor = SystemColors.GrayText;
            stHeroessBtn.Image = Properties.Resources.batman_6_32;
            stHeroessBtn.Location = new Point(12, 370);
            stHeroessBtn.Name = "stHeroessBtn";
            stHeroessBtn.Size = new Size(104, 59);
            stHeroessBtn.TabIndex = 4;
            stHeroessBtn.Text = " Heroes";
            stHeroessBtn.TextAlign = ContentAlignment.MiddleRight;
            stHeroessBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            stHeroessBtn.UseVisualStyleBackColor = true;
            stHeroessBtn.Click += stHeroessBtn_Click;
            // 
            // stToysBtn
            // 
            stToysBtn.Cursor = Cursors.Hand;
            stToysBtn.FlatAppearance.BorderSize = 0;
            stToysBtn.FlatAppearance.MouseOverBackColor = SystemColors.Menu;
            stToysBtn.FlatStyle = FlatStyle.Flat;
            stToysBtn.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            stToysBtn.ForeColor = SystemColors.GrayText;
            stToysBtn.Image = Properties.Resources.soccer_3_32;
            stToysBtn.Location = new Point(12, 145);
            stToysBtn.Name = "stToysBtn";
            stToysBtn.Size = new Size(83, 59);
            stToysBtn.TabIndex = 7;
            stToysBtn.Text = " Toys";
            stToysBtn.TextAlign = ContentAlignment.MiddleRight;
            stToysBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            stToysBtn.UseVisualStyleBackColor = true;
            stToysBtn.Click += stToysBtn_Click;
            // 
            // stStickersBtn
            // 
            stStickersBtn.Cursor = Cursors.Hand;
            stStickersBtn.FlatAppearance.BorderSize = 0;
            stStickersBtn.FlatAppearance.MouseOverBackColor = SystemColors.Menu;
            stStickersBtn.FlatStyle = FlatStyle.Flat;
            stStickersBtn.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            stStickersBtn.ForeColor = SystemColors.GrayText;
            stStickersBtn.Image = Properties.Resources.in_love_32;
            stStickersBtn.Location = new Point(12, 220);
            stStickersBtn.Name = "stStickersBtn";
            stStickersBtn.Size = new Size(108, 59);
            stStickersBtn.TabIndex = 4;
            stStickersBtn.Text = " Stickers";
            stStickersBtn.TextAlign = ContentAlignment.MiddleRight;
            stStickersBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            stStickersBtn.UseVisualStyleBackColor = true;
            stStickersBtn.Click += stStickersBtn_Click;
            // 
            // stClothesBtn
            // 
            stClothesBtn.Cursor = Cursors.Hand;
            stClothesBtn.FlatAppearance.BorderSize = 0;
            stClothesBtn.FlatAppearance.MouseOverBackColor = SystemColors.Menu;
            stClothesBtn.FlatStyle = FlatStyle.Flat;
            stClothesBtn.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            stClothesBtn.ForeColor = SystemColors.GrayText;
            stClothesBtn.Image = Properties.Resources.polo_shirt_32;
            stClothesBtn.Location = new Point(12, 295);
            stClothesBtn.Name = "stClothesBtn";
            stClothesBtn.Size = new Size(104, 59);
            stClothesBtn.TabIndex = 5;
            stClothesBtn.Text = "Clothes";
            stClothesBtn.TextAlign = ContentAlignment.MiddleRight;
            stClothesBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            stClothesBtn.UseVisualStyleBackColor = true;
            stClothesBtn.Click += stClothesBtn_Click;
            // 
            // storeAllItemsButton
            // 
            storeAllItemsButton.Cursor = Cursors.Hand;
            storeAllItemsButton.FlatAppearance.BorderSize = 0;
            storeAllItemsButton.FlatAppearance.MouseOverBackColor = SystemColors.Menu;
            storeAllItemsButton.FlatStyle = FlatStyle.Flat;
            storeAllItemsButton.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            storeAllItemsButton.ForeColor = SystemColors.GrayText;
            storeAllItemsButton.Image = Properties.Resources.flame_32;
            storeAllItemsButton.Location = new Point(9, 70);
            storeAllItemsButton.Name = "storeAllItemsButton";
            storeAllItemsButton.Size = new Size(115, 59);
            storeAllItemsButton.TabIndex = 5;
            storeAllItemsButton.Text = " All Items";
            storeAllItemsButton.TextAlign = ContentAlignment.MiddleRight;
            storeAllItemsButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            storeAllItemsButton.UseVisualStyleBackColor = true;
            storeAllItemsButton.Click += storeAllItemsButton_Click;
            // 
            // Storepanel1
            // 
            Storepanel1.AutoScroll = true;
            Storepanel1.BackColor = SystemColors.Control;
            Storepanel1.Dock = DockStyle.Fill;
            Storepanel1.Location = new Point(209, 63);
            Storepanel1.Name = "Storepanel1";
            Storepanel1.Size = new Size(1135, 615);
            Storepanel1.TabIndex = 2;
            // 
            // StoreSectForm1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            ClientSize = new Size(1344, 678);
            Controls.Add(Storepanel1);
            Controls.Add(StoreSectForm1panel1);
            Controls.Add(panel1StoreSectForm1);
            Name = "StoreSectForm1";
            Text = "Store";
            Load += StoreSectForm1_Load;
            panel1StoreSectForm1.ResumeLayout(false);
            panel1StoreSectForm1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)StorepictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)storeUserImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)storeCoinsImage).EndInit();
            StoreSectForm1panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1StoreSectForm1;
        private System.Windows.Forms.Panel StoreSectForm1panel1;
        private System.Windows.Forms.Button stHomeBtn;
        private System.Windows.Forms.Button stHeroessBtn;
        private System.Windows.Forms.Button stToysBtn;
        private System.Windows.Forms.Button stStickersBtn;
        private System.Windows.Forms.Button stClothesBtn;
        private System.Windows.Forms.Button storeAllItemsButton;
        private System.Windows.Forms.Button StorePurhacedCard;
        private System.Windows.Forms.Panel Storepanel1;
        private System.Windows.Forms.Label stCoinsLb;
        private System.Windows.Forms.PictureBox storeCoinsImage;
        private System.Windows.Forms.Label storeCoinsValueLabel;
        private System.Windows.Forms.Label storeSectionlabel1;
        private System.Windows.Forms.PictureBox storeUserImage;
        private System.Windows.Forms.Button storeLogoutBtn;
        private PictureBox StorepictureBox1;
    }
}