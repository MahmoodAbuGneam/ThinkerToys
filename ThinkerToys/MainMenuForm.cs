﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace ThinkerToys
{
    public partial class MainMenuForm : Form
    {
        private int currentScore = 0;
        private int levelsUnlocked = 1;

        public MainMenuForm()
        {
            InitializeComponent();
            InitializeCustomComponents();
        }

        private void InitializeCustomComponents()
        {
            // Set the background image
            this.BackgroundImage = Properties.Resources.greenBackground;
            this.BackgroundImageLayout = ImageLayout.Stretch; // Stretch the image to fill the form

            int pictureBoxSize = 140; // Width and height of each PictureBox
            int spacing = 20; // Space between PictureBoxes
            int columns = 3; // Number of columns
            int rows = 4; // Number of rows, calculated as needed
            int startX = (this.ClientSize.Width - (columns * (pictureBoxSize + spacing) - spacing)) / 2; // Center alignment X coordinate
            int startY = 50; // Starting Y coordinate

            for (int i = 1; i <= 10; i++)
            {
                int row = (i - 1) / columns; // Determine the row
                int column = (i - 1) % columns; // Determine the column

                PictureBox levelPictureBox = new PictureBox
                {
                    Tag = i,
                    Width = pictureBoxSize,
                    Height = pictureBoxSize,
                    Top = startY + (row * (pictureBoxSize + spacing)), // Position based on row
                    Left = startX + (column * (pictureBoxSize + spacing)), // Position based on column
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Image = i <= levelsUnlocked ? Properties.Resources.open : Properties.Resources.close
                };
                levelPictureBox.Click += LevelPictureBox_Click;
                this.Controls.Add(levelPictureBox);
            }
        }

        private void LevelPictureBox_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            int level = (int)pictureBox.Tag;

            if (level <= levelsUnlocked)
            {
                LevelForm levelForm = new LevelForm(level, this);
                levelForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("This level is locked. Please complete previous levels to unlock it.");
            }
        }

        public void UnlockNextLevel(int currentLevel)
        {
            levelsUnlocked = Math.Max(levelsUnlocked, currentLevel + 1);

            // Update PictureBoxes
            foreach (Control control in this.Controls)
            {
                if (control is PictureBox pictureBox)
                {
                    int level = (int)pictureBox.Tag;
                    pictureBox.Image = level <= levelsUnlocked ? Properties.Resources.open : Properties.Resources.close;
                }
            }
        }

        public void UpdateScore(int points)
        {
            currentScore += points;
            // Implement any additional logic you need for updating the score here
        }

        public void ResetGame()
        {
            levelsUnlocked = 1;
            currentScore = 0;
            UpdateLevelPictureBoxes();
        }

        private void UpdateLevelPictureBoxes()
        {
            foreach (Control control in this.Controls)
            {
                if (control is PictureBox pictureBox)
                {
                    int level = (int)pictureBox.Tag;
                    pictureBox.Image = level <= levelsUnlocked ? Properties.Resources.open : Properties.Resources.close;
                }
            }
        }

        private void MainMenuForm_Load(object sender, EventArgs e)
        {
        }

        private void InitializeComponent()
        {
            SuspendLayout();
            // 
            // MainMenuForm
            // 
            ClientSize = new Size(800, 679);
            Name = "MainMenuForm";
            Load += MainMenuForm_Load;
            ResumeLayout(false);
        }
    }
}
