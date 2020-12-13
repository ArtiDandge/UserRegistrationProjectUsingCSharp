using System;
using System.Collections.Generic;
using System.Text;

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

        private readonly ExceptionType type;
        public UserRegistrationExceptions(ExceptionType type, String message) : base(message)
        {
            this.type = type;
        }
    }
}
