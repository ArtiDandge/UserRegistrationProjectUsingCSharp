﻿using System;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class UserRegistration
    {

        public static bool validateFirstName(string name)
        {   string expression = "^[A-Z]{1}[a-zA-Z]{2,}";
            Regex rg = new Regex(expression);   
                return rg.IsMatch(name);
        }
        public static bool validateEmail(string email)
        {
            string emailExpression = "^[a-zA-Z0-9+_.-]+@[a-zA-Z.-]+$";
            Regex rg = new Regex(emailExpression);
            return rg.IsMatch(email);
        }
        public static bool validateMobileNo(string mobileNo)
        {
            string mobileExpression = "([+][9]{1}[1]{1}\\s)?[6-9]{1}[0-9]{9}";
            Regex rg = new Regex(mobileExpression);
            return rg.IsMatch(mobileNo);
        }
        public static bool validatePassword(string password)
        {
            //string passwordExpression = "[A-Za-z]{8,}";    Rule 1 : Password must have minimum 8 charactors
            //string passwordExpression2 = ".*[A-Z].*";	     Rule 2: password should have atleast one Upper case
            string passwordExpression3 = "^(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])(?=.*(+[@#$%^&+=])).{8,}$";
            Regex rg = new Regex(passwordExpression3);
            return rg.IsMatch(password);
        }
    }
}
