using System;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
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

        private bool ValidateParentPhone(string phone)
        {

            return Regex.IsMatch(phone, @"^\d{10}$");
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

        private void textBoxParentPhone_TextChanged(object sender, EventArgs e)
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
            string parentPhone = textBoxParentPhone.Text;
            string gender = radioButtonBoy.Checked ? "Boy" : (radioButtonGirl.Checked ? "Girl" : "");



            // Encrypt the password 

            string encryptedPassword = EncryptText(password);





            // Validate inputs
            bool isValidIDNumber = ValidateIDNumber(idNumber);
            bool isValidUsername = ValidateUsername(username);
            bool isValidPassword = ValidatePassword(password);
            bool isValidConfirmPassword = ValidateConfirmPassword(password, confirmPassword);
            bool isValidParentPhone = ValidateParentPhone(parentPhone);
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
            else if (!isValidParentPhone)
                MessageBox.Show("Invalid phone number. Please enter a valid phone number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (!isGenderSelected)
                MessageBox.Show("Please select a gender.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                // all inputs are good , we can save it in the database ( excel file )
                SaveDataToExcel(idNumber, username, encryptedPassword, parentPhone, gender);
                MessageBox.Show("Signup successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void SaveDataToExcel(string idNumber, string username, string password, string parentPhone, string gender)
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
                worksheet.Cells[1, 4] = "Parent Phone";
                worksheet.Cells[1, 5] = "Gender";
                worksheet.Cells[1, 6] = "Coins";
            }

            // Find the first empty row
            int emptyRow = worksheet.Cells.SpecialCells(_Excel.XlCellType.xlCellTypeLastCell, Type.Missing).Row + 1;

            // Write data
            worksheet.Cells[emptyRow, 1] = idNumber;
            worksheet.Cells[emptyRow, 2] = username;
            worksheet.Cells[emptyRow, 3] = password; 
            worksheet.Cells[emptyRow, 4] = parentPhone;
            worksheet.Cells[emptyRow, 5] = gender;
            worksheet.Cells[emptyRow, 6] = 0; // Initialize coins to 0


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
    }
}