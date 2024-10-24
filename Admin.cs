using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inloggningssystem_G6
{
    public class Admin : User
    {
        //properties ärvs av användare och detta är extra för admin
        public int color { get; set; }
        public string Title { get; set; }

        public DateTime LoginTime { get; set; }


        public Admin(String userName, String password, DateTime loginTime) : base(userName, password, loginTime)
        {
            IsAdmin = true;
        }



        public static void AdminMenu(List<User> userInfo, Admin loggedInAdmin)
        {


            loggedInAdmin.LoginTime = InitialiseLogOutTime();// Todo: byt namn tilll rätt metod när den är fixad
            //

            AutoLogoutClass.AutoLogout(loggedInAdmin.IsAdmin, loggedInAdmin.LoginTime);
            // Här ska det vara funktionen som startar date time
            Console.WriteLine("1. Inställningar");
            Console.WriteLine("2. Logga ut");
            Console.WriteLine("3. Lägg till användare");
            Console.WriteLine("Gör ett menyval och tryck enter");
            string val = Console.ReadLine();

            switch (val)
            {
                case "1":
                    Console.WriteLine("1. Byta till slumpmässig textfärg");
                    Console.WriteLine("2. Ändra konsolfönstrets titel");
                    Console.WriteLine("Gör ett menyval och tryck enter");
                    string InstallVal = Console.ReadLine();

                    if (InstallVal == "1")
                    {
                        ColorChange();
                        BackToMenu();

                        break;
                    }
                    if (InstallVal == "2")
                    {
                        TitleChange();
                        BackToMenu();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Ogilltig inmatning");
                        BackToMenu();
                    }
                    break;

                case "2":
                    Logout();
                    BackToMenu();
                    break;

                case "3":
                    CreateUserAndAdmin(userInfo);
                    BackToMenu();
                    break;

                default:
                    Console.WriteLine("Ogiltig inmatning");
                    BackToMenu();
                    break;
            }


        }
        // Färg ändring
        public static void ColorChange()
        {
            Random rnd = new Random();
            //var consoleColors = Enum.GetValues(typeof(ConsoleColor));
            //return (ColorChange)consoleColors.GetValue(rnd.Next(consoleColors.Length))
            Console.ForegroundColor = (ConsoleColor)rnd.Next(0, 16);
            var newColor = Console.ForegroundColor;
            Console.WriteLine($"Nya färgen är {newColor}");

        }
        // Titel ändring
        public static void TitleChange()
        {

            Console.WriteLine("Vad är nya titeln?");
            string newTitle = Console.ReadLine().Trim();

            Console.Title = newTitle;
            Console.WriteLine($"Titeln har ändrats till {newTitle}");

        }

        // Allows Admins to create a new user
        public static void CreateUserAndAdmin(List<User> userList) 
        {
            Console.WriteLine("Mata in \"1\" för att skapa ett admin konto \nMata in \"2\" för att skapa en vanlig användare");
            String isAdmin = Console.ReadLine();

            Console.WriteLine("Mata in användarnamn till ny användare:");
            String userName = Console.ReadLine();

            Console.WriteLine("Mata in lösenord till användaren");
            String password = Console.ReadLine();

            DateTime logoutTime = DateTime.Now;

            if (isAdmin != "2")
            {
                userList.Add(new Admin(userName, password, logoutTime));
            }
            else { userList.Add(new User(userName, password, logoutTime)); }

        }

        
        public static DateTime InitialiseLogOutTime()
        {
            DateTime logoutTime = DateTime.Now;
            logoutTime.AddMinutes(10);
            return logoutTime;
        }
    }
}
