using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ThinkerToys
{
    public partial class ProfileForm : Form
    {
        public ProfileForm()
        {
            InitializeComponent();
            CustomizeForm();
        }

        private void CustomizeForm()
        {
            // Set up the form background color and properties
            this.BackColor = Color.White; // Set the form's background to white
            this.Size = new Size(850, 850); // Set the initial size to be larger
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.Sizable; // Allow resizing

            // Top Panel
            Panel topPanel = new Panel
            {
                BackColor = Color.RoyalBlue, // Blue theme for the top panel
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
                Image = Properties.Resources.settings_icon // Replace with your resource image
            };
            topPanel.Controls.Add(settingsIcon);

            PictureBox notificationIcon = new PictureBox
            {
                Size = new Size(24, 24),
                Location = new Point(this.Width - 40, 20),
                SizeMode = PictureBoxSizeMode.Zoom,
                Anchor = AnchorStyles.Top | AnchorStyles.Right,
                Image = Properties.Resources.notification_icon // Replace with your resource image
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


            // Name Label
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




            // Information Panel
            Panel infoPanel = new Panel
            {
                BackColor = Color.White,
                Size = new Size(this.Width - 40, 150),
                Location = new Point(20, idLabel.Bottom + 25),
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

        private void HomeButton_Click(object? sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            this.Hide();
            homePage.ShowDialog();
            this.Close();
        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {

        }
    }
}
