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
        public const string Name = "^[A-Z][a-z]{1,4}$";
        public static void UserData()
        {
            Console.Write("Enter first name of user: ");
            string name = Console.ReadLine();
            if (Regex.IsMatch(name,Name))
            {
                Console.WriteLine("Valid first name of user");
            }else
            {
                Console.WriteLine("Invalid enterd name");
            }
        }
    }
}
