using System;

namespace UserRegistration
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration Project !");
            Console.WriteLine("Enter First Name");
            string first_name = Console.ReadLine();
            Console.WriteLine(UserRegistration.validateFirstName(first_name));
            Console.WriteLine("Enter Last Name");
            string last_name = Console.ReadLine();
            Console.WriteLine(UserRegistration.validateFirstName(last_name));
            Console.WriteLine("Enter Email Address");
            string email = Console.ReadLine();
            Console.WriteLine(UserRegistration.validateEmail(email));
            Console.WriteLine("Enter Mobile Number");
            string mobileNo = Console.ReadLine();
            Console.WriteLine(UserRegistration.validateMobileNo(mobileNo));
            Console.WriteLine("Enter password");
            string password = Console.ReadLine();
            Console.WriteLine(UserRegistration.validatePassword(password));
        }
    }
}
