﻿namespace ThinkerToys
{
    public partial class HebrewGame1 : Form
    {
        private bool right, left, up;
        private bool gameRunning = true; // Flag to control game state
        private int score = 0; // Player's score
        private Label gameOverLabel; // Label for "GAME OVER" text
        private Label scoreLabel; // Label to display score
        private char startingLetter;
        private Button btnBackToLevels;

        public class Level
        {
            public char CorrectLetter { get; set; }
            public List<char> IncorrectLetters { get; set; }
        }

        private List<Level> levels = new List<Level>
        {
            new Level { CorrectLetter = 'א', IncorrectLetters = new List<char> { 'ע', 'ג', 'ד', 'ה' } },
            new Level { CorrectLetter = 'ב', IncorrectLetters = new List<char> { 'א', 'י', 'ד', 'ה' } },
            new Level { CorrectLetter = 'ג', IncorrectLetters = new List<char> { 'ב', 'ח', 'ת', 'ז' } },
            new Level { CorrectLetter = 'ד', IncorrectLetters = new List<char> { 'מ', 'ח', 'ק', 'ב' } },
            new Level { CorrectLetter = 'ה', IncorrectLetters = new List<char> { 'ד', 'ע', 'י', 'א' } },
            new Level { CorrectLetter = 'ו', IncorrectLetters = new List<char> { 'א', 'ח', 'ד', 'ס' } },
            new Level { CorrectLetter = 'ז', IncorrectLetters = new List<char> { 'ב', 'ת', 'ד', 'י' } },
            new Level { CorrectLetter = 'ח', IncorrectLetters = new List<char> { 'ג', 'ש', 'מ', 'א' } },
            new Level { CorrectLetter = 'ט', IncorrectLetters = new List<char> { 'ע', 'ח', 'ס', 'ג' } },
            new Level { CorrectLetter = 'י', IncorrectLetters = new List<char> { 'ק', 'ח', 'ל', 'ע' } },
            new Level { CorrectLetter = 'כ', IncorrectLetters = new List<char> { 'ב', 'ע', 'ד', 'ל' } },
            new Level { CorrectLetter = 'ל', IncorrectLetters = new List<char> { 'ג', 'פ', 'ד', 'ב' } },
            new Level { CorrectLetter = 'מ', IncorrectLetters = new List<char> { 'ר', 'ב', 'ד', 'ה' } },
            new Level { CorrectLetter = 'נ', IncorrectLetters = new List<char> { 'ה', 'ע', 'ג', 'ס' } },
            new Level { CorrectLetter = 'ס', IncorrectLetters = new List<char> { 'ב', 'א', 'ד', 'ק' } },
            new Level { CorrectLetter = 'ע', IncorrectLetters = new List<char> { 'ג', 'י', 'ד', 'א' } },
            new Level { CorrectLetter = 'פ', IncorrectLetters = new List<char> { 'מ', 'ב', 'א', 'ה' } },
            new Level { CorrectLetter = 'צ', IncorrectLetters = new List<char> { 'ח', 'ו', 'ע', 'א' } },
            new Level { CorrectLetter = 'ק', IncorrectLetters = new List<char> { 'ש', 'ח', 'צ', 'א' } },
            new Level { CorrectLetter = 'ר', IncorrectLetters = new List<char> { 'ע', 'ו', 'ח', 'ט' } },
            new Level { CorrectLetter = 'ש', IncorrectLetters = new List<char> { 'א', 'ם', 'כ', 'י' } },
            new Level { CorrectLetter = 'ת', IncorrectLetters = new List<char> { 'ב', 'ר', 'כ', 'ק' } },
        };


        

        public HebrewGame1(char startingLetter)
        {
            this.startingLetter = startingLetter;
            InitializeComponent();
            InitializeGameOverLabel(); // Initialize the game over label
            InitializeScoreLabel(); // Initialize the score label
        }

        private void HebrewGame1_Load(object sender, EventArgs e)
        {
            LoadLevel(startingLetter);
        }

        private void LoadLevel(char letter)
        {
            var level = levels.FirstOrDefault(l => l.CorrectLetter == letter);
            if (level != null)
            {
                InitializeLevel(level);
            }
            else
            {
                // Handle case when the level is not found
            }
        }

        private void InitializeLevel(Level level)
        {
            // Remove previous level's letters
            foreach (var control in this.Controls.OfType<PictureBox>().ToList())
            {
                if (control.Tag != null && (control.Tag.ToString() == "RightLetter" || control.Tag.ToString() == "WrongLetter"))
                {
                    this.Controls.Remove(control);
                }
            }

            // Add correct letters
            CreateLetterPictureBoxes(level.CorrectLetter, "RightLetter");

            // Add incorrect letters
            foreach (var incorrectLetter in level.IncorrectLetters)
            {
                CreateLetterPictureBoxes(incorrectLetter, "WrongLetter");
            }
        }

        private void CreateLetterPictureBoxes(char letter, string tag)
        {
            Random rand = new Random();
            const int minDistance = 60; // Minimum distance between PictureBox controls

            for (int i = 0; i < 1; i++) 
            {
                PictureBox pb = new PictureBox
                {
                    Tag = tag,
                    Size = new Size(50, 50),
                    Image = GetLetterImage(letter),
                    SizeMode = PictureBoxSizeMode.StretchImage
                };

                bool positionFound = false;
                while (!positionFound)
                {
                    int x = rand.Next(0, this.ClientSize.Width - pb.Width);
                    int y = rand.Next(0, this.ClientSize.Height - pb.Height);

                    pb.Location = new Point(x, y);
                    positionFound = !IsTooClose(pb, minDistance);
                }

                this.Controls.Add(pb);
            }
        }

        private bool IsTooClose(PictureBox newBox, int minDistance)
        {
            foreach (Control control in this.Controls)
            {
                if (control is PictureBox existingBox && existingBox != newBox)
                {
                    int dx = Math.Abs(existingBox.Left - newBox.Left);
                    int dy = Math.Abs(existingBox.Top - newBox.Top);
                    if (Math.Sqrt(dx * dx + dy * dy) < minDistance)
                    {
                        return true; // Too close
                    }
                }
            }
            return false; // Not too close
        }

        private Image GetLetterImage(char letter)
        {
            switch (letter)
            {
                case 'א': return Properties.Resources.א; 
                case 'ב': return Properties.Resources.ב;
                case 'ג': return Properties.Resources.ג;
                case 'ד': return Properties.Resources.ד;
                case 'ה': return Properties.Resources.ה;
                case 'ו': return Properties.Resources.ו;
                case 'ז': return Properties.Resources.ז;
                case 'ח': return Properties.Resources.ח;
                case 'ט': return Properties.Resources.ט;
                case 'י': return Properties.Resources.י;
                case 'כ': return Properties.Resources.כ;
                case 'ל': return Properties.Resources.ל;
                case 'מ': return Properties.Resources.מ;
                case 'נ': return Properties.Resources.נ;
                case 'ס': return Properties.Resources.ס;
                case 'ע': return Properties.Resources.ע;
                case 'פ': return Properties.Resources.פ;
                case 'צ': return Properties.Resources.צ;
                case 'ק': return Properties.Resources.ק;
                case 'ר': return Properties.Resources.ר;
                case 'ש': return Properties.Resources.ש;
                case 'ת': return Properties.Resources.ת;

                default: return null; // Handle the case where the image does not exist
            }
        }

        private void Letters_move(string tag, Action<PictureBox> onCollision)
        {
            foreach (Control control in this.Controls)
            {
                if (control is PictureBox pictureBox && pictureBox.Tag != null && pictureBox.Tag.ToString() == tag)
                {
                    if (pictureBox.Top > 450)
                    {
                        pictureBox.Top = 0;
                        Random r = new Random();
                        int y = r.Next(100, 400);
                        pictureBox.Location = new Point(y, 10);
                    }
                    pictureBox.Top += 5;

                    // Check for collision with the player
                    if (player.Bounds.IntersectsWith(pictureBox.Bounds))
                    {
                        onCollision(pictureBox);
                        return; // Exit the method to prevent further movements
                    }
                }
            }
        }

        private void RightLetters_move()
        {
            Letters_move("RightLetter", (pictureBox) =>
            {
                IncrementScore();
                pictureBox.Top = 0; // Reset the RightLetter position
            });
        }

        private void WrongLetters_move()
        {
            Letters_move("WrongLetter", (pictureBox) =>
            {
                GameOver();
            });
        }

        private void player_move()
        {
            if (right && player.Left < 450)
            {
                player.Left += 5;
            }

            if (left && player.Left > 20)
            {
                player.Left -= 5;
            }

            if (up)
            {
                Tiles_move();
            }
        }

        private void Tiles_move()
        {
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag != null && x.Tag.ToString() == "tile")
                {
                    if (x.Top > 450)
                    {
                        x.Top = -100;
                    }
                    x.Top += 5;
                }
            }
        }

        private void HebrewGame1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Right:
                    right = true;
                    break;

                case Keys.Left:
                    left = true;
                    break;

                case Keys.Up:
                    up = true;
                    break;
            }
        }

        private void HebrewGame1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Right:
                    right = false;
                    break;

                case Keys.Left:
                    left = false;
                    break;

                case Keys.Up:
                    up = false;
                    break;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (gameRunning) // Only run game logic if the game is running
            {
                player_move();
                RightLetters_move(); // Add this to check for RightLetter collisions
                WrongLetters_move();
                Tiles_move();
            }
        }

        private void GameOver()
        {
            gameRunning = false; // Stop the game
            timer1.Stop(); // Stop the timer
            CenterGameOverLabel(); // Center the label on the screen
            gameOverLabel.Visible = true; // Show the "GAME OVER" label

            if (btnBackToLevels == null)
            {
                btnBackToLevels = new Button
                {
                    Text = "Back to Levels",
                    Size = new Size(150, 50),
                    ForeColor = Color.White,
                    BackColor = Color.Black,
                    Location = new Point((this.ClientSize.Width - 150) / 2, (this.ClientSize.Height - 50) / 2 + 100), // Adjust location as needed
                    Visible = true
                };

                btnBackToLevels.Click += btnBackToLevels_Click;

                // Add the button to the form's controls
                this.Controls.Add(btnBackToLevels);
                btnBackToLevels.BringToFront(); // Ensure the button is on top
            }
        }

        private void IncrementScore()
        {
            score += 1; // Increase score by 1
            scoreLabel.Text = "Score: " + score; // Update score label
        }

        private void InitializeGameOverLabel()
        {
            // Initialize the "GAME OVER" label
            gameOverLabel = new Label
            {
                Text = "GAME OVER",
                Font = new Font("Arial", 48, FontStyle.Bold),
                ForeColor = Color.Red,
                BackColor = Color.Transparent,
                AutoSize = true,
                Visible = false, // Initially hidden
            };

            // Add the label to the form's controls
            this.Controls.Add(gameOverLabel);
            gameOverLabel.BringToFront(); // Ensure the label is on top
        }

        private void InitializeScoreLabel()
        {
            // Initialize the score label
            scoreLabel = new Label
            {
                Text = "Score: 0",
                Font = new Font("Arial", 20, FontStyle.Regular),
                ForeColor = Color.Yellow,
                BackColor = Color.Transparent,
                AutoSize = true,
                Location = new Point(10, 10) // Position at the top-left of the screen
            };

            // Add the label to the form's controls
            this.Controls.Add(scoreLabel);
            scoreLabel.BringToFront(); // Ensure the label is on top
        }

        private void CenterGameOverLabel()
        {
            // Center the label on the form
            if (gameOverLabel != null)
            {
                gameOverLabel.Location = new Point(
                    (this.ClientSize.Width - gameOverLabel.Width) / 2,
                    (this.ClientSize.Height - gameOverLabel.Height) / 2
                );
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            CenterGameOverLabel(); // Recenter the "GAME OVER" label when the form is resized
        }

        private void player_ClientSizeChanged(object sender, EventArgs e)
        {
            // Handle client size change if needed
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Handle picture box click if needed
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            // Handle picture box click if needed
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // Handle picture box click if needed
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            // Handle picture box click if needed
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {

        }
        private void btnBackToLevels_Click(object sender, EventArgs e)
        {
            // Show LevelSelectionForm and close the current form
            LevelSelectionForm levelSelectionForm = new LevelSelectionForm();
            levelSelectionForm.Show();
            this.Close(); // Close the current game form
        }
    }

    
}
