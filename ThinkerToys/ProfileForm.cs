using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using _Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;

namespace ThinkerToys
{
    public partial class ProfileForm : Form
    {
        private TextBox usernameTextBox;
        private TextBox passwordTextBox;
        private Button saveButton;
        private Panel editPanel;

        public ProfileForm()
        {
            InitializeComponent();
            CustomizeForm();
        }

        private void CustomizeForm()
        {
            // Set up the form background color and properties
            this.BackColor = Color.White;
            this.Size = new Size(850, 850);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.Sizable;

            // Top Panel
            Panel topPanel = new Panel
            {
                BackColor = Color.RoyalBlue,
                Dock = DockStyle.Top,
                Height = 100
            };
            this.Controls.Add(topPanel);

            // Home Button
            Button homeButton = new Button
            {
                Text = "Home",
                Font = new Font("Arial", 12, FontStyle.Bold),
                ForeColor = Color.White,
                BackColor = Color.RoyalBlue,
                FlatStyle = FlatStyle.Flat,
                Size = new Size(100, 40),
                Location = new Point(20, 30),
                Cursor = Cursors.Hand
            };
            homeButton.FlatAppearance.BorderSize = 0;
            homeButton.Click += HomeButton_Click;
            topPanel.Controls.Add(homeButton);

            // Settings and Notification Icons
            PictureBox settingsIcon = new PictureBox
            {
                Size = new Size(24, 24),
                Location = new Point(this.Width - 70, 20),
                SizeMode = PictureBoxSizeMode.Zoom,
                Anchor = AnchorStyles.Top | AnchorStyles.Right,
                Image = Properties.Resources.settings_icon
            };
            topPanel.Controls.Add(settingsIcon);

            PictureBox notificationIcon = new PictureBox
            {
                Size = new Size(24, 24),
                Location = new Point(this.Width - 40, 20),
                SizeMode = PictureBoxSizeMode.Zoom,
                Anchor = AnchorStyles.Top | AnchorStyles.Right,
                Image = Properties.Resources.notification_icon
            };
            topPanel.Controls.Add(notificationIcon);

            // Profile Picture
            PictureBox profilePicture = new PictureBox
            {
                Size = new Size(150, 150),
                Location = new Point(this.Width / 2 - 75, topPanel.Bottom + 20),
                SizeMode = PictureBoxSizeMode.Zoom,
                Anchor = AnchorStyles.Top,
                Image = Properties.Resources.profile_image
            };
            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(0, 0, profilePicture.Width - 1, profilePicture.Height - 1);
            profilePicture.Region = new Region(gp);
            this.Controls.Add(profilePicture);

            // Name Label and Edit Icon
            Label nameLabel = new Label
            {
                Text = UserSession.Instance.Username,
                Font = new Font("Arial", 18, FontStyle.Bold),
                ForeColor = Color.DarkBlue,
                Location = new Point(this.Width / 2 - 75, profilePicture.Bottom + 10),
                AutoSize = true,
                Anchor = AnchorStyles.Top
            };
            this.Controls.Add(nameLabel);

            PictureBox editUsernameIcon = new PictureBox
            {
                Size = new Size(20, 20),
                Image = Properties.Resources.pencil_icon,
                SizeMode = PictureBoxSizeMode.Zoom,
                Location = new Point(nameLabel.Right + 10, nameLabel.Top + 5),
                Cursor = Cursors.Hand,
                Anchor = AnchorStyles.Top
            };
            editUsernameIcon.Click += (sender, e) => ShowEditPanel("username");
            this.Controls.Add(editUsernameIcon);

            // Email Label
            Label emailLabel = new Label
            {
                Text = $"Email: {UserSession.Instance.Email}",
                Font = new Font("Arial", 12, FontStyle.Regular),
                ForeColor = Color.DarkBlue,
                Location = new Point(this.Width / 2 - 75, nameLabel.Bottom + 5),
                AutoSize = true,
                Anchor = AnchorStyles.Top
            };
            this.Controls.Add(emailLabel);

            // ID Label
            Label idLabel = new Label
            {
                Text = $"ID: {UserSession.Instance.ID}",
                Font = new Font("Arial", 12, FontStyle.Regular),
                ForeColor = Color.DarkBlue,
                Location = new Point(this.Width / 2 - 75, emailLabel.Bottom + 5),
                AutoSize = true,
                Anchor = AnchorStyles.Top
            };
            this.Controls.Add(idLabel);

            // Edit Password Icon
            PictureBox editPasswordIcon = new PictureBox
            {
                Size = new Size(20, 20),
                Image = Properties.Resources.pencil_icon,
                SizeMode = PictureBoxSizeMode.Zoom,
                Location = new Point(this.Width / 2 - 75, idLabel.Bottom + 10),
                Cursor = Cursors.Hand,
                Anchor = AnchorStyles.Top
            };
            editPasswordIcon.Click += (sender, e) => ShowEditPanel("password");
            this.Controls.Add(editPasswordIcon);

            Label editPasswordLabel = new Label
            {
                Text = "Edit Password",
                Font = new Font("Arial", 10, FontStyle.Regular),
                ForeColor = Color.DarkBlue,
                Location = new Point(editPasswordIcon.Right + 5, editPasswordIcon.Top),
                AutoSize = true,
                Anchor = AnchorStyles.Top
            };
            this.Controls.Add(editPasswordLabel);

            // Edit Panel (initially hidden)
            editPanel = new Panel
            {
                Size = new Size(300, 150),
                Location = new Point(this.Width / 2 - 150, editPasswordIcon.Bottom + 20),
                Visible = false,
                BorderStyle = BorderStyle.FixedSingle,
                Anchor = AnchorStyles.Top
            };
            this.Controls.Add(editPanel);

            usernameTextBox = new TextBox
            {
                Location = new Point(10, 10),
                Size = new Size(280, 25),
                Font = new Font("Arial", 12)
            };
            editPanel.Controls.Add(usernameTextBox);

            passwordTextBox = new TextBox
            {
                Location = new Point(10, 45),
                Size = new Size(280, 25),
                Font = new Font("Arial", 12),
                UseSystemPasswordChar = true
            };
            editPanel.Controls.Add(passwordTextBox);

            saveButton = new Button
            {
                Text = "Save",
                Location = new Point(10, 80),
                Size = new Size(280, 30),
                Font = new Font("Arial", 12, FontStyle.Bold)
            };
            saveButton.Click += SaveButton_Click;
            editPanel.Controls.Add(saveButton);

            // Information Panel
            Panel infoPanel = new Panel
            {
                BackColor = Color.White,
                Size = new Size(this.Width - 40, 150),
                Location = new Point(20, editPanel.Bottom + 25),
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right,
                BorderStyle = BorderStyle.FixedSingle
            };
            this.Controls.Add(infoPanel);

            // Gender Section
            Label genderValue = new Label
            {
                Text = UserSession.Instance.Gender,
                Font = new Font("Arial", 16, FontStyle.Bold),
                ForeColor = Color.DarkBlue,
                TextAlign = ContentAlignment.MiddleCenter,
                Location = new Point(100, 20),
                AutoSize = true,
                Anchor = AnchorStyles.Top
            };
            infoPanel.Controls.Add(genderValue);

            PictureBox genderIcon = new PictureBox
            {
                Size = new Size(24, 24),
                Image = Properties.Resources.gender_icon,
                SizeMode = PictureBoxSizeMode.Zoom,
                Location = new Point(genderValue.Left + 20, genderValue.Bottom + 5),
                Anchor = AnchorStyles.Top
            };
            infoPanel.Controls.Add(genderIcon);

            // Coins Credit Section
            Label coinsValue = new Label
            {
                Text = UserSession.Instance.Coins.ToString(),
                Font = new Font("Arial", 16, FontStyle.Bold),
                ForeColor = Color.DarkBlue,
                TextAlign = ContentAlignment.MiddleCenter,
                Location = new Point(genderValue.Right + 150, 20),
                AutoSize = true,
                Anchor = AnchorStyles.Top
            };
            infoPanel.Controls.Add(coinsValue);

            PictureBox coinsIcon = new PictureBox
            {
                Size = new Size(24, 24),
                Image = Properties.Resources.coins_icon,
                SizeMode = PictureBoxSizeMode.Zoom,
                Location = new Point(coinsValue.Left + 20, coinsValue.Bottom + 5),
                Anchor = AnchorStyles.Top
            };
            infoPanel.Controls.Add(coinsIcon);

            // Date Joined Section
            Label dateJoinedValue = new Label
            {
                Text = UserSession.Instance.SignupDate.ToShortDateString(),
                Font = new Font("Arial", 16, FontStyle.Bold),
                ForeColor = Color.DarkBlue,
                TextAlign = ContentAlignment.MiddleCenter,
                Location = new Point(coinsValue.Right + 150, 20),
                AutoSize = true,
                Anchor = AnchorStyles.Top
            };
            infoPanel.Controls.Add(dateJoinedValue);

            PictureBox dateIcon = new PictureBox
            {
                Size = new Size(24, 24),
                Image = Properties.Resources.date_icon,
                SizeMode = PictureBoxSizeMode.Zoom,
                Location = new Point(dateJoinedValue.Left + 20, dateJoinedValue.Bottom + 5),
                Anchor = AnchorStyles.Top
            };
            infoPanel.Controls.Add(dateIcon);

            // My Purchases Label
            Label myPurchasesLabel = new Label
            {
                Text = "My Purchases",
                Font = new Font("Arial", 16, FontStyle.Bold),
                ForeColor = Color.DarkBlue,
                Location = new Point(20, infoPanel.Bottom + 20),
                AutoSize = true,
                Anchor = AnchorStyles.Top | AnchorStyles.Left
            };
            this.Controls.Add(myPurchasesLabel);

            // Display Purchases
            int yOffset = myPurchasesLabel.Bottom + 10;
            foreach (var purchase in UserSession.Instance.Purchases)
            {
                Label purchaseLabel = new Label
                {
                    Text = $"{purchase.Key}: {purchase.Value} item(s)",
                    Font = new Font("Arial", 12, FontStyle.Regular),
                    ForeColor = Color.DarkBlue,
                    Location = new Point(20, yOffset),
                    AutoSize = true,
                    Anchor = AnchorStyles.Top | AnchorStyles.Left
                };
                this.Controls.Add(purchaseLabel);
                yOffset += purchaseLabel.Height + 5;
            }

            if (!UserSession.Instance.Purchases.Any())
            {
                Label noPurchasesLabel = new Label
                {
                    Text = "No purchases yet.",
                    Font = new Font("Arial", 12, FontStyle.Italic),
                    ForeColor = Color.Gray,
                    Location = new Point(20, yOffset),
                    AutoSize = true,
                    Anchor = AnchorStyles.Top | AnchorStyles.Left
                };
                this.Controls.Add(noPurchasesLabel);
            }
        }


