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
        private string currentUserEmail;
        private string currentUserID;
        private DateTime currentUserSignupDate;
        private string currentUserGender;


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
            if (AuthenticateUser(username, password, out bool isConfirmed))
            {
                if (isConfirmed)
                {
                    // Account is confirmed, proceed with login
                    UserSession.Instance.Initialize(currentUsername, currentUserCoins, currentUserEmail, currentUserID, currentUserSignupDate, currentUserGender);
                    MessageBox.Show($"Login successful!\nUsername: {currentUsername}\nCoins: {currentUserCoins}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Navigate to the homepage
                    HomePage homePage = new HomePage();
                    this.Hide();
                    homePage.ShowDialog();
                    this.Close();
                }
                else
                {
                    // Account is not confirmed, ask user if they want to confirm now
                    var result = MessageBox.Show("Your account is not confirmed. Do you want to confirm it now?", "Account Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        // Generate and send new OTP
                        string newOTP = GenerateOTP();
                        if (SendOTPEmail(currentUserEmail, newOTP))
                        {
                            // Update OTP in Excel file
                            UpdateOTPInExcel(username, newOTP);

                            // Open OTP confirmation form
                            using (OTPConfirmationForm otpForm = new OTPConfirmationForm(username, currentUserEmail))
                            {
                                if (otpForm.ShowDialog() == DialogResult.OK)
                                {
                                    MessageBox.Show("Account confirmed successfully! You can now log in.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show("Account confirmation failed. Please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Failed to send OTP email. Please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Login failed. Please check your username and password.", "Authentication Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Excel authentication
        //private bool AuthenticateUser(string username, string encryptedPassword, out bool isConfirmed)
        //{
        //    isConfirmed = false;
        //    _Excel.Application excelApp = new _Excel.Application();
        //    if (excelApp == null)
        //    {
        //        MessageBox.Show("Excel is not properly installed!");
        //        return false;
        //    }

        //    string filePath = System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(), "SignupData.xlsx");

        //    _Excel.Workbook workbook = null;
        //    _Excel.Worksheet worksheet = null;

        //    try
        //    {
        //        workbook = excelApp.Workbooks.Open(filePath);
        //        worksheet = (_Excel.Worksheet)workbook.Sheets[1];
        //        int row = 2;

        //        while (worksheet.Cells[row, 2].Value2 != null)
        //        {
        //            string storedUsername = worksheet.Cells[row, 2].Value2.ToString();
        //            string storedPassword = worksheet.Cells[row, 3].Value2.ToString();
        //            int storedCoins = int.Parse(worksheet.Cells[row, 6].Value2.ToString());
        //            bool accountConfirmed = Convert.ToBoolean(worksheet.Cells[row, 7].Value2);

        //            if (storedUsername == username && storedPassword == encryptedPassword)
        //            {
        //                string userID = worksheet.Cells[row, 1].Value2.ToString();
        //                string userEmail = worksheet.Cells[row, 4].Value2.ToString();
        //                DateTime signupDate = DateTime.Parse(worksheet.Cells[row, 10].Value2.ToString());
        //                string gender = worksheet.Cells[row, 5].Value2.ToString(); // Assuming gender is in column 5
        //                isConfirmed = accountConfirmed;

        //                // Initialize UserSession with all the data
        //                UserSession.Instance.Initialize(storedUsername, storedCoins, userEmail, userID, signupDate, gender);

        //                // Find and load purchases (if any)
        //                int purchasesColumn = FindPurchasesColumn(worksheet);
        //                if (purchasesColumn > 0)
        //                {
        //                    string purchasesString = worksheet.Cells[row, purchasesColumn].Value2?.ToString();
        //                    if (!string.IsNullOrEmpty(purchasesString))
        //                    {
        //                        UserSession.Instance.Purchases = purchasesString
        //                            .Split(';')
        //                            .Select(s => s.Split(':'))
        //                            .ToDictionary(s => s[0], s => int.Parse(s[1]));
        //                    }
        //                }

        //                return true;
        //            }
        //            row++;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error authenticating user: " + ex.Message);
        //    }
        //    finally
        //    {
        //        if (worksheet != null) Marshal.ReleaseComObject(worksheet);
        //        if (workbook != null)
        //        {
        //            workbook.Close(false);
        //            Marshal.ReleaseComObject(workbook);
        //        }
        //        excelApp.Quit();
        //        Marshal.ReleaseComObject(excelApp);
        //        GC.Collect();
        //        GC.WaitForPendingFinalizers();
        //    }
        //    return false;
        //}





        private bool AuthenticateUser(string username, string encryptedPassword, out bool isConfirmed)
        {
            isConfirmed = false;
            _Excel.Application excelApp = new _Excel.Application();
            if (excelApp == null)
            {
                MessageBox.Show("Excel is not properly installed!");
                return false;
            }

            string filePath = System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(), "SignupData.xlsx");

            _Excel.Workbook workbook = null;
            _Excel.Worksheet worksheet = null;

            try
            {
                workbook = excelApp.Workbooks.Open(filePath);
                worksheet = (_Excel.Worksheet)workbook.Sheets[1];
                int row = 2;

                while (worksheet.Cells[row, 2].Value2 != null)
                {
                    string storedUsername = worksheet.Cells[row, 2].Value2.ToString();
                    string storedPassword = worksheet.Cells[row, 3].Value2.ToString();
                    int storedCoins = int.Parse(worksheet.Cells[row, 6].Value2.ToString());
                    bool accountConfirmed = Convert.ToBoolean(worksheet.Cells[row, 7].Value2);

                    if (storedUsername.ToLower() == username.ToLower() && storedPassword == encryptedPassword)
                    {
                        currentUsername = storedUsername;
                        currentUserCoins = storedCoins;
                        currentUserEmail = worksheet.Cells[row, 4].Value2.ToString();
                        currentUserID = worksheet.Cells[row, 1].Value2.ToString();

                        // Handle SignupDate
                        currentUserSignupDate = DateTime.Now; // Default to current date
                        if (worksheet.Cells[row, 10].Value2 != null)
                        {
                            if (worksheet.Cells[row, 10].Value2 is DateTime dateValue)
                            {
                                currentUserSignupDate = dateValue;
                            }
                            else if (double.TryParse(worksheet.Cells[row, 10].Value2.ToString(), out double excelDate))
                            {
                                currentUserSignupDate = DateTime.FromOADate(excelDate);
                            }
                        }

                        currentUserGender = worksheet.Cells[row, 5].Value2.ToString();
                        isConfirmed = accountConfirmed;

                        // Find and load purchases (if any)
                        int purchasesColumn = FindPurchasesColumn(worksheet);
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

                        return true;
                    }
                    row++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error authenticating user: " + ex.Message);
            }
            finally
            {
                if (worksheet != null) Marshal.ReleaseComObject(worksheet);
                if (workbook != null)
                {
                    workbook.Close(false);
                    Marshal.ReleaseComObject(workbook);
                }
                excelApp.Quit();
                Marshal.ReleaseComObject(excelApp);
                GC.Collect();
                GC.WaitForPendingFinalizers();
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


        private int FindPurchasesColumn(_Excel.Worksheet worksheet)
        {
            int lastColumn = worksheet.UsedRange.Columns.Count;
            for (int i = 1; i <= lastColumn; i++)
            {
                if (worksheet.Cells[1, i].Value2?.ToString() == "Purchases")
                {
                    return i;
                }
            }
            return -1;
        }



        private string GenerateOTP()
        {
            Random random = new Random();
            return random.Next(100000, 999999).ToString();
        }

        private bool SendOTPEmail(string email, string otp)
        {
            try
            {
                EmailSender.SendOTPEmail(email, otp);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error sending OTP email: {ex.Message}", "Email Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void UpdateOTPInExcel(string username, string newOTP)
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
                    if (worksheet.Cells[i, 2].Value.ToString() == username)
                    {
                        worksheet.Cells[i, 8] = newOTP; // Assuming OTP is in column 8
                        worksheet.Cells[i, 9] = DateTime.Now.AddMinutes(10); // OTP expiry time
                        break;
                    }
                }

                workbook.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating OTP in Excel: {ex.Message}", "Excel Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

    }
}
