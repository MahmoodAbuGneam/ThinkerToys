using System.Drawing.Text;

namespace ThinkerToys
{
    partial class EnglishGame1Form
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnglishGame1Form));
            txtScore = new Label();
            gameTimer = new System.Windows.Forms.Timer(components);
            bomb = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)bomb).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtScore
            // 
            txtScore.AutoSize = true;
            txtScore.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtScore.Location = new Point(15, 15);
            txtScore.Margin = new Padding(4, 0, 4, 0);
            txtScore.Name = "txtScore";
            txtScore.Size = new Size(88, 24);
            txtScore.TabIndex = 1;
            txtScore.Text = "Score: 0";
            // 
            // gameTimer
            // 
            gameTimer.Interval = 20;
            gameTimer.Tick += MainTimerEvent;
            // 
            // bomb
            // 
            bomb.BackColor = Color.Transparent;
            bomb.Image = Properties.Resources.bomb;
            bomb.Location = new Point(270, 128);
            bomb.Margin = new Padding(4);
            bomb.Name = "bomb";
            bomb.Size = new Size(167, 143);
            bomb.SizeMode = PictureBoxSizeMode.Zoom;
            bomb.TabIndex = 0;
            bomb.TabStop = false;
            bomb.Click += GoBoom;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(-1, 598);
            pictureBox4.Margin = new Padding(4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(174, 173);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 0;
            pictureBox4.TabStop = false;
            pictureBox4.Tag = "balloon";
            pictureBox4.Click += PopLetter;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(564, 598);
            pictureBox3.Margin = new Padding(4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(174, 173);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            pictureBox3.Tag = "balloon";
            pictureBox3.Click += PopLetter;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(545, 271);
            pictureBox2.Margin = new Padding(4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(174, 173);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            pictureBox2.Tag = "balloon";
            pictureBox2.Click += PopLetter;

            //
            // Pause Button
            //

            Button btnPause = new Button();
            btnPause.Text = "Pause";
            btnPause.Location = new Point(750, 50); // Example position
            btnPause.Click += new EventHandler(btnPause_Click);
            Controls.Add(btnPause);

            //
            // Pause Button
            //

            Button btnRestart = new Button();
            btnRestart.Text = "Restart";
            btnRestart.Location = new Point(750, 100);
            btnRestart.Click += new EventHandler(btnRestart_Click);
            Controls.Add(btnRestart);

            //
            // Pause Button
            //

            Button btnHomepage = new Button();
            btnHomepage.Text = "Homepage";
            btnHomepage.Location = new Point(750, 150);
            btnHomepage.Click += new EventHandler(btnHomepage_Click);
            Controls.Add(btnHomepage);



            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(20, 303);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(174, 173);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Tag = "balloon";
            pictureBox1.Click += PopLetter;
            // 
            // EnglishGame1Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(900, 637);
            Controls.Add(txtScore);
            Controls.Add(bomb);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Margin = new Padding(4);
            Name = "EnglishGame1Form";
            Text = "Pop Letters, Avoid the Boom";
            Load += EnglishGame1Form_Load;
            KeyUp += KeyIsUp;
            ((System.ComponentModel.ISupportInitialize)bomb).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();



        }

        #endregion
        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox bomb;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}
