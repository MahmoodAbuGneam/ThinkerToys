using System;
using System.Drawing;
using System.Windows.Forms;

namespace ThinkerToys
{
    public partial class EnglishGame1Form : Form
    {
        int speed;
        int score;
        Random rand = new Random();
        bool gameOver;

        public EnglishGame1Form()
        {
            InitializeComponent();
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.DoubleBuffer, true);
            LoadAndSetImages();
            RestartGame();
            updateCionsEng1();
        }

        private void LoadAndSetImages()
        {
            pictureBox1.Image = MakeImageTransparent(Properties.Resources.A);
            pictureBox2.Image = MakeImageTransparent(Properties.Resources.B);
            pictureBox3.Image = MakeImageTransparent(Properties.Resources.C);
            pictureBox4.Image = MakeImageTransparent(Properties.Resources.D);
            bomb.Image = MakeImageTransparent(Properties.Resources.bomb);   
        }

        private Bitmap MakeImageTransparent(Bitmap bitmap)
        {
            Bitmap transparentBitmap = new Bitmap(bitmap);
            transparentBitmap.MakeTransparent(Color.White); // HotPink
            return transparentBitmap;
        }

        private void MainTimerEvent(object sender, EventArgs e)
        {
            txtScore.Text = "Score: " + score;

            if (gameOver == true)
            {
                gameTimer.Stop();
                txtScore.Text = "Score: " + score + " Game over, press enter to restart!";
            }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox)
                {
                    x.Top -= speed;

                    if (x.Top < -100)
                    {
                        x.Top = rand.Next(700, 1000);
                        x.Left = rand.Next(5, 500);
                    }

                    if ((string)x.Tag == "balloon")
                    {
                        if (x.Top < -50)
                        {
                            gameOver = true;
                        }

                        if (bomb.Bounds.IntersectsWith(x.Bounds))
                        {
                            x.Top = rand.Next(700, 1000);
                            x.Left = rand.Next(5, 500);
                        }
                    }
                }
            }

            if (score > 5)
            {
                speed = 8;
            }

            if (score > 15 && score < 25)
            {
                speed = 11;
            }

            if(score > 60)
            {
                speed = 20;
            }

        }

        private void updateCionsEng1()
        {
            UserSession.Instance.Coins += score;
        }

        private void PopLetter(object sender, EventArgs e)
        {
            if (gameOver == false)
            {
                var balloon = (PictureBox)sender;

                balloon.Top = rand.Next(750, 1000);
                balloon.Left = rand.Next(5, 500);

                score += 1;
            }
        }

        private void GoBoom(object sender, EventArgs e)
        {
            if (gameOver == false)
            {
                bomb.Image = Properties.Resources.boom;
                gameOver = true;
            }
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && gameOver == true)
            {
                RestartGame();
            }
        }

        private void RestartGame()
        {
            speed = 5;
            score = 0;
            gameOver = false;

            bomb.Image = Properties.Resources.bomb;

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox)
                {
                    x.Top = rand.Next(750, 1000);
                    x.Left = rand.Next(5, 500);
                }
            }

            gameTimer.Start();
        }

        private void EnglishGame1Form_Load(object sender, EventArgs e)
        {
        }
    }
}
