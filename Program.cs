using System.Security.Cryptography.X509Certificates;

namespace Inloggningssystem_G6
{
    public class Program
    {
        public static List<User> UserInfo = new List<User>();

        //public string UsernameInput {  get; set; }
        //public string PasswordInput { get; set; }
        public static string? usernameInput { get; set; }
        public static string? passwordInput { get; set; }

        //public Program(String usernameInput, String passwordInput)
        //{
        //    UsernameInput = usernameInput;
        //    PasswordInput = passwordInput;
        //}

        static void Main(string[] args)
        {
            UserInfo.Add(new Admin("Bob", "sköldpadda", DateTime.Now));
            UserInfo.Add(new User("Anders", "tusselago", DateTime.Now));

            bool meny = true;
            int amountOfLoggingAttemps = 0;

            

            while (meny == true)
            {
                Console.WriteLine("Inloggningssystem\n");

                Console.WriteLine("Användarnamn:");
                usernameInput = Console.ReadLine();
                //string usernameInput = Console.ReadLine();

                Console.WriteLine("Lösenord:");
                passwordInput = Console.ReadLine();
                //string passwordInput = Console.ReadLine();


                foreach (User user in UserInfo)
                {
                    if (usernameInput == user.UserName && user.IsAdmin == false)
                    {
                        if (passwordInput == user.Password)
                        {
                            
                            User.Menu(UserInfo, user);
                        }
                        
                    }
                    else if (usernameInput == user.UserName && user.IsAdmin == true) { break; }
                }
                foreach (Admin admin in UserInfo)
                {
                    if (usernameInput == admin.UserName)
                    {
                        if (passwordInput == admin.Password)
                        {
                            Admin.AdminMenu(UserInfo, admin);
                        }
                    }
                }
                Console.WriteLine("Fel inloggningsuppgifter, försök igen");
                amountOfLoggingAttemps++;
                // Om man misslyckas med 10 inloggningsförsök så avslutas programmet
                if (amountOfLoggingAttemps > 10)
                {
                    Console.WriteLine("För många misslyckade inloggningsförsök, programmet kommer nu att avslutas");
                    //Kan användas som komando när som helst, i vilken metod som helst för att avsluta programmet
                    Environment.Exit(0); 
                }


            }

        }
    }
}
