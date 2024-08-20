using ComponentFactory.Krypton.Toolkit;

namespace ThinkerToys
{
    partial class HebrewMainMenu
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        private Button btnBackToHome;
        private void InitializeComponents()
        {
            SuspendLayout();
            // 
            // HebrewMainMenu
            // 

            btnBackToHome = new Button();
            btnBackToHome.Text = "Home Page";
            btnBackToHome.BackColor = Color.White;
            btnBackToHome.Size = new Size(100, 50); // Set size according to your preference
            btnBackToHome.Location = new Point(10, 10); // Set location according to your layout
            btnBackToHome.Click += BtnBackToHome_Click; // Event handler for click event
            this.Controls.Add(btnBackToHome);
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 600);
            Name = "HebrewMainMenu";
            Text = "Main Menu";
            Load += HebrewMainMenu_Load;
            ResumeLayout(false);
        }


        private void BtnBackToHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage homePage = new HomePage();
            homePage.Show();
            this.Close();
        }
    }
}
