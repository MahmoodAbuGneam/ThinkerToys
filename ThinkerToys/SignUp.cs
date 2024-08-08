using System;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using _Excel = Microsoft.Office.Interop.Excel;




namespace ThinkerToys
{
    public partial class Signup : Form
    {


        private const int Shift = 9;
        public Signup()
        {
            InitializeComponent();
        }



        // check if ID already exists . 
        private bool IDExists(string idNumber)
        {
            return CheckExcelForExistingData(idNumber, 1);
        }





        // check if the username already exists.
        private bool UsernameExists(string username)
        {
            return CheckExcelForExistingData(username, 2);
        }


        // check if the email address already exists.
        private bool EmailExists(string email)
        {
            _Excel.Application excelApp = new _Excel.Application();
            _Excel.Workbook workbook = null;
            _Excel.Worksheet worksheet = null;

            try
            {
                string filePath = System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(), "SignupData.xlsx");
                workbook = excelApp.Workbooks.Open(filePath);
                worksheet = (_Excel.Worksheet)workbook.Sheets[1];

                int rowCount = worksheet.Cells.SpecialCells(_Excel.XlCellType.xlCellTypeLastCell, Type.Missing).Row;

                for (int i = 2; i <= rowCount; i++) // Assuming row 1 has headers
                {
                    if (worksheet.Cells[i, 4].Value != null && worksheet.Cells[i, 4].Value.ToString().ToLower() == email.ToLower())
                    {
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error checking email: " + ex.Message);
            }
            finally
            {
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

        private string DecryptText(string input)
        {
            return EncryptText(input, -Shift);
        }

        private bool ValidateIDNumber(string idNumber)
        {
            return !string.IsNullOrWhiteSpace(idNumber) && idNumber.Length == 9 && int.TryParse(idNumber, out _);
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

        private bool ValidateConfirmPassword(string password, string confirmPassword)
        {
            return password == confirmPassword;
        }
        private bool ValidateEmail(string email)
        {
            return Regex.IsMatch(email, @"^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,3})+$");
        }

        private void textBoxIDNumber_TextChanged(object sender, EventArgs e)
        {
            label7.Text = "";
        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {
            label8.Text = "";
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            label3.Text = "";
        }

        private void textBoxConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            label4.Text = "";
        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {
            label5.Text = "";
        }

        private void radioButtonBoy_CheckedChanged(object sender, EventArgs e)
        {
            GenderLabel.Text = "";
        }

        private void radioButtonGirl_CheckedChanged(object sender, EventArgs e)
        {
            GenderLabel.Text = "";
        }

        private void Signup_Load(object sender, EventArgs e)
        {

        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            // Gather user input
            string idNumber = textBoxIDNumber.Text;
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;
            string confirmPassword = textBoxConfirmPassword.Text;
            string email = textBoxEmail.Text;
            string gender = radioButtonBoy.Checked ? "Boy" : (radioButtonGirl.Checked ? "Girl" : "");




            // Check if the id exists or not and print an error if not . 
            if (IDExists(idNumber))
            {
                MessageBox.Show("An account with this ID already exists.", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (UsernameExists(username))
            {
                MessageBox.Show("This username is already taken.", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            // Check if the id exists or not and print an error if not . 
            if (EmailExists(email))
            {
                MessageBox.Show("This email is already registered.", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



            // Encrypt the password 

            string encryptedPassword = EncryptText(password);





            // Validate inputs
            bool isValidIDNumber = ValidateIDNumber(idNumber);
            bool isValidUsername = ValidateUsername(username);
            bool isValidPassword = ValidatePassword(password);
            bool isValidConfirmPassword = ValidateConfirmPassword(password, confirmPassword);
            bool isValidEmail = ValidateEmail(email);
            bool isGenderSelected = !string.IsNullOrEmpty(gender);

            // Check for errors and show message boxes
            if (!isValidIDNumber)
                MessageBox.Show("Invalid ID Number. Please enter a valid ID.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (!isValidUsername)
                MessageBox.Show("Invalid username. Username must be between 6 and 16 characters long and contain only letters.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (!isValidPassword)
                MessageBox.Show("Invalid password. Password must be between 8 and 16 characters long, contain at least one special character, one number, and one letter.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (!isValidConfirmPassword)
                MessageBox.Show("Passwords do not match.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (!isValidEmail)
                MessageBox.Show("Invalid email address. Please enter a valid Email address.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (!isGenderSelected)
                MessageBox.Show("Please select a gender.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                string otp = GenerateOTP();
                SaveDataToExcel(idNumber, username, encryptedPassword, email, gender, otp);
                EmailSender.SendOTPEmail(email, otp);

                MessageBox.Show("Signup successful! Please check your email for the confirmation OTP.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                // open OTP confirmation form
                using (OTPConfirmationForm otpForm = new OTPConfirmationForm(username, email))
                {
                    this.Hide();
                    if(otpForm.ShowDialog() == DialogResult.OK)
                    {
                        // OTP confirmed successfully
                        MessageBox.Show("Account confirmed successfully!");
                        //  Open the login form application
                        Login loginForm = new Login();
                        this.Hide();
                        loginForm.ShowDialog();
                        this.Close();

                    }
                    else
                    {
                        // OTP confirmation failed or form was closed 
                        MessageBox.Show("Account confirmation failed . Please try again later .");
                    }
                }

                this.Close();
            }
        }


        private void SaveDataToExcel(string idNumber, string username, string password, string Email, string gender, string otp)
        {
            string filePath = System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(), "SignupData.xlsx");
            bool fileExists = System.IO.File.Exists(filePath);

            _Excel.Application excelApp = new _Excel.Application();
            _Excel.Workbook workbook = null;
            _Excel.Worksheet worksheet = null;

            try
            {
                excelApp.Visible = false;

                if (fileExists)
                {
                    workbook = excelApp.Workbooks.Open(filePath);
                    worksheet = workbook.Sheets[1];
                }
                else
                {
                    workbook = excelApp.Workbooks.Add();
                    worksheet = workbook.ActiveSheet;

                    // Create headers
                    worksheet.Cells[1, 1] = "ID Number";
                    worksheet.Cells[1, 2] = "Username";
                    worksheet.Cells[1, 3] = "Password";
                    worksheet.Cells[1, 4] = "Email Address";
                    worksheet.Cells[1, 5] = "Gender";
                    worksheet.Cells[1, 6] = "Coins";
                    worksheet.Cells[1, 7] = "IsConfirmed";
                    worksheet.Cells[1, 8] = "OTP";
                    worksheet.Cells[1, 9] = "OTPExpiryTime";
                }

                // Find the first empty row
                int newRow = 2; // Start from the second row (after headers)
                while (worksheet.Cells[newRow, 1].Value != null)
                {
                    newRow++;
                }

                // Write data
                worksheet.Cells[newRow, 1] = idNumber;
                worksheet.Cells[newRow, 2] = username;
                worksheet.Cells[newRow, 3] = password;
                worksheet.Cells[newRow, 4] = Email;
                worksheet.Cells[newRow, 5] = gender;
                worksheet.Cells[newRow, 6] = 0; // Initialize coins to 0
                worksheet.Cells[newRow, 7] = false; // IsConfirmed
                worksheet.Cells[newRow, 8] = otp; // OTP
                worksheet.Cells[newRow, 9] = DateTime.Now.AddMinutes(10); // OTPExpiryTime

                if (fileExists)
                {
                    workbook.Save();
                }
                else
                {
                    workbook.SaveAs(filePath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in SaveDataToExcel: " + ex.Message);
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
        private dynamic GenerateOTP()
        {
            Random random = new Random();
            return random.Next(100000, 999999).ToString();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBoxIDNumber_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBoxPassword_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void AlreadyHaveAccLabel_Click(object sender, EventArgs e)
        {

        }

        private void LoginAccLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
            this.Close();
        }

        private void textBoxEmail_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }





        private bool CheckExcelForExistingData(string value, int columnIndex)
        {
            string filePath = System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(), "SignupData.xlsx");

            if (!System.IO.File.Exists(filePath))
            {
                return false;
            }

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
                    if (worksheet.Cells[i, columnIndex].Value?.ToString() == value)
                    {
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error checking data: " + ex.Message);
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
    }
}