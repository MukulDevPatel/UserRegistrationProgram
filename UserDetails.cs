using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.AccessControl;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationProblem
{
    public class UserDetails
    {
        public void UserData(string lastName, string email, string number, string passWord, string firstName)
        {
            if (!IsValidFirstName(firstName)) {throw new InvalidUserDetailsException("Invalid first name");}
            if (!IsValidLastName(lastName))  { throw new InvalidUserDetailsException("Invalid last name"); }
            if (!IsValidNumber(number)) { throw new InvalidUserDetailsException("Invalid number"); }
            if (!IsValidEmail(email)) { throw new InvalidUserDetailsException("Invalid email"); }
            if (!IsValidPassword(passWord)) { throw new InvalidUserDetailsException("Invalid password"); }
        }
        private bool IsValidFirstName(string firstName) 
        {
            string firstNameRegex = "^[A-Z]{1}[a-z]{3,}$";
            return Regex.IsMatch(firstNameRegex, firstName);
        }
        private bool IsValidLastName(string lastName)
        {
            string lastNameRegex = "^[A-Z]{1}[a-z]{3,}$";
            return Regex.IsMatch(lastNameRegex, lastName);
        }
        private bool IsValidNumber(string number)
        {
            string numberRegex = "^[0-9]{2}[ ][6-9]{1}[0-9]{9}$";
            return Regex.IsMatch(numberRegex, number);
        }

        private bool IsValidEmail(string email)
        {
            string emailRegex = "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(emailRegex, email);
        }
        
        private bool IsValidPassword(string password)
        {
            string passWord = "^[a-z]{8}$";
            return Regex.IsMatch(password, passWord);
        }

        //Another test case
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
