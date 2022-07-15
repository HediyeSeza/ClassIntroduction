using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassIntroduction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User hedi = new User();

            Console.WriteLine("Please enter your name :");
            string FirstName = Console.ReadLine();
            Console.WriteLine("Please enter your family :");
            string LastName = Console.ReadLine();
            Console.WriteLine("Please enter your BirthDay :");
            string Year = Console.ReadLine();
            string Month = Console.ReadLine();
            string Day = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Your Fullname is : ");
            Console.WriteLine(hedi.FullName(FirstName, LastName));
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Your BirthDay is : ");
            Console.WriteLine(hedi.BirthDay(Year, Month, Day));
            Console.ReadKey();
        }
    }
}
