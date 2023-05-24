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
        public const string FirstName = "^[A-Z][a-z]{1,4}$";
        public const string LastName = "^[A-Z][a-z]{1,4}$";
        public static void UserData()
        {
            //For enter to first name of user
            Console.Write("Enter first name of user: ");
            string firstName = Console.ReadLine();
            if (Regex.IsMatch(firstName, FirstName))
            {
                Console.WriteLine("Valid first name of user");
            }else
            {
                Console.WriteLine("Invalid enterd name");
            }

            //For enter to last name of user
            Console.Write("\nEnter last name of user: ");
            string lastName = Console.ReadLine();
            if (Regex.IsMatch(lastName, LastName))
            {
                Console.WriteLine("Valid last name of user");
            }
            else
            {
                Console.WriteLine("Invalid enterd name");
            }
        }
    }
}
