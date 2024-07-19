using ComponentFactory.Krypton.Toolkit;
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

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


        private void LoginButton_Click(object sender, EventArgs e)
        {

        }

        private void SignUpLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Signup signup = new Signup();
            signup.ShowDialog();
            this.Close();
        }

        private void LoginLabel_Click(object sender, EventArgs e)
        {

        }

        private void UsernameLabel_Click(object sender, EventArgs e)
        {

        }

        private void PasswordLabel_Click(object sender, EventArgs e)
        {

        }


        private void UsernameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void showPassCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
