using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inloggningssystem_G6
{
    public class User
    {
        //properties för användare
        public string UserName { get; set; }
        public string Password { get; set; }
        public Boolean IsAdmin { get; set; }
        public DateTime LoginTime { get; set; }

        public User(String userName, String password, DateTime loginTime)
        {
            UserName = userName;
            Password = password;
            IsAdmin = false;
            LoginTime = loginTime;
        }

        public static void Menu(List<User> userList, User loggedInUser )
        {
            loggedInUser.LoginTime = InitialiseLogOutTime();

            Console.WriteLine("" +
                "1. Logga ut\n" +
                "2. Lösenord");
            Console.WriteLine("Gör ett menyval och tryck enter");

            while (true)
            { 
                string val = Console.ReadLine();

                switch (val)
                {
                    case "1":
                        Logout();
                        break;

                    case "2":
                        Console.WriteLine(loggedInUser.Password.ToString());
                        break;

                    default:
                        Console.WriteLine($"{val} är inte ett giltigt val, försök igen");
                        break;
                }
            }
        }
        public static void Logout()
        {
            string userInput = "user";
            string passwordInput = "password";
            Console.WriteLine("Tryck på en knapp för att logga ut");
            Console.ReadKey();
            userInput = "";
            passwordInput = "";

        }
        public static void BackToMenu()
        {
            Console.WriteLine("\nTryck valfri tangent för att återgå till meny");
            Console.ReadKey();
            Console.Clear();
        }
        public static DateTime InitialiseLogOutTime()
        {
            DateTime logoutTime = DateTime.Now;
            logoutTime.AddMinutes(10);
            return logoutTime;
        }
    }
}
