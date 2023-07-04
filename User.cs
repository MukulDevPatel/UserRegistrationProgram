using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistrationProblem
{
    public class User
    {
        private string firstName { get; set; }
        private string lastName { get; set; }
        private string email { get; set; }
        private string number { get; set; }
        private string passWord { get; set; }
        public User(string firstName, string lastName, string email, string number, string passWord)
        {
            ValidateField(firstName, "first name", s => !string.IsNullOrWhiteSpace(s));
            ValidateField(lastName, "last name", s => !string.IsNullOrWhiteSpace(s));
            ValidateField(email, "email", IsValidEmail);
            ValidateField(number, "mobile number", IsValidMobile);
            ValidateField(passWord, "password", s => !string.IsNullOrWhiteSpace(s));

            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.number = number;
            this.passWord = passWord;
        }
        private void ValidateField(string value, string fieldName, Func<string, bool> isValidFunc)
        {
            if (!isValidFunc(value))
            {
                throw new InvalidUserDetailsException($"Invalid {fieldName}.");
            }
        }

        private bool IsValidEmail(string email)
        {
            // You can implement more sophisticated email validation logic here
            return !string.IsNullOrWhiteSpace(email) && email.Contains("@");
        }

        private bool IsValidMobile(string mobile)
        {
            // You can implement more sophisticated mobile validation logic here
            return !string.IsNullOrWhiteSpace(mobile) && mobile.Length == 10 && long.TryParse(mobile, out _);
        }
    }
}
