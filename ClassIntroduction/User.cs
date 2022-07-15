using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassIntroduction
{
    internal class User
    {
        public string FullName(string FirstName, string LastName)
        {
            return FirstName + " " + LastName;
        }
        public string BirthDay(string Year, string Month, string Day)
        {
            return Year + "/" + Month + "/" + Day;
        }
    }
}
