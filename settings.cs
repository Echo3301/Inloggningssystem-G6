//using System;
//using System.Collections.Generic;
//using System.Diagnostics;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Inloggningssystem_G6
//{
//    internal class settings
//    {

//        public static void setting()
//        {
//            // Admin-funktionalitet: Admin ska se följande menyval:
//            //1. Inställningar
//            //i.Byta till slumpmässig textfärg
//            //ii. Ändra konsolfönstrets titel   Console.Title Property
//            //2. Avsluta
//            //3. Lägga till användare

//            //Random color = new Random();
//            // Get the list of available colors 
//            // that can be changed 
//            //ConsoleColor[] consoleColors
//            //    = (ConsoleColor[])ConsoleColor
//            //          .GetValues(typeof(ConsoleColor));

//            //// Display the list 
//            //// of available console colors 
//            //Console.WriteLine("List of available "
//            //                  + "Console Colors:");
//            //foreach (var color in consoleColors)
//            //    Console.WriteLine(color);

//            string settingsOption = Console.ReadLine();

//            Console.WriteLine("Välj inställning som ska ändras\n1. Ändra färg\n2. Ändra titel\nq. gå till menyn");
//            switch (settingsOption)
//            {
//                case "1":
//                    ColorChange();
//                    break;

//                case "2":
//                    TitleChange();
//                    break;

//                //case "3":

//                //    break;

//                case "q":

//                    break;

//                default:

//                    break;
//            }

//        }


//        public static void ColorChange() 
//        {
//            Random rnd = new Random();
//            //var consoleColors = Enum.GetValues(typeof(ConsoleColor));
//            //return (ColorChange)consoleColors.GetValue(rnd.Next(consoleColors.Length))
//            Console.ForegroundColor = (ConsoleColor)rnd.Next(0, 16);
//            var newColor = Console.ForegroundColor;
//            Console.WriteLine($"Nya färgen är {newColor}");

//        }
//        public static void TitleChange()
//        {

//            Console.WriteLine("Vad är nya titeln?");
//            string newTitle = Console.ReadLine().Trim();

//            Console.Title = newTitle;
//            Console.WriteLine($"Titeln har ändrats till {Console.Title}");

//        }
//        DateTime LoginTime = DateTime.Now;
//        public static void AutoLogout() 
//        {
//            DateTime loginTime = DateTime.Now;
            
//            DateTime currentTime = DateTime.Now;
//            currentTime.AddMinutes(15); //

//            TimeSpan logoutTime = currentTime - loginTime;
//            double logoutTimeMinutes = logoutTime.TotalMinutes;

            

//            if (IsAdmin == false) 
//            {
//                TimeSpan logoutCompare = new TimeSpan(0, 2, 0);
//                double logoutCompareMinutes = logoutCompare.TotalMinutes;
//                if (logoutTimeMinutes > logoutCompareMinutes)
//                {
//                    userInput = "";
//                    passwordInput = "";
//                }
//                else
//                {
//                    return;
//                }

//            } else if (IsAdmin == true) 
//            {
//                TimeSpan logoutCompare = new TimeSpan(0, 10, 0);
//                double logoutCompareMinutes = logoutCompare.TotalMinutes;
//                if (logoutTimeMinutes > logoutCompareMinutes)
//                {
//                    userInput = "";
//                    passwordInput = "";
//                }
//                else 
//                {
//                    return;
//                }
//            }
            
                    
//        }

//        public static void AutoLogoutStopWatch(int minuter)
//        {

//            Stopwatch autoLogout = new Stopwatch();

//            autoLogout.Start();
//            bool loggedIn = true;
//            if (IsAdmin == false)
//            {
//                Thread.Sleep(120000);
//                autoLogout.Stop();
//                loggedIn = false;
//            }
//            else if (IsAdmin == true)
//            {
//                Thread.Sleep(600000);
//                autoLogout.Stop();
//                loggedIn = false;
//            }

            


//            DateTime loginTime = DateTime.Now;

//            DateTime currentTime = DateTime.Now;
//            currentTime.AddMinutes(15);

//            TimeSpan logoutTime = currentTime - loginTime;
//            double logoutTimeMinutes = logoutTime.TotalMinutes;





//        }





//    }
//}
