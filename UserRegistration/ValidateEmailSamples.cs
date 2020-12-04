using System;
using System.Collections;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class ValidateEmailSamples
    {
        public static void emailValidator()
        {
            var emails = new ArrayList();
            //Valid emails list
            emails.Add("abc@yahoo.com");
            emails.Add("abc-100@yahoo.com");
            emails.Add("abc.100@yahoo.com");
            emails.Add("abc111@abc.com");
            emails.Add("abc-100@abc.net");
            emails.Add("abc.100@abc.com.au");
            emails.Add("abc@1.com");
            emails.Add("abc@gmail.com.com");
            emails.Add("abc+100@gmail.com");

            //Invalid emails list
            emails.Add("abc");
            emails.Add("abc@.com.my");
            emails.Add("abc123@gmail.a");
            emails.Add("abc123@.com");
            emails.Add("abc123@.com.com");
            emails.Add(".abc@abc.com");
            emails.Add("abc()*@gmail.com");
            emails.Add("abc@%*.com");
            emails.Add("abc..2002@gmail.com");
            emails.Add("abc.@gmail.com");
            emails.Add("abc@abc@gmail.com");
            string regex = "^[\\w!#$%&'*+/=?`{|}~^-]+(?:\\.[\\w!#$%&'*+/=?`{|}~^-]+)*@(?:[a-zA-Z0-9-]+\\.)+[a-zA-Z0-9]{2,6}$";
            Regex emailPattern = new Regex(regex);
            foreach (string item in emails)
            {
                Console.WriteLine(item+" : "+ emailPattern.IsMatch(item));
            }
        }

    }
}
