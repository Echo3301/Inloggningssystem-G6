using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Inloggningssystem_G6
{
    public class AutoLogoutClass
    {
        public static string userInput { get; set; }
        public static string passwordInput { get; set; }

        public static void AutoLogout(Boolean IsAdmin, DateTime LoginTime)
        {
            
            
            //DateTime loginTime = DateTime.Now; // temp

            DateTime currentTime = DateTime.Now;
            //currentTime.AddMinutes(15); // Temp

            TimeSpan logoutTime = currentTime - LoginTime;
            double logoutTimeMinutes = logoutTime.TotalMinutes;



            if (IsAdmin == false)
            {
                TimeSpan logoutCompare = new TimeSpan(0, 2, 0);
                double logoutCompareMinutes = logoutCompare.TotalMinutes;
                if (logoutTimeMinutes > logoutCompareMinutes)
                {
                    userInput = "";
                    passwordInput = "";
                }
                else
                {
                    LoginTime = DateTime.Now;
                    return;
                }

            }
            else if (IsAdmin == true)
            {
                TimeSpan logoutCompare = new TimeSpan(0, 0, 10);
                double logoutCompareMinutes = logoutCompare.TotalMinutes;
                if (logoutTimeMinutes > logoutCompareMinutes)
                {
                    userInput = "";
                    passwordInput = "";
                }
                else
                {
                    LoginTime = DateTime.Now;
                    return;
                }
            }

    }
    }
}
