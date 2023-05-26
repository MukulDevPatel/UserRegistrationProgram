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
        public const string EMAIL = "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\\.[a-zA-Z]{2,}$";
        public static void UserData()
        {
            //For enter email for user registration
            Console.Write("\nEnter email of user: ");
            string email = Console.ReadLine();
            if (Regex.IsMatch(email, EMAIL))
            {
                Console.WriteLine("Valid email of user");
            }
            else
            {
                Console.WriteLine("Invalid enterd email");
            }
        }
    }
}
