using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;
//using Vlc.DotNet.Forms;

namespace ThinkerToys
{
    public partial class MathGameForm : Form
    {
        private int correctAnswer;
        private int score = 0;
        private int questionCount = 0;
        private int totalQuestions = 15;
        private Timer timer = new Timer();
        private int timeLeft = 30;
        private Random random = new Random();
        private bool isButtonClicked = false;
        private int jumpHeight = 20;
        private int jumpSpeed = 2;
        private bool isJumping = false;
        private bool isGameActive = true; // Flag to control the game state

        private int jumpDirection = -1; // -1 for up, 1 for down
        private Timer moveTimer;
        private Timer jumpTimer;
        private int foxOriginalY;



        public MathGameForm()
        {
            InitializeComponent();
            // InitializeVlcPlayer();
            timer.Interval = 1000; // 1 second intervals
            timer.Tick += Timer_Tick;
            timer.Start();
            GenerateQuestion();
            InitializeJumpTimer();
            SetTransparentFoxImage();
            //   InitializeBtnHome();
            CustomizeControls();
        }


        private void buttonNewGame_Click(object sender, EventArgs e)
        {
            ResetGame();
        }

        private void CustomizeControls()
        {
           
            button3.BackColor = Color.LightPink;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Comic Sans MS", 14, FontStyle.Bold);
            button3.ForeColor = Color.White;

            button1.BackColor = Color.LightGreen;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Comic Sans MS", 14, FontStyle.Bold);
            button1.ForeColor = Color.White;

            button2.BackColor = Color.LightBlue;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Comic Sans MS", 14, FontStyle.Bold);
            button2.ForeColor = Color.White;

            button4.BackColor = Color.LightSalmon;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Comic Sans MS", 14, FontStyle.Bold);
            button4.ForeColor = Color.White;

            // Improve New Game button style
            buttonNewGame.BackColor = Color.Gold;
            buttonNewGame.FlatStyle = FlatStyle.Flat;
            buttonNewGame.Font = new Font("Comic Sans MS", 10, FontStyle.Bold);
            buttonNewGame.ForeColor = Color.DarkBlue;
            buttonNewGame.Size = new Size(100, 40);

            buttonHome.BackColor = Color.Orange;
            buttonHome.FlatStyle = FlatStyle.Flat;
            buttonHome.Font = new Font("Comic Sans MS", 8, FontStyle.Bold);
            buttonHome.ForeColor = Color.White;
            buttonHome.Size = new Size(50, 40); // Ensure the button has a visible size
            buttonHome.Location = new Point(this.ClientSize.Width - 110, 10); // Position the button at the top-right corner
            buttonHome.Location = new Point(this.ClientSize.Width - buttonHome.Width - 10, 10);
            buttonHome.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        }
            private void InitializeJumpTimer()
        {
            moveTimer = new Timer();
            moveTimer.Interval = 50; // Move the fox every 50 ms
            moveTimer.Tick += MoveTimer_Tick;
            moveTimer.Start();

            jumpTimer = new Timer();
            jumpTimer.Interval = 20;
            jumpTimer.Tick += JumpTimer_Tick;
        }
        private void SetTransparentFoxImage()
        {
            try
            {
                // Access the image directly from resources
                using (Bitmap foxBitmap = new Bitmap(Properties.Resources.spiritalian))
                {
                    var transparentFoxBitmap = MakeTransparent(foxBitmap, Color.White, 5);
                    spritePictureBox.Image = transparentFoxBitmap;
                    spritePictureBox.BackColor = Color.Transparent;
                    spritePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while setting the fox image: {ex.Message}\n\nDetails:\n\n{ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private Bitmap MakeTransparent(Bitmap bitmap, Color color, int tolerance)
        {
            Bitmap transparentImage = new Bitmap(bitmap);

            for (int i = transparentImage.Size.Width - 1; i >= 0; i--)
            {
                for (int j = transparentImage.Size.Height - 1; j >= 0; j--)
                {
                    var currentColor = transparentImage.GetPixel(i, j);
                    if (Math.Abs(color.R - currentColor.R) < tolerance &&
                        Math.Abs(color.G - currentColor.G) < tolerance &&
                        Math.Abs(color.B - currentColor.B) < tolerance)
                    {
                        transparentImage.SetPixel(i, j, Color.Transparent);
                    }
                }
            }

            transparentImage.MakeTransparent(color);
            return transparentImage;
        }
        private void Homebt_Paint(object sender, PaintEventArgs e)
        {
            PictureBox pb = sender as PictureBox;
            int radius = 10; // Adjust the radius as needed
            GraphicsPath path = new GraphicsPath();

            Rectangle rect = pb.ClientRectangle;
            path.AddArc(rect.Left, rect.Top, radius, radius, 180, 90);
            path.AddArc(rect.Right - radius, rect.Top, radius, radius, 270, 90);
            path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
            path.AddArc(rect.Left, rect.Bottom - radius, radius, radius, 90, 90);
            path.CloseFigure();

            pb.Region = new Region(path);

            // Draw the image inside the rounded region
            e.Graphics.SetClip(path);
            e.Graphics.DrawImage(pb.Image, rect);
        }
        private void MoveTimer_Tick(object sender, EventArgs e)
        {
            // Move the fox to the right
            spritePictureBox.Left += 5;
            if (spritePictureBox.Left > this.Width)
            {
                // Reset position
                spritePictureBox.Left = -spritePictureBox.Width;
            }
        }

        private void JumpTimer_Tick(object sender, EventArgs e)
        {
            if (isJumping)
            {
                // Simulate jump
                spritePictureBox.Top -= jumpHeight;
                jumpHeight -= 2; // Gravity effect
                if (jumpHeight <= -20) // Jump complete
                {
                    isJumping = false;
                    jumpTimer.Stop();
                    jumpHeight = 20; // Reset jump height
                    spritePictureBox.Top = foxOriginalY; // Reset position
                }
            }
        }


        private void Button_MouseDown(object sender, MouseEventArgs e)
        {
            isButtonClicked = true;
            (sender as Button).Invalidate(); // Trigger a repaint
        }
        private void ResetGame()
        {
            score = 0;
            timeLeft = 30;
            lblScore.Text = "Score: " + score;
            lblTime.Text = "Time: " + timeLeft;
            GenerateQuestion();
            timer.Start();
        }
        private void Button_MouseUp(object sender, MouseEventArgs e)
        {
            isButtonClicked = false;
            (sender as Button).Invalidate(); // Trigger a repaint
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (!isGameActive) return;

            timeLeft--;
            lblTime.Text = "Time: " + timeLeft;
            if (timeLeft <= 0)
            {
                timer.Stop();
                isGameActive = false; // Set the game as inactive
                moveTimer.Stop();
                jumpTimer.Stop();
                MessageBox.Show("Time's up! Your score is: " + score);
                this.Close();
            }
        }
        private void Button_Paint(object sender, PaintEventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                Graphics graphics = e.Graphics;
                Rectangle buttonRect = new Rectangle(0, 0, btn.Width, btn.Height);
                int borderRadius = 10;
                int borderWidth = 2;

                graphics.Clear(btn.BackColor);

                if (isButtonClicked)
                {
                    Rectangle shadowRect = new Rectangle(buttonRect.Left + 3, buttonRect.Top + 3, buttonRect.Width, buttonRect.Height);
                    using (GraphicsPath shadowPath = new GraphicsPath())
                    {
                        shadowPath.AddArc(shadowRect.Left, shadowRect.Top, borderRadius, borderRadius, 180, 90);
                        shadowPath.AddArc(shadowRect.Right - borderRadius, shadowRect.Top, borderRadius, borderRadius, 270, 90);
                        shadowPath.AddArc(shadowRect.Right - borderRadius, shadowRect.Bottom - borderRadius, borderRadius, borderRadius, 0, 90);
                        shadowPath.AddArc(shadowRect.Left, shadowRect.Bottom - borderRadius, borderRadius, borderRadius, 90, 90);
                        shadowPath.CloseFigure();

                        using (SolidBrush shadowBrush = new SolidBrush(Color.FromArgb(60, Color.Black)))
                        {
                            graphics.FillPath(shadowBrush, shadowPath);
                        }
                    }
                }

                using (Pen borderPen = new Pen(Color.Orange, borderWidth))
                {
                    using (GraphicsPath path = new GraphicsPath())
                    {
                        path.AddArc(buttonRect.Left, buttonRect.Top, borderRadius, borderRadius, 180, 90);
                        path.AddArc(buttonRect.Right - borderRadius, buttonRect.Top, borderRadius, borderRadius, 270, 90);
                        path.AddArc(buttonRect.Right - borderRadius, buttonRect.Bottom - borderRadius, borderRadius, borderRadius, 0, 90);
                        path.AddArc(buttonRect.Left, buttonRect.Bottom - borderRadius, borderRadius, borderRadius, 90, 90);
                        path.CloseFigure();

                        btn.Region = new Region(path);
                        graphics.DrawPath(borderPen, path);
                    }
                }

                // Draw the text
                TextRenderer.DrawText(graphics, btn.Text, btn.Font, buttonRect, btn.ForeColor, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
            }
        }

       


        private void GenerateQuestion()
        {
            int num1, num2;
            string selectedOperator;

            // Randomly select an operator
            string[] operators = { "+", "-" };
            selectedOperator = operators[random.Next(operators.Length)];

            // Generate numbers based on the selected operator
            if (selectedOperator == "+")
            {
                // For addition, no need to enforce which number is larger
                num1 = random.Next(1, 10);
                num2 = random.Next(1, 10);
                correctAnswer = num1 + num2;
            }
            else // selectedOperator == "-"
            {
                num1 = random.Next(5, 10); 
                num2 = random.Next(1, num1); 
                correctAnswer = num1 - num2;
            }

            // Display the numbers and the operator
            lblNum1.Text = num1.ToString();
            lblOperator.Text = selectedOperator;
            lblNum2.Text = num2.ToString();

            // Assign the correct answer to one of the buttons
            int correctButton = random.Next(1, 5);
            for (int i = 1; i <= 4; i++)
            {
                Button btn = this.Controls["button" + i] as Button;
                if (i == correctButton)
                {
                    btn.Text = correctAnswer.ToString();
                }
                else
                {
                    int wrongAnswer;
                    do
                    {
                        wrongAnswer = random.Next(1, 20);
                    } while (wrongAnswer == correctAnswer); 
                    btn.Text = wrongAnswer.ToString();
                }
            }
        }



        // Event handler for homebt click event
        private void homebt_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to go to the home page?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Hide();
                HomePage stHomePage = new HomePage();
                stHomePage.ShowDialog();
                this.Close();
            }
        }



        private void AnswerButton_Click(object sender, EventArgs e)
        {
            if (!isGameActive) return;

            Button btn = sender as Button;
            if (btn.Text == correctAnswer.ToString())
            {
                score += 10;
                lblScore.Text = "Score: " + score;
                questionCount++;
                lblCorrectMessage.Font = new Font(lblCorrectMessage.Font.FontFamily, 18, FontStyle.Bold);

                Timer hideMessageTimer = new Timer();
                hideMessageTimer.Interval = 1000;
                hideMessageTimer.Tick += (s, args) =>
                {
                    lblCorrectMessage.Visible = false;
                    hideMessageTimer.Stop();
                    hideMessageTimer.Dispose();
                };
                hideMessageTimer.Start();
                lblCorrectMessage.Text = "Great job! Correct question";
                lblCorrectMessage.Visible = true;

                if (questionCount >= totalQuestions)
                {
                    timer.Stop();
                    isGameActive = false;
                    moveTimer.Stop();
                    jumpTimer.Stop();
                    MessageBox.Show("Game over! Your score is: " + score);
                    this.Close();
                }
                else
                {
                    GenerateQuestion();
                }
            }
            else
            {
                lblCorrectMessage.Font = new Font(lblCorrectMessage.Font.FontFamily, 18, FontStyle.Bold);
                lblCorrectMessage.Text = "Oops! Try again";
                lblCorrectMessage.Visible = true;

                Timer hideMessageTimer = new Timer();
                hideMessageTimer.Interval = 1000;
                hideMessageTimer.Tick += (s, args) =>
                {
                    lblCorrectMessage.Visible = false;
                    hideMessageTimer.Stop();
                    hideMessageTimer.Dispose();
                };
                hideMessageTimer.Start();

                // Trigger the fox to jump
                if (!isJumping)
                {
                    isJumping = true;
                    foxOriginalY = spritePictureBox.Top;
                    jumpTimer.Start();
                }
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            using (Brush b = new SolidBrush(this.ForeColor))
            {
                e.Graphics.DrawString(this.Text, this.Font, b, -1, -1);
            }
        }

        private void lblEquals_Click(object sender, EventArgs e)
        {

        }
    }
}
