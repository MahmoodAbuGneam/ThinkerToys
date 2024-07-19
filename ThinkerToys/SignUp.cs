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
                // All inputs are valid, proceed with signup
                MessageBox.Show("Signup successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Add further logic here, such as saving user data or navigating to another form
            }
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
    }
}