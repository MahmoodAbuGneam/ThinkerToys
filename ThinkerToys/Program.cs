using System.Globalization;
using ThinkerToys;

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

            ApplicationConfiguration.Initialize();
            Login loginForm = new Login();
            loginForm.FormClosed += new FormClosedEventHandler(FormClosed);
            loginForm.Show();
            Application.Run();

            // ---------------------------------------------------


            // Hebrew Game 1
            //ApplicationConfiguration.Initialize();
            //HebrewGame1 hebrew1 = new HebrewGame1('א');
            //hebrew1.FormClosed += new FormClosedEventHandler(FormClosed);
            //hebrew1.Show();
            //Application.Run();

            // Level selection form for Hebrew game 1 


            //ApplicationConfiguration.Initialize();
            //LevelSelectionForm hebrew1 = new LevelSelectionForm();
            //hebrew1.FormClosed += new FormClosedEventHandler(FormClosed);
            //hebrew1.Show();
            //Application.Run();


            // Hebrew Game 2 
            //ApplicationConfiguration.Initialize();
            //HebrewMainMenu hebrew2 = new HebrewMainMenu();
            //hebrew2.FormClosed += new FormClosedEventHandler(FormClosed);
            //hebrew2.Show();
            //Application.Run();



            // Hebrew Games Together
            //ApplicationConfiguration.Initialize();
            //HebrewGamesTogether hebrewTogether = new HebrewGamesTogether();
            //hebrewTogether.FormClosed += new FormClosedEventHandler(FormClosed);
            //hebrewTogether.Show();
            //Application.Run();

            // ---------------------------------------------------


            //Home page
            //ApplicationConfiguration.Initialize();
            //MainMenuForm mainMenuForm = new MainMenuForm();
            //LevelForm levelform = new LevelForm(1,mainMenuForm);
            //levelform.FormClosed += new FormClosedEventHandler(FormClosed);
            //levelform.Show();
            //Application.Run();


            // ---------------------------------------------------



            // Store Form

            //ApplicationConfiguration.Initialize();
            //StoreSectForm1 storeForm = new StoreSectForm1();
            //storeForm.FormClosed += new FormClosedEventHandler(FormClosed);
            //storeForm.Show();
            //Application.Run();


            // ---------------------------------------------------

            //EnglishGame1 - bomb

            //ApplicationConfiguration.Initialize();
            //EnglishGame1Form englishGame1 = new EnglishGame1Form();
            //englishGame1.FormClosed += new FormClosedEventHandler(FormClosed);
            //englishGame1.Show();
            //Application.Run();


            // English Game - Memory 

            //ApplicationConfiguration.Initialize();
            //EnglishMemoryMatching game = new EnglishMemoryMatching();
            //game.FormClosed += new FormClosedEventHandler(FormClosed);
            //game.Show();
            //Application.Run();



            // English Games Together
            //ApplicationConfiguration.Initialize();
            //EnglishGamesTogether englishTogether = new EnglishGamesTogether();
            //englishTogether.FormClosed += new FormClosedEventHandler(FormClosed);
            //englishTogether.Show();
            //Application.Run();



            // ---------------------------------------------------

            // Math Game 1

            //ApplicationConfiguration.Initialize();
            //MathGameForm mathGame1 = new MathGameForm();
            //mathGame1.FormClosed += new FormClosedEventHandler(FormClosed);
            //mathGame1.Show();
            //Application.Run();


            // Math Game 2

            //ApplicationConfiguration.Initialize();
            //BiggerSmallerEqualsGame biggerSmaller = new BiggerSmallerEqualsGame();
            //biggerSmaller.FormClosed += new FormClosedEventHandler(FormClosed);
            //biggerSmaller.Show();
            //Application.Run();



            // Math Games Together

            //ApplicationConfiguration.Initialize();
            //MathGamesTogether mathTogether = new MathGamesTogether();
            //mathTogether.FormClosed += new FormClosedEventHandler(FormClosed);
            //mathTogether.Show();
            //Application.Run();



            // ---------------------------------------------------

            // Profile Form

            //ApplicationConfiguration.Initialize();
            //ProfileForm Profile = new ProfileForm();
            //Profile.FormClosed += new FormClosedEventHandler(FormClosed);
            //Profile.Show();
            //Application.Run();



        }

        private static void FormClosed(object sender, FormClosedEventArgs e)
        {
            // Check if any forms are open, if none, exit the application
            if (Application.OpenForms.Count == 0)
                Application.Exit();
        }


    }
}