        private bool UpdateExcelFile(string fieldName, string newValue, int columnIndex)
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
                    if (worksheet.Cells[i, 2].Value2.ToString() == UserSession.Instance.Username)
                    {
                        worksheet.Cells[i, columnIndex] = newValue;
                        workbook.Save();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating {fieldName}: {ex.Message}");
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
            }
            return false;
        }

        private string EncryptText(string input, int shifter = 9)
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

        private void HomeButton_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            this.Hide();
            homePage.ShowDialog();
            this.Close();
        }

        private void ShowEditPanel(string mode)
        {
            editPanel.Visible = true;
            if (mode == "username")
            {
                usernameTextBox.Visible = true;
                passwordTextBox.Visible = false;
                usernameTextBox.Text = UserSession.Instance.Username;
                saveButton.Tag = "username";
            }
            else if (mode == "password")
            {
                usernameTextBox.Visible = false;
                passwordTextBox.Visible = true;
                passwordTextBox.Text = "";
                saveButton.Tag = "password";
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string mode = (string)saveButton.Tag;
            if (mode == "username")
            {
                if (UpdateUsername(usernameTextBox.Text))
                {
                    MessageBox.Show("Username updated successfully!");
                    UserSession.Instance.Username = usernameTextBox.Text;
                    // Update the displayed username
                    foreach (Control c in this.Controls)
                    {
                        if (c is Label && c.Font.Size == 18)
                        {
                            c.Text = UserSession.Instance.Username;
                            break;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Failed to update username.");
                }
            }
            else if (mode == "password")
            {
                if (UpdatePassword(passwordTextBox.Text))
                {
                    MessageBox.Show("Password updated successfully!");
                }
                else
                {
                    MessageBox.Show("Failed to update password.");
                }
            }
            editPanel.Visible = false;
        }


        private bool UpdatePassword(string newPassword)
        {
            string encryptedPassword = EncryptText(newPassword);
            return UpdateExcelFile("Password", encryptedPassword, 3); // Assuming password is in column 3
        }
        private bool UpdateUsername(string newUsername)
        {
            return UpdateExcelFile("Username", newUsername, 2); // Assuming username is in column 2
        }


        private void ProfileForm_Load(object sender, EventArgs e)
        {

        }

    }
}