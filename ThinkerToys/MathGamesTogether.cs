using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using _Excel = Microsoft.Office.Interop.Excel;


namespace ThinkerToys
{

    public partial class MathGamesTogether : Form
    {
        public MathGamesTogether()
        {
            InitializeComponent();
            this.Load += Form1_Load; // Attach to Load event for initial positioning
            this.SizeChanged += Form1_SizeChanged; // Attach SizeChanged event for dynamic resizing
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button2.Text = UserSession.Instance.Coins.ToString();
            PositionGameCards();
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            PositionGameCards();
        }

        private void PositionGameCards()
        {
            // Calculate the positions dynamically based on the form size
            int cardWidth = gameCard1.Width;
            int cardHeight = gameCard1.Height;
            int spacing = (this.ClientSize.Width - (2 * cardWidth)) / 3; // Dynamic spacing

            // Positioning cards
            gameCard1.Location = new Point(spacing, headerPanel.Bottom + 20); // Maintains vertical spacing from header
            gameCard2.Location = new Point(spacing * 2 + cardWidth, headerPanel.Bottom + 20);

            // This ensures the cards remain in the vertical center as well, if needed
            int verticalCenter = (this.ClientSize.Height - headerPanel.Bottom - cardHeight) / 2 + headerPanel.Bottom;
            gameCard1.Top = verticalCenter;
            gameCard2.Top = verticalCenter;
        }


        private void gameButton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Starting Pop the Letters");
        }

        private void gameButton3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Starting Math Games");
        }

        private void gameButton4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Starting Hebrew Games");
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Going to Homepage");
        }
        private void SavePurchasesToExcel()
        {
            string purchasesString = string.Join(";", UserSession.Instance.Purchases.Select(kvp => $"{kvp.Key}:{kvp.Value}"));

            _Excel.Application excelApp = new _Excel.Application();
            excelApp.DisplayAlerts = false;  // Add this line to disable alerts
            _Excel.Workbook workbook = null;
            _Excel.Worksheet worksheet = null;

            try
            {
                string filePath = Path.Combine(Directory.GetCurrentDirectory(), "SignupData.xlsx");
                workbook = excelApp.Workbooks.Open(filePath);
                worksheet = workbook.Sheets[1];

                int rowCount = worksheet.UsedRange.Rows.Count;
                int colCount = worksheet.UsedRange.Columns.Count;

                // Find or create the "Purchases" column
                int purchasesColumn = 0;
                for (int i = 1; i <= colCount; i++)
                {
                    if (worksheet.Cells[1, i].Value2?.ToString() == "Purchases")
                    {
                        purchasesColumn = i;
                        break;
                    }
                }
                if (purchasesColumn == 0)
                {
                    purchasesColumn = colCount + 1;
                    worksheet.Cells[1, purchasesColumn] = "Purchases";
                }

                // Find the user's row and update purchases
                for (int i = 2; i <= rowCount; i++)
                {
                    if (worksheet.Cells[i, 2].Value2?.ToString() == UserSession.Instance.Username)
                    {
                        worksheet.Cells[i, purchasesColumn] = purchasesString;
                        break;
                    }
                }

                workbook.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving purchases: " + ex.Message);
            }
            finally
            {
                if (workbook != null)
                {
                    workbook.Close(true);  // Change this to true
                    Marshal.ReleaseComObject(workbook);
                }
                excelApp.Quit();
                Marshal.ReleaseComObject(excelApp);
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
        }
        private void UpdateCoinsInDocument(string username, int coins)
        {
            _Excel.Application excelApp = new _Excel.Application();
            if (excelApp == null)
            {
                MessageBox.Show("Excel is not properly installed!");
                return;
            }

            excelApp.Visible = false;
            string filePath = System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(), "SignupData.xlsx");
            _Excel.Workbook workbook;
            _Excel.Worksheet worksheet;

            try
            {
                workbook = excelApp.Workbooks.Open(filePath); // Try to open an existing workbook
                worksheet = (_Excel.Worksheet)workbook.Sheets[1]; // Access the first sheet
            }
            catch
            {
                MessageBox.Show("Unable to open the specified Excel file.");
                return;
            }

            // Find the user in the Excel file and update the coins
            int rowCount = worksheet.UsedRange.Rows.Count;
            for (int i = 2; i <= rowCount; i++)
            {
                if ((string)(worksheet.Cells[i, 2] as _Excel.Range).Value == username)
                {
                    worksheet.Cells[i, 6] = coins;
                    break;
                }
            }

            // Save changes and close
            workbook.Save();
            workbook.Close(true);
            excelApp.Quit();

            // Release COM objects to fully kill Excel process from running in the background
            Marshal.ReleaseComObject(worksheet);
            Marshal.ReleaseComObject(workbook);
            Marshal.ReleaseComObject(excelApp);

            // Clear unreferenced COM objects
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }


        private void logoutButton_Click(object sender, EventArgs e)
        {
            SavePurchasesToExcel();

            // Update coins in the document
            UpdateCoinsInDocument(UserSession.Instance.Username, UserSession.Instance.Coins);


            // Clear the user session
            UserSession.Instance.Clear();

            // Navigate back to the login form
            Login loginForm = new Login();
            this.Hide();
            loginForm.ShowDialog();
            this.Close();
        }

        private void stStickersBtn_Click(object sender, EventArgs e)
        {
            // Add event handler logic here if needed
        }



        private void headerLabel_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void gameButton1_Click_1(object sender, EventArgs e)
        {
            //*
            ////// Navigate to Math Aliens Game
            MathGameForm mathGame = new MathGameForm();
            this.Hide();
            mathGame.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //*
            //// Navigate to Store
            BiggerSmallerEqualsGame mathGame2 = new BiggerSmallerEqualsGame();
            this.Hide();
            mathGame2.ShowDialog();
            this.Close();
        }

        private void stHomeBtn_Click(object sender, EventArgs e)
        {
            //*
            this.Hide();
            HomePage stHomePage = new HomePage();
            stHomePage.ShowDialog();
            this.Close();
        }

        private void gameButton2_Click_1(object sender, EventArgs e)
        {
            //*
            ////// Navigate to Math Game
            BiggerSmallerEqualsGame mathGame = new BiggerSmallerEqualsGame();
            this.Hide();
            mathGame.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SavePurchasesToExcel();

            // Update coins in the document
            UpdateCoinsInDocument(UserSession.Instance.Username, UserSession.Instance.Coins);


            // Clear the user session
            UserSession.Instance.Clear();

            // Navigate back to the login form
            Login loginForm = new Login();
            this.Hide();
            loginForm.ShowDialog();
            this.Close();
        }

        private void gameImage1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}