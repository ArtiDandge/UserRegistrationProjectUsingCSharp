using System;
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
    }
}
