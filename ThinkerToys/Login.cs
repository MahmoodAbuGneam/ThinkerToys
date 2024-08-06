using System.Text.RegularExpressions;
using System;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using _Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;

namespace ThinkerToys
{
    public partial class Login : Form
    {
        private const int Shift = 9;
        private string currentUsername;
        private int currentUserCoins;

        public Login()
        {
            InitializeComponent();
        }

        private string EncryptText(string input, int shifter = Shift)
        {
            char[] buffer = input.ToCharArray();
            for (int i = 0; i < buffer.Length; i++)
            {
                char letter = buffer[i];
                if (char.IsLetter(letter))
                {
                    char letterOffset = char.IsUpper(letter) ? 'A' : 'a';
                    letter = (char)((((letter + shifter) - letterOffset) % 26) + letterOffset);
                }
                buffer[i] = letter;
            }
            return new string(buffer);
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string username = UsernameTextBox.Text;
            string password = EncryptText(PasswordTextBox.Text);

            // check the username and password using the validators
            if (!ValidateUsername(username) || !ValidatePassword(password))
            {
                MessageBox.Show("Invalid username or password format.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Authenticate the user using Excel data
            if (AuthenticateUser(username, password))
            {
                // Initialize user session
                UserSession.Instance.Initialize(currentUsername, currentUserCoins);
                MessageBox.Show($"Login successful!\nUsername: {currentUsername}\nCoins: {currentUserCoins}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Navigate to the homepage
                HomePage homePage = new HomePage();
                this.Hide();
                homePage.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Login failed. Please check your username and password.", "Authentication Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Excel authentication
        private bool AuthenticateUser(string username, string encryptedPassword)
        {
            _Excel.Application excelApp = new _Excel.Application();
            if (excelApp == null)
            {
                MessageBox.Show("Excel is not properly installed!");
                return false;
            }

            string filePath = System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(), "SignupData.xlsx");

            _Excel.Workbook workbook;
            _Excel.Worksheet worksheet;

            try
            {
                workbook = excelApp.Workbooks.Open(filePath);
                worksheet = (_Excel.Worksheet)workbook.Sheets[1];
                int row = 2; // row 1 is the titles and headers

                while (worksheet.Cells[row, 2].Value2 != null)
                {
                    string storedUsername = worksheet.Cells[row, 2].Value2.ToString();
                    string storedPassword = worksheet.Cells[row, 3].Value2.ToString();
                    int storedCoins = int.Parse(worksheet.Cells[row, 6].Value2.ToString());

                    if (storedUsername == username && storedPassword == encryptedPassword)
                    {
                        currentUsername = storedUsername;
                        currentUserCoins = storedCoins;

                        // Find the "Purchases" column
                        int purchasesColumn = 0;
                        for (int i = 1; i <= worksheet.UsedRange.Columns.Count; i++)
                        {
                            if (worksheet.Cells[1, i].Value2?.ToString() == "Purchases")
                            {
                                purchasesColumn = i;
                                break;
                            }
                        }

                        if (purchasesColumn > 0)
                        {
                            string purchasesString = worksheet.Cells[row, purchasesColumn].Value2?.ToString();
                            if (!string.IsNullOrEmpty(purchasesString))
                            {
                                UserSession.Instance.Purchases = purchasesString
                                    .Split(';')
                                    .Select(s => s.Split(':'))
                                    .ToDictionary(s => s[0], s => int.Parse(s[1]));
                            }
                        }

                        workbook.Close(false);
                        excelApp.Quit();
                        Marshal.ReleaseComObject(worksheet);
                        Marshal.ReleaseComObject(workbook);
                        Marshal.ReleaseComObject(excelApp);

                        return true;
                    }
                    row++;
                }

                workbook.Close(false);
                excelApp.Quit();
                Marshal.ReleaseComObject(worksheet);
                Marshal.ReleaseComObject(workbook);
                Marshal.ReleaseComObject(excelApp);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to open Excel file: " + ex.Message);
                return false;
            }

            return false;
        }

        private bool ValidateUsername(string username)
        {
            return username.Length >= 6 && username.Length <= 16 && Regex.IsMatch(username, "^[a-zA-Z]+$");
        }

        private bool ValidatePassword(string password)
        {
            return password.Length >= 8 && password.Length <= 16 &&
                   Regex.IsMatch(password, @"[!@#$%^&*(),.?\[\]{}|<>]") &&
                   Regex.IsMatch(password, @"\d") &&
                   Regex.IsMatch(password, "[a-zA-Z]");
        }

        private void Login_Load(object sender, EventArgs e) { }

        private void LeftPanel_Paint(object sender, PaintEventArgs e) { }

        private void CreateAccountLabel_Click(object sender, EventArgs e) { }

        private void SignUpLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Signup signup = new Signup();
            signup.ShowDialog();
            this.Close();
        }

        private void LoginLabel_Click(object sender, EventArgs e) { }

        private void UsernameLabel_Click(object sender, EventArgs e) { }

        private void PasswordLabel_Click(object sender, EventArgs e) { }

        private void UsernameTextBox_TextChanged(object sender, EventArgs e) { }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e) { }

        private void showPassCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (showPassCheckBox.Checked)
            {
                // If checked, show the characters in the password field
                PasswordTextBox.PasswordChar = '\0'; 
            }
            else
            {
                // If not checked, mask the characters in the password field
                PasswordTextBox.PasswordChar = '•'; 
            }
        }
    }
}
