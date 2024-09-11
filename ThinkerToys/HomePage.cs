using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
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

        private void HomePage_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Update coins in the document
            UpdateCoinsInDocument(UserSession.Instance.Username, UserSession.Instance.Coins);
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

        private void HomePage_Load(object sender, EventArgs e)
        {
            // Display user information
            usernameLabel.Text = $"{UserSession.Instance.Username}";
            coinsLabel.Text = $"Coins: {UserSession.Instance.Coins}";
        }

        // Event handler for Store card click
        private void StoreCard_Click(object sender, EventArgs e)
        {
            // Navigate to Store
            StoreSectForm1 storeForm = new StoreSectForm1();
            this.Hide();
            storeForm.ShowDialog();
            this.Close();
        }

        // Event handler for English Games card click
        private void EnglishGamesCard_Click(object sender, EventArgs e)
        {

        }

        // Event handler for Math Games card click
        private void MathGamesCard_Click(object sender, EventArgs e)
        {

        }

        // Event handler for Hebrew Games card click
        private void HebrewGamesCard_Click(object sender, EventArgs e)
        {

        }

        // Event handler for Profile card click
        private void ProfileCard_Click(object sender, EventArgs e)
        {

        }

        private void headerLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void storeImage_Click(object sender, EventArgs e)
        {
            // Navigate to Store
            StoreSectForm1 storeForm = new StoreSectForm1();
            this.Hide();
            storeForm.ShowDialog();
            this.Close();
        }

        private void englishGamesImage_Click(object sender, EventArgs e)
        {
            EnglishGamesTogether englishTogether = new EnglishGamesTogether();
            this.Hide();
            englishTogether.ShowDialog();
            this.Close();
        }

        private void mathGamesImage_Click(object sender, EventArgs e)
        {
            // Navigate to Math Games section
            MathGamesTogether mathGames = new MathGamesTogether();
            this.Hide();
            mathGames.ShowDialog();
            this.Close();
        }

        private void hebrewGamesImage_Click(object sender, EventArgs e)
        {
            HebrewGamesTogether hebrewTogether = new HebrewGamesTogether();
            this.Hide();
            hebrewTogether.ShowDialog();
            this.Close();
        }

        private void profileImage_Click(object sender, EventArgs e)
        {
            ProfileForm profile = new ProfileForm();
            this.Hide();
            profile.ShowDialog();
            this.Close();
        }

        private void profileLabel_Click(object sender, EventArgs e)
        {

        }


        private void label1_Click_1(object sender, EventArgs e) // log out label 
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e) // logout picture box 
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Perform logout actions
                LogoutUser();

                // Navigate back to the Login form
                Login loginForm = new Login();
                this.Hide();
                loginForm.ShowDialog();
                this.Close();
            }
        }

        private void LogoutUser()
        {
            // Clear the current user session
            UserSession.Instance.Clear();

            // Update coins in the document before logging out
            UpdateCoinsInDocument(UserSession.Instance.Username, UserSession.Instance.Coins);
        }


    }
}
