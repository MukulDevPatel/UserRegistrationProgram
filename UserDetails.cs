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
        public const string PASSWORD = "^(?=.*\\d).{8,}$";
        public static void UserData()
        {
            //For enter password with at least one numeric
            Console.Write("\nEnter password of user: ");
            string password = Console.ReadLine();
            if (Regex.IsMatch(password, PASSWORD))
            {
                Console.WriteLine("Valid password of user");
            }
            else
            {
                Console.WriteLine("Invalid enterd password");
            }
        }
    }
}
