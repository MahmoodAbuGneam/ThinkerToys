using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using _Excel = Microsoft.Office.Interop.Excel;


namespace ThinkerToys
{
    //To-Do tasks : remove the comment from * 
    public partial class HebrewGamesTogether : Form
    {
        public HebrewGamesTogether()
        {
            InitializeComponent();
            this.Load += Form1_Load; // Attach to Load event for initial positioning
            this.SizeChanged += Form1_SizeChanged; // Attach SizeChanged event for dynamic resizing
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //*//button2.Text = UserSession.Instance.Coins;
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
        private void gameButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Starting Matching Letters");
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

        private void logoutButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Logging out");
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
            button2.Text = UserSession.Instance.Coins.ToString();

        }

        private void gameButton1_Click_1(object sender, EventArgs e)
        {
            //*
            ////// Navigate to Hebrew Matching Game
            HebrewMainMenu hebrew2 = new HebrewMainMenu();
            this.Hide();
            hebrew2.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //*
            //// Navigate to Store
            StoreSectForm1 storeForm = new StoreSectForm1();
            this.Hide();
            storeForm.ShowDialog();
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
            ////// Navigate to Space letters Game
            LevelSelectionForm spaceletters = new LevelSelectionForm();
            this.Hide();
            spaceletters.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //*
            //// Update coins in the document
            UpdateCoinsInDocument(UserSession.Instance.Username, UserSession.Instance.Coins);

            //// Clear the user session
            UserSession.Instance.Clear();

            //// Navigate back to the login form
            Login loginForm = new Login();
            this.Hide();
            loginForm.ShowDialog();
            this.Close();
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


        private void gameImage1_Click(object sender, EventArgs e)
        {

        }
    }
}