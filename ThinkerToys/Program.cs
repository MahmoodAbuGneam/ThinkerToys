namespace ThinkerToys
{
    internal static class Program
    {





        public static int CurrentUserCoins { get; set; } // function to get the coins of the user 

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Login loginForm = new Login();
            loginForm.FormClosed += new FormClosedEventHandler(FormClosed);
            loginForm.Show();
            Application.Run();
        }

        private static void FormClosed(object sender, FormClosedEventArgs e)
        {
            // Check if any forms are open, if none, exit the application
            if (Application.OpenForms.Count == 0)
                Application.Exit();
        }


    }
}