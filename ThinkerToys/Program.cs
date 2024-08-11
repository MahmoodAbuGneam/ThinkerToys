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

            //Login page 

            //ApplicationConfiguration.Initialize();
            //Login loginForm = new Login();
            //loginForm.FormClosed += new FormClosedEventHandler(FormClosed);
            //loginForm.Show();
            //Application.Run();



            // Store Form

            //ApplicationConfiguration.Initialize();
            //StoreSectForm1 storeForm = new StoreSectForm1();
            //storeForm.FormClosed += new FormClosedEventHandler(FormClosed);
            //storeForm.Show();
            //Application.Run();

            //EnglishGame1 - bomb

            //ApplicationConfiguration.Initialize();
            //EnglishGame1Form englishGame1 = new EnglishGame1Form();
            //englishGame1.FormClosed += new FormClosedEventHandler(FormClosed);
            //englishGame1.Show();
            //Application.Run();






            // English Game - Memory 

            ApplicationConfiguration.Initialize();
            EnglishMemoryMatching game = new EnglishMemoryMatching();
            game.FormClosed += new FormClosedEventHandler(FormClosed);
            game.Show();
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