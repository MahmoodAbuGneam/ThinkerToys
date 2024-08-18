using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using _Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;

namespace ThinkerToys
{
    public partial class BiggerSmallerEqualsGame : Form
    {
        Random random = new Random();
        int firstNumber;
        int secondNumber;
        int score = 0;
        int timeLeft = 30;

        public BiggerSmallerEqualsGame()
        {
            InitializeComponent();

            CustomizeControls();
            GenerateNumbers();
            StartGame();

            this.FormClosing += BiggerSmallerEqualsGame_FormClosing;

        }

        private void BiggerSmallerEqualsGame_FormClosing(object? sender, FormClosingEventArgs e)
        {
            StopGame();

        }

        private void StartGame()
        {
            score = 0;
            timeLeft = 30;
            labelScore.Text = "Score: " + score;
            labelTime.Text = "Time: " + timeLeft;
            timer1.Start();
            Console.WriteLine("Game started, timer running"); 
        }

        private void CustomizeControls()
        {
            buttonHome.BackColor = Color.Orange;
            buttonHome.FlatStyle = FlatStyle.Flat;
            buttonHome.Font = new Font("Comic Sans MS", 8, FontStyle.Bold);
            buttonHome.ForeColor = Color.White;
            buttonHome.Size = new Size(50, 40); // Ensure the button has a visible size
            buttonHome.Location = new Point(this.ClientSize.Width - 110, 10); // Position the button at the top-right corner
            buttonHome.Location = new Point(this.ClientSize.Width - buttonHome.Width - 10, 10);
            buttonHome.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHome.BringToFront();
            buttonHome.Visible = true; // Ensure the button is visible
            buttonLess.BackColor = Color.LightPink;
            buttonLess.FlatStyle = FlatStyle.Flat;
            buttonLess.Font = new Font("Comic Sans MS", 14, FontStyle.Bold);
            buttonLess.ForeColor = Color.White;

            buttonGreater.BackColor = Color.LightGreen;
            buttonGreater.FlatStyle = FlatStyle.Flat;
            buttonGreater.Font = new Font("Comic Sans MS", 14, FontStyle.Bold);
            buttonGreater.ForeColor = Color.White;

            buttonEqual.BackColor = Color.LightBlue;
            buttonEqual.FlatStyle = FlatStyle.Flat;
            buttonEqual.Font = new Font("Comic Sans MS", 14, FontStyle.Bold);
            buttonEqual.ForeColor = Color.White;

            // Improve New Game button style
            buttonNewGame.BackColor = Color.Gold;
            buttonNewGame.FlatStyle = FlatStyle.Flat;
            buttonNewGame.Font = new Font("Comic Sans MS", 10, FontStyle.Bold);
            buttonNewGame.ForeColor = Color.DarkBlue;
            buttonNewGame.Size = new Size(100, 40);

            labelScore.Font = new Font("Comic Sans MS", 12, FontStyle.Bold);
            labelScore.ForeColor = Color.DarkBlue;
            labelScore.BackColor = Color.LightYellow;
            labelScore.TextAlign = ContentAlignment.MiddleCenter;
            labelScore.BorderStyle = BorderStyle.FixedSingle;
            labelScore.Size = new Size(100, 40);

            labelTime.Font = new Font("Comic Sans MS", 12, FontStyle.Bold);
            labelTime.ForeColor = Color.DarkRed;
            labelTime.BackColor = Color.LightYellow;
            labelTime.TextAlign = ContentAlignment.MiddleCenter; // Align text centrally
            labelTime.BorderStyle = BorderStyle.FixedSingle;
            labelTime.Size = new Size(100, 40);

            labelResult.Font = new Font("Comic Sans MS", 25, FontStyle.Bold);
            labelResult.ForeColor = Color.White;
            labelResult.BackColor = Color.Transparent;
            labelResult.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void GenerateNumbers()
        {
            firstNumber = random.Next(1, 10);
            secondNumber = random.Next(1, 10);
            labelFirstNumber.Text = firstNumber.ToString();
            labelSecondNumber.Text = secondNumber.ToString();
            labelResult.Text = ""; // Clear previous result
        }

        private void buttonLess_Click(object sender, EventArgs e)
        {
            CheckAnswer(firstNumber < secondNumber, "<");
        }

        private void buttonGreater_Click(object sender, EventArgs e)
        {
            CheckAnswer(firstNumber > secondNumber, ">");
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            CheckAnswer(firstNumber == secondNumber, "=");
        }

        private void CheckAnswer(bool isCorrect, string chosenSign)
        {
            if (isCorrect)
            {
                score += 10;
                labelScore.Text = "Score: " + score;
                labelResult.Text = "" + chosenSign;
            }
            else
            {
                labelResult.Text = $"No";
            }

            // Delay the generation of new numbers to allow the user to see the result
            System.Threading.Tasks.Task.Delay(1000).ContinueWith(_ =>
            {
                this.Invoke((Action)GenerateNumbers);
            });
        }


        private void buttonNewGame_Click(object sender, EventArgs e)
        {
            ResetGame();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Console.WriteLine("Timer tick"); // Debug line
            if (timeLeft > 0)
            {
                timeLeft--;
                labelTime.Text = "Time: " + timeLeft;
            }
            else
            {
                timer1.Stop();
                MessageBox.Show("Time's up! Your final score is: " + score, "Game Over");
                UpdateUserCoins();
                ResetGame();
            }
        }

        private void UpdateUserCoins()
        {
            // Only update coins if the score is positive
            if (score > 0)
            {
                int currentCoins = UserSession.Instance.Coins;
                int newCoins = currentCoins + score;
                UserSession.Instance.Coins = newCoins;

                // Update the coins in the database
                string username = UserSession.Instance.Username;
                UpdateCoinsInDatabase(username, newCoins);

            }
        }

        private void UpdateCoinsInDatabase(string username, int newCoins)
        {
            string filePath = System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(), "SignupData.xlsx");
            _Excel.Application excelApp = new _Excel.Application();
            _Excel.Workbook workbook = null;
            _Excel.Worksheet worksheet = null;

            try
            {
                workbook = excelApp.Workbooks.Open(filePath);
                worksheet = workbook.Sheets[1];

                int rowCount = worksheet.UsedRange.Rows.Count;
                for (int i = 2; i <= rowCount; i++)
                {
                    if ((string)(worksheet.Cells[i, 2] as _Excel.Range).Value == username)
                    {
                        worksheet.Cells[i, 6] = newCoins;
                        break;
                    }
                }

                workbook.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating coins in database: " + ex.Message);
            }
            finally
            {
                if (worksheet != null) Marshal.ReleaseComObject(worksheet);
                if (workbook != null)
                {
                    workbook.Close(true);
                    Marshal.ReleaseComObject(workbook);
                }
                excelApp.Quit();
                Marshal.ReleaseComObject(excelApp);
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
        
    }

        private void buttonTopRightHome_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to go to the home page? Your progress will be lost.", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                StopGame();
                this.Hide();
                HomePage stHomePage = new HomePage();
                stHomePage.ShowDialog();
                this.Close();
            }
        }

        private void StopGame()
        {
            timer1.Stop();
            UpdateUserCoins(); // Save the current score before leaving
        }

        private void ResetGame()
        {
            StartGame();
        }

        private void BiggerSmallerEqualsGame_Load(object sender, EventArgs e)
        {

        }
    }
}
