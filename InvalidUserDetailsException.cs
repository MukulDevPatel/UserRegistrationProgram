using System.Runtime.Serialization;

namespace UserRegistrationProblem
{
    [Serializable]
    public class InvalidUserDetailsException : Exception
    {
        public InvalidUserDetailsException(string? message) : base(message)
        {
        }
    }
}