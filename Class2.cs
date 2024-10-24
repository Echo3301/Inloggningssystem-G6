using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inloggningssystem_G6
{
    internal class Class2
    {
        public static DateTime InitialiseLogOutTime()
        {
            DateTime logoutTime = DateTime.Now;
            logoutTime.AddMinutes(10);
            return logoutTime;
        }
    }
}
