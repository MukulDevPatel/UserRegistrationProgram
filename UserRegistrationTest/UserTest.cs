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
        public void When_TestWill_Be_Happy()
        {
            //arrange
            string firstName = "Chris";
            string lastName = "Pitt";
            string email = "robert@gmail.com";
            string number = "91 6234567890";
            string passWord = "password";

            //Act
            bool IsValid = userTesting.UserData(firstName,lastName,email,number,passWord);
            
            //Assert
            Assert.IsTrue(IsValid);
        }
        [Test]
        public void When_TestWill_Be_Sad()
        {
            //arrange
            string firstName = "";
            string lastName = "PiItt";
            string email = "robert@gmailcom";
            string number = "916234567890";
            string passWord = "paSsword";

            //Act
            bool IsValid = userTesting.UserData(firstName, lastName, email, number, passWord);

            //Assert
            Assert.IsFalse(IsValid);
        }
    }
}