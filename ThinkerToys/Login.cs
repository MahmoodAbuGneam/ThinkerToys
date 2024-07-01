using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ThinkerToys
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            // Handle login button click event
            string username = textBox1.Text;
            string password = textBox2.Text;

            // Validate username and password
            bool isValidUsername = ValidateUsername(username);
            bool isValidPassword = ValidatePassword(password);

            // Update error labels
            label7.Text = isValidUsername ? "" : "Invalid username. Username must be between 6 and 8 characters long and contain only letters.";
            label8.Text = isValidPassword ? "" : "Invalid password. Password must be between 8 and 10 characters long, contain at least one special character, one number, and one letter.";

            if (isValidUsername && isValidPassword)
            {
                // Clear any previous success message
                label9.Text = "Login successful!";
                // Add further logic here, such as navigating to another form or executing additional actions
            }
            else
            {
                // Clear success message if there's any
                label9.Text = "";
            }
        }
        private bool ValidateUsername(string username)
        {
            // Example validation method for username
            return username.Length >= 6 && username.Length <= 8 && System.Text.RegularExpressions.Regex.IsMatch(username, "^[a-zA-Z]+$");
        }

        private bool ValidatePassword(string password)
        {
            // Example validation method for password
            return password.Length >= 8 && password.Length <= 10 &&
                System.Text.RegularExpressions.Regex.IsMatch(password, @"[!@#$%^&*(),.?\[\]{}|<>]") &&
                System.Text.RegularExpressions.Regex.IsMatch(password, @"\d") &&
                System.Text.RegularExpressions.Regex.IsMatch(password, "[a-zA-Z]");
        }
        private void kryptonTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

       

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
