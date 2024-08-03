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
            _Excel.Application excelApp = new _Excel.Application();
            _Excel.Workbook workbook = null;
            _Excel.Worksheet worksheet = null;

            try
            {
                string filePath = System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(), "SignupData.xlsx");
                workbook = excelApp.Workbooks.Open(filePath);
                worksheet = (_Excel.Worksheet)workbook.Sheets[1];

                int rowCount = worksheet.Cells.SpecialCells(_Excel.XlCellType.xlCellTypeLastCell, Type.Missing).Row;

                for (int i = 2; i <= rowCount; i++) //row 1 has headers
                {
                    if (worksheet.Cells[i, 1].Value.ToString() == idNumber)
                    {
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error checking ID: " + ex.Message);
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



        // check if the username already exists.
        private bool UsernameExists(string username)
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

                for (int i = 2; i <= rowCount; i++) //row 1 has headers
                {
                    if (worksheet.Cells[i, 2].Value.ToString() == username)
                    {
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error checking username: " + ex.Message);
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
                // all inputs are good , we can save it in the database ( excel file )
                SaveDataToExcel(idNumber, username, encryptedPassword, email, gender);
                MessageBox.Show("Signup successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void SaveDataToExcel(string idNumber, string username, string password, string Email, string gender)
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

            // Check if headers are not already created
            if (worksheet.Cells[1, 1].Value == null)
            {
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
            int emptyRow = worksheet.Cells.SpecialCells(_Excel.XlCellType.xlCellTypeLastCell, Type.Missing).Row + 1;

            // Write data
            worksheet.Cells[emptyRow, 1] = idNumber;
            worksheet.Cells[emptyRow, 2] = username;
            worksheet.Cells[emptyRow, 3] = password;
            worksheet.Cells[emptyRow, 4] = Email;
            worksheet.Cells[emptyRow, 5] = gender;
            worksheet.Cells[emptyRow, 6] = 0; // Initialize coins to 0
            worksheet.Cells[emptyRow, 7] = false; // IsConfirmed
            worksheet.Cells[emptyRow, 8] = GenerateOTP(); // OTP
            worksheet.Cells[emptyRow, 9] = DateTime.Now.AddMinutes(10); // OTPExpiryTime

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
    }
}