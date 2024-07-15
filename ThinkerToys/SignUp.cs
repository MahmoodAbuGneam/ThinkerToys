using System;
using System.Reflection.Emit;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ThinkerToys
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        private void kryptonButtonSignup_Click(object sender, EventArgs e)
        {
            // Handle signup button click event
            string idNumber = textBoxIDNumber.Text;
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;
            string confirmPassword = textBoxConfirmPassword.Text;
            string parentPhone = textBoxParentPhone.Text;
            string gender = radioButtonBoy.Checked ? "Boy" : (radioButtonGirl.Checked ? "Girl" : "");

            // Validate inputs
            bool isValidIDNumber = ValidateIDNumber(idNumber);
            bool isValidUsername = ValidateUsername(username);
            bool isValidPassword = ValidatePassword(password);
            bool isValidConfirmPassword = ValidateConfirmPassword(password, confirmPassword);
            bool isValidParentPhone = ValidateParentPhone(parentPhone);
            bool isGenderSelected = !string.IsNullOrEmpty(gender);

            // Update error labels
            label7.Text = isValidIDNumber ? "" : "Invalid ID Number. Please enter a valid ID.";
            label8.Text = isValidUsername ? "" : "Invalid username. Username must be between 6 and 8 characters long and contain only letters.";
            label3.Text = isValidPassword ? "" : "Invalid password. Password must be between 8 and 10 characters long, contain at least one special character, one number, and one letter.";
            label4.Text = isValidConfirmPassword ? "" : "Passwords do not match.";
            label5.Text = isValidParentPhone ? "" : "Invalid phone number. Please enter a valid phone number.";
            label6.Text = isGenderSelected ? "" : "Please select a gender.";

            if (isValidIDNumber && isValidUsername && isValidPassword && isValidConfirmPassword && isValidParentPhone && isGenderSelected)
            {
                // All inputs are valid, proceed with signup
                label9.Text = "Signup successful!";
                // Add further logic here, such as saving user data or navigating to another form
            }
            else
            {
                label9.Text = "";
            }
        }

        private bool ValidateIDNumber(string idNumber)
        {
            // Implement ID number validation logic
            // This is a simple example; adjust as needed
            return !string.IsNullOrWhiteSpace(idNumber) && idNumber.Length == 8 && int.TryParse(idNumber, out _);
        }

        private bool ValidateUsername(string username)
        {
            return username.Length >= 6 && username.Length <= 8 && Regex.IsMatch(username, "^[a-zA-Z]+$");
        }

        private bool ValidatePassword(string password)
        {
            return password.Length >= 8 && password.Length <= 10 &&
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
            // Implement phone number validation logic
            // This is a simple example; adjust as needed
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
            label6.Text = "";
        }

        private void radioButtonGirl_CheckedChanged(object sender, EventArgs e)
        {
            label6.Text = "";
        }

        private void Signup_Load(object sender, EventArgs e)
        {

        }
    }
}