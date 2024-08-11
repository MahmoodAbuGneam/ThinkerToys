using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ThinkerToys
{
    public partial class EnglishMemoryMatching : Form
    {
        List<string> letters = new List<string> { "A", "small_a", "B", "small_b", "C", "small_c", "D", "small_d", "E", "small_e", "F", "small_f" };
        string firstChoice;
        string secondChoice;
        int tries;
        List<PictureBox> pictures = new List<PictureBox>();
        PictureBox picA;
        PictureBox picB;
        int totalTime = 30;
        int countDownTime;
        bool gameOver = false;
        int coinCounter = 0;
        private int matchedPairs = 0;

        public EnglishMemoryMatching()
        {
            InitializeComponent();

            // Center the form on the screen
            this.StartPosition = FormStartPosition.CenterScreen;

            // Set up the background image
            this.BackgroundImage = Properties.Resources.MatchingGame_Background;
            this.BackgroundImageLayout = ImageLayout.Stretch;

            // Create a resize event handler
            this.Resize += new EventHandler(Form_Resize);

            LoadPictures();
            lblCoins.Text = "Coins: " + coinCounter;
        }

        private void Form_Resize(object sender, EventArgs e)
        {
            // Force the form to redraw itself, which will redraw the background
            this.Invalidate();
        }

        private void EnglishMemoryMatching_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void TimerEvent(object sender, EventArgs e)
        {
            totalTime--;
            lblTimeLeft.Text = "Time Left: " + totalTime;

            if (totalTime < 1)
            {
                GameOver("Times Up, You Lose!!");
                foreach (PictureBox x in pictures.ToList())
                {
                    if (x.Tag != null)
                    {
                        x.Image = (Image)Properties.Resources.ResourceManager.GetObject((string)x.Tag);
                    }
                }
            }
        }

        private void RestartGameEvent(object sender, EventArgs e)
        {
            RestartGame();
        }


        private void LoadPictures()
        {
            GameTimer.Start();
            int imageSize = 150; // Size of each PictureBox
            int spacing = 20; // Spacing between PictureBoxes
            int columns = 3;
            int rows = 4;

            // Calculate the total width and height of the grid
            int totalWidth = columns * imageSize + (columns - 1) * spacing;
            int totalHeight = rows * imageSize + (rows - 1) * spacing;

            // Calculate the starting positions to center the grid
            int startX = (this.ClientSize.Width - totalWidth) / 2;
            int startY = (this.ClientSize.Height - totalHeight) / 2;

            int leftPos = startX;
            int toppos = startY;
            int rowCounter = 0;

            for (int i = 0; i < 12; i++)
            {
                PictureBox newPic = new PictureBox();
                newPic.Height = imageSize;
                newPic.Width = imageSize;
                newPic.BackColor = Color.LightGoldenrodYellow;
                
                newPic.SizeMode = PictureBoxSizeMode.StretchImage;
                newPic.Click += NewPic_Click;
                pictures.Add(newPic);

                if (rowCounter < columns)
                {
                    rowCounter++;
                    newPic.Left = leftPos;
                    newPic.Top = toppos;
                    this.Controls.Add(newPic);
                    leftPos = leftPos + imageSize + spacing;
                }
                if (rowCounter == columns)
                {
                    leftPos = startX;
                    toppos += imageSize + spacing;
                    rowCounter = 0;
                }
            }
            
            RestartGame();

        }
       

        private void NewPic_Click(object sender, EventArgs e)
        {
            if (gameOver)
            {
                return;
            }
            if (firstChoice == null)
            {
                picA = sender as PictureBox;
                if (picA.Tag != null && picA.Image == null)
                {
                    picA.Image = (Image)Properties.Resources.ResourceManager.GetObject((string)picA.Tag);
                    firstChoice = (string)picA.Tag;
                }
            }
            else if (secondChoice == null)
            {
                picB = sender as PictureBox;

                if (picB.Tag != null && picB.Image == null)
                {
                    picB.Image = (Image)Properties.Resources.ResourceManager.GetObject((string)picB.Tag);
                    secondChoice = (string)picB.Tag;
                }
            }
            else
            {
                CheckPictures(picA, picB);
            }
        }

        private void RestartGame()
        {
            var randomList = letters.OrderBy(x => Guid.NewGuid()).ToList();
            letters = randomList;

            for (int i = 0; i < pictures.Count; i++)
            {
                pictures[i].Image = null;
                pictures[i].Tag = letters[i];
            }
            tries = 0;
            lblStatus.Text = "Mismatched: " + tries + " times.";
            totalTime = 30; // Reset the timer to 30 seconds
            lblTimeLeft.Text = "Time Left: " + totalTime;
            gameOver = false;
            matchedPairs = 0; // Reset matched pairs count
            firstChoice = null; // Reset first choice
            secondChoice = null; // Reset second choice
            GameTimer.Start();
            countDownTime = totalTime;
        }

        private void CheckPictures(PictureBox A, PictureBox B)
        {
            string charA = firstChoice.Substring(firstChoice.Length - 1).ToLower();
            string charB = secondChoice.Substring(secondChoice.Length - 1).ToLower();

            if (charA == charB)
            {
                A.Tag = null;
                B.Tag = null;
                matchedPairs++;
            }
            else
            {
                tries++;
                lblStatus.Text = "Mismatched " + tries + " times.";
            }
            firstChoice = null;
            secondChoice = null;

            foreach (PictureBox pics in pictures.ToList())
            {
                if (pics.Tag != null)
                {
                    pics.Image = null;
                }
            }

            if (matchedPairs == 6)
            {
                foreach (PictureBox pics in pictures.ToList())
                {
                    if (pics.Tag != null)
                    {
                        pics.Image = (Image)Properties.Resources.ResourceManager.GetObject((string)pics.Tag);
                    }
                }
                coinCounter += 50;
                updateCoinsEMMatching();
                lblCoins.Text = "Coins: " + coinCounter;
                GameOver("Great Work, You Win!!!! Click Restart to Play Again. You have earned 50 coins.");
            }
        }


        private void GameOver(string msg)
        {
            GameTimer.Stop();
            gameOver = true;
            MessageBox.Show(msg + " Click Restart to Play Again.");
        }

        private void lblTimeLeft_Click(object sender, EventArgs e)
        {
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage homePage = new HomePage();
            homePage.ShowDialog();
            this.Close();
        }

        private void updateCoinsEMMatching()
        {
            UserSession.Instance.Coins += coinCounter;
        }
    }
}
