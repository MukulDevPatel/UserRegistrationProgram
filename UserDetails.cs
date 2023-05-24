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
        public const string NAME = "^[A-Z][a-z]{1,4}$";
        public const string EMAIL = "^[a-zA-Z]+[.+-]{0,1}[a-zA-Z]+[@][a-zA-Z]+[.][a-zA-Z]{2,3}([.][a-zA-Z]{2,3}){0,1}$";
        public static void UserData()
        {
            //For enter to first name of user
            Console.Write("Enter first name of user: ");
            string firstName = Console.ReadLine();
            if (Regex.IsMatch(firstName, NAME))
            {
                Console.WriteLine("Valid first name of user");
            }else
            {
                Console.WriteLine("Invalid enterd name");
            }

            //For enter to last name of user
            Console.Write("\nEnter last name of user: ");
            string lastName = Console.ReadLine();
            if (Regex.IsMatch(lastName, NAME))
            {
                Console.WriteLine("Valid last name of user");
            }
            else
            {
                Console.WriteLine("Invalid enterd name");
            }

            //For enter to last name of user
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
