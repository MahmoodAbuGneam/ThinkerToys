using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using Timer = System.Windows.Forms.Timer;

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
            LoadPictures();
            lblCoins.Text = "Coins: " + coinCounter;
            updateCoinsEMMatching();
        }

        private void Form1_Load(object sender, EventArgs e)
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
            Debug.WriteLine("Restarting Game !");
            GameTimer.Stop();
            RestartGame();
        }

        private void LoadPictures()
        {
            GameTimer.Start();
            int leftPos = 20;
            int toppos = 20;
            int rows = 0;
            int imageSize = 150; // Updated size
            int spacing = 20; // Updated spacing

            for (int i = 0; i < 12; i++)
            {
                PictureBox newPic = new PictureBox();
                newPic.Height = imageSize;
                newPic.Width = imageSize;
                newPic.BackColor = Color.LightGray;
                newPic.SizeMode = PictureBoxSizeMode.StretchImage;
                newPic.Click += NewPic_Click;
                pictures.Add(newPic);

                if (rows < 3)
                {
                    rows++;
                    newPic.Left = leftPos;
                    newPic.Top = toppos;
                    this.Controls.Add(newPic);
                    leftPos = leftPos + imageSize + spacing;
                }
                if (rows == 3)
                {
                    leftPos = 20;
                    toppos += imageSize + spacing;
                    rows = 0;
                }
            }

            RestartGame();
        }

        private void NewPic_Click(object sender, EventArgs e)
        {
            if (gameOver)
            {
                Debug.WriteLine("Game is over, ignoring click");
                return;
            }
            if (firstChoice == null)
            {
                picA = sender as PictureBox;
                if (picA.Tag != null && picA.Image == null)
                {
                    picA.Image = (Image)Properties.Resources.ResourceManager.GetObject((string)picA.Tag);
                    firstChoice = (string)picA.Tag;
                    Debug.WriteLine($"First choice: {firstChoice}");
                }
            }
            else if (secondChoice == null)
            {
                picB = sender as PictureBox;

                if (picB.Tag != null && picB.Image == null)
                {
                    picB.Image = (Image)Properties.Resources.ResourceManager.GetObject((string)picB.Tag);
                    secondChoice = (string)picB.Tag;
                    Debug.WriteLine($"Second choice: {secondChoice}");

                    // Check pictures immediately after second choice is made
                    CheckPictures(picA, picB);
                }
            }
        }

        private void updateCoinsEMMatching()
        {
            UserSession.Instance.Coins += coinCounter;
        }

        private void RestartGame()
        {
            Debug.WriteLine("Restarting game");
            gameOver = false; // Reset the game over flag
            var randomList = letters.OrderBy(x => Guid.NewGuid()).ToList();
            letters = randomList;

            for (int i = 0; i < pictures.Count; i++)
            {
                pictures[i].Image = null;
                pictures[i].Tag = letters[i];
                pictures[i].Enabled = true;  // Re-enable all PictureBoxes
            }
            tries = 0;
            lblStatus.Text = "Mismatched: " + tries + " times.";
            totalTime = 30; // Reset the timer to 30 seconds
            lblTimeLeft.Text = "Time Left: " + totalTime;
            matchedPairs = 0; // Reset matched pairs count
            firstChoice = null; // Reset first choice
            secondChoice = null; // Reset second choice
            GameTimer.Start();
            countDownTime = totalTime;

            // Reset coin counter if needed (you may want to keep the accumulated coins)
            // coinCounter = 0;
            lblCoins.Text = "Coins: " + coinCounter;

            Debug.WriteLine("Game restarted successfully");
        }



        private void CheckPictures(PictureBox A, PictureBox B)
        {
            string charA = firstChoice.Substring(firstChoice.Length - 1).ToLower();
            string charB = secondChoice.Substring(secondChoice.Length - 1).ToLower();

            Debug.WriteLine($"Comparing: {charA} and {charB}");

            if (charA == charB)
            {
                Debug.WriteLine("Match found!");
                A.Tag = null;
                B.Tag = null;
                matchedPairs++;
                Debug.WriteLine($"Matched pairs: {matchedPairs}");
            }
            else
            {
                tries++;
                lblStatus.Text = "Mismatched " + tries + " times.";
            }

            Debug.WriteLine($"Checking if game is over. Matched pairs: {matchedPairs}");
            if (matchedPairs == 6)
            {
                Debug.WriteLine("Game should be over now!");
                GameTimer.Stop();
                foreach (PictureBox pics in pictures)
                {
                    if (pics.Tag != null)
                    {
                        pics.Image = (Image)Properties.Resources.ResourceManager.GetObject((string)pics.Tag);
                    }
                    else
                    {
                        // For matched pairs, we need to keep their images visible
                        pics.Enabled = false;  // Disable the PictureBox to prevent further clicks
                    }
                }
                coinCounter += 50;
                lblCoins.Text = "Coins: " + coinCounter;
                updateCoinsEMMatching();
                GameOver("Great Work, You Win!!!! Click Restart to Play Again. You have earned 50 coins.");
            }
            else
            {
                Debug.WriteLine("Game not over yet.");
                // Reset choices and hide unmatched images after a short delay
                Timer timer = new Timer();
                timer.Interval = 500; // 500 milliseconds = 0.5 seconds
                timer.Tick += (sender, e) =>
                {
                    timer.Stop();
                    firstChoice = null;
                    secondChoice = null;
                    foreach (PictureBox pics in pictures)
                    {
                        if (pics.Tag != null)
                        {
                            pics.Image = null;
                        }
                    }
                };
                timer.Start();
            }
        }


        private void GameOver(string msg)
        {
            Debug.WriteLine("GameOver method called with message: " + msg);
            GameTimer.Stop();
            gameOver = true;
            MessageBox.Show(msg);

            // Reset the game state
            matchedPairs = 0;
            coinCounter = 0;
            lblCoins.Text = "Coins: " + coinCounter;
            totalTime = 30;
            lblTimeLeft.Text = "Time Left: " + totalTime;
        }

        private void lblTimeLeft_Click(object sender, EventArgs e)
        {
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage stHomePage = new HomePage();
            stHomePage.ShowDialog();
            this.Close();
        }
    }
}