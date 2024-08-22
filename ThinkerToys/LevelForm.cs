using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ThinkerToys
{
    public partial class LevelForm : Form
    {
        private int level;
        private HebrewMainMenu mainMenuForm;
        private List<Label> wordLabels = new List<Label>();
        private List<LevelData> levels = new List<LevelData>
        {
            new LevelData
            {
                Picture = Properties.Resources.duckk,
                Words = new string[] { "כֶּלֶב", "ברווז", "ציפור" },
                CorrectWord = "ברווז"
            },
            new LevelData
            {
                Picture = Properties.Resources.cow,
                Words = new string[] { "פָּרָה", "עכבר", "חתול" },
                CorrectWord = "פָּרָה"
            },
            new LevelData
            {
                Picture = Properties.Resources.chicken,
                Words = new string[] { "חמור", "תרנגולת", "פָּרָה" },
                CorrectWord = "תרנגולת"
            },
            new LevelData
            {
                Picture = Properties.Resources.dog,
                Words = new string[] { "סוס", "חתול", "כֶּלֶב" },
                CorrectWord = "כֶּלֶב"
            },
            new LevelData
            {
                Picture = Properties.Resources.bird,
                Words = new string[] { "יוֹנָה", "ציפור", "תרנגולת" },
                CorrectWord = "ציפור"
            },
            new LevelData
            {
                Picture = Properties.Resources.dounkey,
                Words = new string[] { "חמור", "סוס", "כלב" },
                CorrectWord = "חמור"
            },
            new LevelData
            {
                Picture = Properties.Resources.senjab,
                Words = new string[] { "חתול", "ברווז", "סנאי" },
                CorrectWord = "סנאי"
            },
            new LevelData
            {
                Picture = Properties.Resources.goat,
                Words = new string[] { "קוף", "שׁוֹר", "עֵז" },
                CorrectWord = "עֵז"
            },
            new LevelData
            {
                Picture = Properties.Resources.rooster,
                Words = new string[] { "תַרְנְגוֹל", "חמור", "גמל" },
                CorrectWord = "תַרְנְגוֹל"
            },
            new LevelData
            {
                Picture = Properties.Resources.sheep,
                Words = new string[] { "כבש", "עז", "ארנב" },
                CorrectWord = "כבש"
            }
        };

        private Image BackgroundImage;
        private Panel dropTargetPanel;
        private int currentScore = 0;

        public LevelForm(int level, HebrewMainMenu mainMenuForm)
        {
            this.level = level;
            this.mainMenuForm = mainMenuForm;
            InitializeLevelComponents();
            InitializeLevel();
        }

        private void InitializeLevel()
        {
            LevelData currentLevelData = levels[level - 1];

            BackgroundImage = currentLevelData.Picture;

            if (BackgroundImage != null)
            {
                this.ClientSize = new Size(BackgroundImage.Width, BackgroundImage.Height);
            }

            for (int i = 0; i < currentLevelData.Words.Length; i++)
            {
                Label wordLabel = new Label
                {
                    Text = currentLevelData.Words[i],
                    Tag = currentLevelData.Words[i],
                    BorderStyle = BorderStyle.FixedSingle,
                    Padding = new Padding(5),
                    AutoSize = false,
                    Size = new Size(80, 30),
                    BackColor = Color.Brown,
                    ForeColor = Color.White,
                    Font = new Font("Arial", 10, FontStyle.Bold),
                    Location = new Point(50 + i * 100, this.ClientSize.Height - 100)
                };
                wordLabels.Add(wordLabel);
                this.Controls.Add(wordLabel);
                wordLabel.MouseDown += new MouseEventHandler(wordLabel_MouseDown);
                wordLabel.AllowDrop = true;
            }

            dropTargetPanel = new Panel
            {
                BorderStyle = BorderStyle.FixedSingle,
                Size = new Size(100, 40),
                Location = new Point((this.ClientSize.Width - 450) / 2, this.ClientSize.Height - 160),
                Tag = currentLevelData.CorrectWord
            };
            this.Controls.Add(dropTargetPanel);

            Label dropTargetLabel = new Label
            {
                Text = "     ?",
                ForeColor = Color.Black,
                BackColor = Color.Transparent,
                AutoSize = true,
                Font = new Font("Arial", 15, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Fill
            };

            dropTargetPanel.Controls.Add(dropTargetLabel);
        }

        private void HideControls()
        {
            if (dropTargetPanel != null)
                dropTargetPanel.Visible = false;
            foreach (var wordLabel in wordLabels)
            {
                wordLabel.Visible = false;
            }
        }

        private void ShowControls()
        {
            if (dropTargetPanel != null)
                dropTargetPanel.Visible = true;
            foreach (var wordLabel in wordLabels)
            {
                wordLabel.Visible = true;
            }
        }

        private void DisableInteractionControls()
        {
            foreach (var wordLabel in wordLabels)
            {
                wordLabel.Enabled = false;
            }
            if (dropTargetPanel != null)
            {
                dropTargetPanel.Enabled = false;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (BackgroundImage != null)
            {
                e.Graphics.DrawImage(BackgroundImage, 0, 0, this.ClientSize.Width, this.ClientSize.Height);
            }
        }

        private void LevelForm_Load(object sender, EventArgs e)
        {
            dropTargetPanel.AllowDrop = true;
            dropTargetPanel.DragEnter += new DragEventHandler(dropTargetPanel_DragEnter);
            dropTargetPanel.DragDrop += new DragEventHandler(dropTargetPanel_DragDrop);
        }

        private void wordLabel_MouseDown(object sender, MouseEventArgs e)
        {
            Label wordLabel = sender as Label;
            if (wordLabel != null)
            {
                wordLabel.DoDragDrop(wordLabel.Text, DragDropEffects.Move);
            }
        }

        private void dropTargetPanel_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void dropTargetPanel_DragDrop(object sender, DragEventArgs e)
        {
            string droppedWord = e.Data.GetData(DataFormats.Text).ToString();

            if (dropTargetPanel.Tag != null)
            {
                if (droppedWord == dropTargetPanel.Tag.ToString())
                {
                    MessageBox.Show("Correct! You earned 5 points.");

                    AddScore(5);

                    // Disable interactions and show buttons for continuing or going back
                    DisableInteractionControls();
                    ShowLevelCompletionOptions();
                }
                else
                {
                    MessageBox.Show("Incorrect. Try again.");
                }
            }
            else
            {
                MessageBox.Show("Drop target panel is not properly initialized.");
            }
        }

        private void AddScore(int points)
        {
            currentScore += points;
            mainMenuForm.UpdateScore(points); // Update score on the main menu
            UserSession.Instance.Coins += points; // Update coins in the user session
        }

        private void ShowLevelCompletionOptions()
        {
            Button continueButton = new Button
            {
                Text = "Continue",
                Width = 100,
                Height = 50,
                Top = this.ClientSize.Height / 2 - 25,
                Left = this.ClientSize.Width / 2 - 110,
            };
            continueButton.Click += ContinueButton_Click;
            this.Controls.Add(continueButton);

            Button backButton = new Button
            {
                Text = "Back to Levels",
                Width = 100,
                Height = 50,
                Top = this.ClientSize.Height / 2 - 25,
                Left = this.ClientSize.Width / 2 + 10,
            };
            backButton.Click += BackButton_Click;
            this.Controls.Add(backButton);

            // Disable interactions with other controls
            DisableInteractionControls();

            // Check if all levels are completed
            if (level == levels.Count)
            {
                ShowGameCompletionMessage();
            }
        }

        private void ShowGameCompletionMessage()
        {
            MessageBox.Show("WELL DONE! YOU FINISHED THE GAME!");

            Button replayButton = new Button
            {
                Text = "Replay Game",
                Width = 150,
                Height = 50,
                Top = this.ClientSize.Height / 2 + 40,
                Left = this.ClientSize.Width / 2 - 75
            };
            replayButton.Click += ReplayButton_Click;
            this.Controls.Add(replayButton);

            Button backButton = new Button
            {
                Text = "Back to Main Menu",
                Width = 150,
                Height = 50,
                Top = this.ClientSize.Height / 2 + 100,
                Left = this.ClientSize.Width / 2 - 75
            };
            backButton.Click += BackButton_Click;
            this.Controls.Add(backButton);
        }

        private void ReplayButton_Click(object sender, EventArgs e)
        {
            this.Close();
            mainMenuForm.ResetGame();
            mainMenuForm.Show();
        }

        private void ContinueButton_Click(object sender, EventArgs e)
        {
            mainMenuForm.UnlockNextLevel(level);
            this.Close();
            LevelForm nextLevelForm = new LevelForm(level + 1, mainMenuForm);
            nextLevelForm.Show();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            mainMenuForm.UnlockNextLevel(level);
            this.Close();
            mainMenuForm.Show();
        }

        private void InitializeLevelComponents()
        {
            this.SuspendLayout();
            // 
            // LevelForm
            // 
            this.Name = "LevelForm";
            this.Text = "Animals Farm Matching";
            this.Load += new System.EventHandler(this.LevelForm_Load);
            this.ResumeLayout(false);
        }
    }

    public class LevelData
    {
        public Image Picture { get; set; }
        public string[] Words { get; set; }
        public string CorrectWord { get; set; }
    }
}
