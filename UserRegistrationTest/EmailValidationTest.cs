using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserRegistrationProblem;

namespace UserRegistrationTest
{
    public class EmailValidationTest
    {
        private UserDetails userDetails;
        
        [SetUp]
        public void SetUp()
        {
            userDetails = new UserDetails();
        }
        private static IEnumerable<string> InvalidEmails()
        {
            yield return "abc";
            yield return "abc@.com.my";
            yield return "abc123@gmail.a";
            yield return "abc123@.com";
            yield return "abc123@.com.com";
            yield return ".abc@abc.com";
            yield return "abc()*@gmail.com";
            yield return "abc@%*.com";
            yield return "abc..2002@gmail.com";
            yield return "abc.@gmail.com";
            yield return "abc@abc @gmail.com";
            yield return "abc@gmail.com.1a";
            yield return "abc@gmail.com.aa.au";
        }
        private static IEnumerable<string> ValidEmails()
        {
            yield return "abc@yahoo.com";
            yield return "abc-100@yahoo.com";
            yield return "abc.100@yahoo.com";
            yield return "abc111@abc.com";
            yield return "abc-100@abc.net";
            yield return "abc.100@abc.com.au";
            yield return "abc@1.com";
            yield return "abc@gmail.com.com";
            yield return "abc+100@gmail.com";
        }

        [TestCaseSource(nameof(InvalidEmails))]
        public void WhenEmailsAreInvalid_ThenGiveSadTest(string email)
        {
            //Act
            bool isValid = userDetails.ValidationForInvalidEmails(email);

            //Assert
            Assert.IsFalse(isValid);
        }

        [TestCaseSource(nameof(ValidEmails))]
        public void WhenEmailsAreValid_ThenGiveHappyTest(string email)
        {
            //Act
            bool IsValid = userDetails.ValidationEmails(email);

            //Assert
            Assert.IsTrue(IsValid);
        }
    }
}
