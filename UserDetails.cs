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

        public const string Name = "^[A-Z]{1}[a-z]{3,}$";
        public const string NUMBER = "^[0-9]{2}[ ][6-9]{1}[0-9]{9}$";
        public const string PASSWORD = "^[a-z]{8}$";
        public const string EMAIL = "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\\.[a-zA-Z]{2,}$";
        public void UserData()
        {
            string lastName; string email; string number; string passWord; string firstName;
            
            firstName = "Chris";
            if (Regex.IsMatch(firstName, Name))
            {
                Console.WriteLine("Valid name of user");
            }
            else
            {
                Console.WriteLine("Invalid enterd name");
            }

            lastName = "Pitt";
            if (Regex.IsMatch(lastName, Name))
            {
                Console.WriteLine("Valid name of user");
            }
            else
            {
                Console.WriteLine("Invalid enterd name");
            }

            number = "91 6234567890";
            if (Regex.IsMatch(number, NUMBER))
            {
                Console.WriteLine("Valid number of user");
            }
            else
            {
                Console.WriteLine("Invalid enterd number");
            }


            passWord = "password";
            if (Regex.IsMatch(passWord, PASSWORD))
            {
                Console.WriteLine("Valid passWord of user");
            }
            else
            {
                Console.WriteLine("Invalid enterd passWord");
            }


            email = "robert@gmail.com";
            if (Regex.IsMatch(email, EMAIL))
            {
                Console.WriteLine("Valid email of user");
            }
            else
            {
                Console.WriteLine("Invalid enterd email");
            }
        }
        public bool UserData(string lastName, string email, string number, string passWord, string firstName)
        {
            firstName = "Chris";
            lastName = "Pitt";
            number = "91 6234567890";
            passWord = "password";
            email = "robert@gmail.com";

            if (firstName == null && lastName == null && email == null && number == null && passWord == null)
            {
                Console.WriteLine("sad");
                return false;
            }
            Console.WriteLine("happy");
            return true;
        }
        

        public bool ValidationEmails(string email)
        {
            string EMAIL_REGEX = "^[a-zA-Z0-9.+-]+@[a-zA-Z0-9.-]+\\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(email, EMAIL_REGEX);
        }
        public bool ValidationForInvalidEmails(string email)
        {
            string EMAIL_REGEX = "^[a-zA-Z0-9+-]+@[a-zA-Z0-9]+[a-zA-Z]{2}$";
            return Regex.IsMatch(email, EMAIL_REGEX);
        }
    }
}
