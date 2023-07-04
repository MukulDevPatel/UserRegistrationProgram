using NUnit.Framework;
using UserRegistrationProblem;

namespace UserRegistrationTest
{
    public class UserTest
    {
        private UserDetails userTesting;


        [SetUp]
        public void SetUp()
        {
            userTesting = new UserDetails();
        }

        [Test]
        public void When_TestWill_Be_Sad_IfUserDetailsInvalid()
        {
            try
            {
                // Test case 1: Invalid first name
                string firstName = "";
                string lastName = "Doe";
                string email = "john.doe@example.com";
                string mobile = "1234567890";
                string password = "password123";

                User user1 = new User(firstName, lastName, email, mobile, password);
            }
            catch (InvalidUserDetailsException ex)
            {
                Console.WriteLine("Test case 1 failed: " + ex.Message);
            }

            try
            {
                // Test case 2: Invalid last name
                string firstName = "John";
                string lastName = "";
                string email = "john.doe@example.com";
                string mobile = "1234567890";
                string password = "password123";

                User user2 = new User(firstName, lastName, email, mobile, password);
            }
            catch (InvalidUserDetailsException ex)
            {
                Console.WriteLine("Test case 2 failed: " + ex.Message);
            }

            try
            {
                // Test case 3: Invalid email
                string firstName = "John";
                string lastName = "Doe";
                string email = "";
                string mobile = "1234567890";
                string password = "password123";

                User user3 = new User(firstName, lastName, email, mobile, password);
            }
            catch (InvalidUserDetailsException ex)
            {
                Console.WriteLine("Test case 3 failed: " + ex.Message);
            }

            try
            {
                // Test case 4: Invalid mobile number
                string firstName = "John";
                string lastName = "Doe";
                string email = "john.doe@example.com";
                string mobile = "";
                string password = "password123";

                User user4 = new User(firstName, lastName, email, mobile, password);
            }
            catch (InvalidUserDetailsException ex)
            {
                Console.WriteLine("Test case 4 failed: " + ex.Message);
            }

            try
            {
                // Test case 5: Invalid password
                string firstName = "John";
                string lastName = "Doe";
                string email = "john.doe@example.com";
                string mobile = "1234567890";
                string password = "";

                User user5 = new User(firstName, lastName, email, mobile, password);
            }
            catch (InvalidUserDetailsException ex)
            {
                Console.WriteLine("Test case 5 failed: " + ex.Message);
            }
        }

        [Test]
        public void When_TestWill_Be_Happy_IfUserDetailsValid()
        {
            try
            {
                // Test Valid User Details
                string firstName = "John";
                string lastName = "Doe";
                string email = "john.doe@example.com";
                string mobile = "1234567890";
                string password = "password123";

                User user1 = new User(firstName, lastName, email, mobile, password);
            }
            catch (InvalidUserDetailsException ex)
            {
                Console.WriteLine("Test case 1 failed: " + ex.Message);
            }
        }
    }
}