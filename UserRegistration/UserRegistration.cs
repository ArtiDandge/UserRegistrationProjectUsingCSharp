using System;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    public class UserRegistration
    {

        public static bool validateName(string name)
        {
            try
            {
                string expression = "^[A-Z]{1}[a-zA-Z]{2,}";
                Regex rg = new Regex(expression);
                return rg.IsMatch(name);
            }
            catch(UserRegistrationExceptions)
            {
                throw new UserRegistrationExceptions(UserRegistrationExceptions.ExceptionType.INVALID_NAME, "Invalid User Name. Please make sure Name should follow all predefined rules of a valid name");
            }
        }
        public static bool validateEmail(string email)
        {
            try
            {
                string emailExpression = "^[\\w!#$%&'*+/=?`{|}~^-]+(?:\\.[\\w!#$%&'*+/=?`{|}~^-]+)*@(?:[a-zA-Z0-9-]+\\.)+[a-zA-Z0-9]{2,6}$";
                Regex rg = new Regex(emailExpression);
                return rg.IsMatch(email);
            }
            catch(UserRegistrationExceptions)
            {
                throw new UserRegistrationExceptions(UserRegistrationExceptions.ExceptionType.INVALID_EMAIL, "Invalid Email address.Please make sure email should follow all predefined rules of a valid email");
            }
        }
        public static bool validateMobileNo(string mobileNo)
        {
            try
            {
                string mobileExpression = "([+][9]{1}[1]{1}\\s)?[6-9]{1}[0-9]{9}";
                Regex rg = new Regex(mobileExpression);
                return rg.IsMatch(mobileNo);
            }
            catch (UserRegistrationExceptions)
            {
                throw new UserRegistrationExceptions(UserRegistrationExceptions.ExceptionType.INVALID_MOBILE_NUMBER, "Invalid Mobile Number.Please make sure Mobile Number should follow all predefined rules of a valid Mobile Number");
            }
            
        }
        public static bool validatePassword(string password)
        {
            try
            {
                string passwordExpression3 = "^(?=.*[A-Z])(?=.*[a-z])(?=.*[0-9])(?=.*[#?!@$%^&*-]).{8,}$";
                Regex rg = new Regex(passwordExpression3);
                return rg.IsMatch(password);
            }
            catch (UserRegistrationExceptions)
            {
                throw new UserRegistrationExceptions(UserRegistrationExceptions.ExceptionType.INVALID_PASSWORD, "Invalid Password.Please make sure Password should follow all predefined rules of a valid Password");
            }
        }
    }
}
