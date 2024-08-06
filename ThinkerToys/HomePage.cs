
using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using _Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;


namespace ThinkerToys
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(HomePage_FormClosing);
        }


        private void HomePage_Load(object sender, EventArgs e)
        {
            // Display user information
            usernameLabel.Text = $"User: {UserSession.Instance.Username}";
            coinsLabel.Text = $"Coins: {UserSession.Instance.Coins}";
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
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


        private void mathGameButton_Click(object sender, EventArgs e)
        {
            // Navigate to Math Game
            // MathGameForm mathGameForm = new MathGameForm();
            // this.Hide();
            // mathGameForm.ShowDialog();
            // this.Close();
        }

        private void hebrewGameButton_Click(object sender, EventArgs e)
        {
            // Navigate to Hebrew Game
            // HebrewGameForm hebrewGameForm = new HebrewGameForm();
            // this.Hide();
            // hebrewGameForm.ShowDialog();
            // this.Close();
        }

        private void englishGameButton_Click(object sender, EventArgs e)
        {
            // Navigate to English Game
            // EnglishGameForm englishGameForm = new EnglishGameForm();
            // this.Hide();
            // englishGameForm.ShowDialog();
            // this.Close();
        }

        private void storeButton_Click(object sender, EventArgs e)
        {
            // Navigate to Store
            StoreSectForm1 storeForm = new StoreSectForm1();
            this.Hide();
            storeForm.ShowDialog();
            this.Close();
        }

        private void profileButton_Click(object sender, EventArgs e)
        {
            // Navigate to Profile Management
            // ProfileForm profileForm = new ProfileForm();
            // this.Hide();
            // profileForm.ShowDialog();
            // this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void usernameLabel_Click(object sender, EventArgs e)
        {

        }

        private void debugButton_Click(object sender, EventArgs e)
        {
            // Change the value of coins for debugging
            UserSession.Instance.Coins += 10; // Increase coins by 10 for testing
            coinsLabel.Text = $"Coins: {UserSession.Instance.Coins}";
        }


        private void HomePage_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Update coins in the document
            UpdateCoinsInDocument(UserSession.Instance.Username, UserSession.Instance.Coins);
        }


        public void UpdateCoinsInDocument(string username, int coins)
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


    }
}
