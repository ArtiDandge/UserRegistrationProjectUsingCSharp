using System;

namespace UserRegistration
{
    public class UserRegistrationExceptions: Exception
    {
        public enum ExceptionType
        {
            INVALID_NAME,
            INVALID_EMAIL,
            INVALID_MOBILE_NUMBER,
            INVALID_PASSWORD
        }

        public readonly ExceptionType type;
        public UserRegistrationExceptions(ExceptionType type, String message) : base(message)
        {
            this.type = type;
        }
    }
}
