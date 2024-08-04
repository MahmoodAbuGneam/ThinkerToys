namespace ThinkerToys
{
    partial class EnglishGame1Form
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
            components = new System.ComponentModel.Container();
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
            txtScore.Location = new Point(21, 25);
            txtScore.Margin = new Padding(5, 0, 5, 0);
            txtScore.Name = "txtScore";
            txtScore.Size = new Size(131, 33);
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
            bomb.Image = Properties.Resources.bomb;
            bomb.Location = new Point(385, 214);
            bomb.Margin = new Padding(5, 6, 5, 6);
            bomb.Name = "bomb";
            bomb.Size = new Size(238, 238);
            bomb.SizeMode = PictureBoxSizeMode.Zoom;
            bomb.TabIndex = 0;
            bomb.TabStop = false;
            bomb.Click += GoBoom;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.D;
            pictureBox4.Location = new Point(-2, 997);
            pictureBox4.Margin = new Padding(5, 6, 5, 6);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(249, 289);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 0;
            pictureBox4.TabStop = false;
            pictureBox4.Tag = "balloon";
            pictureBox4.Click += PopLetter;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.C;
            pictureBox3.Location = new Point(806, 997);
            pictureBox3.Margin = new Padding(5, 6, 5, 6);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(249, 289);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            pictureBox3.Tag = "balloon";
            pictureBox3.Click += PopLetter;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.B;
            pictureBox2.Location = new Point(778, 452);
            pictureBox2.Margin = new Padding(5, 6, 5, 6);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(249, 289);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            pictureBox2.Tag = "balloon";
            pictureBox2.Click += PopLetter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.A;
            pictureBox1.Location = new Point(28, 505);
            pictureBox1.Margin = new Padding(5, 6, 5, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(249, 289);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Tag = "balloon";
            pictureBox1.Click += PopLetter;
            // 
            // EnglishGame1Form
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleTurquoise;
            ClientSize = new Size(1056, 1272);
            Controls.Add(txtScore);
            Controls.Add(bomb);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Margin = new Padding(5, 6, 5, 6);
            Name = "EnglishGame1Form";
            Text = "Pop Letters,Avoid the Boom";
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

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox bomb;
        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.Timer gameTimer;
    }
}