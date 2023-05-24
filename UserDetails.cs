using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationProblem
{
    public class UserDetails
    {
        public const string NUMBER = "^[0-9]{2}[ ][6-9]{1}[0-9]{9}$";
        public static void UserData()
        {
            //For enter to number of user
            Console.Write("\nEnter number of user: ");
            string number = Console.ReadLine();
            if (Regex.IsMatch(number, NUMBER))
            {
                Console.WriteLine("Valid number of user");
            }
            else
            {
                Console.WriteLine("Invalid enterd number");
            }
        }
    }
}
