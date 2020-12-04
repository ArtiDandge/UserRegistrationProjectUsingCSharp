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
            Boolean result = UserRegistration.validateFirstName(first_name);
            Console.WriteLine(result);
            Console.WriteLine("Enter Last Name");
            string last_name = Console.ReadLine();
            Console.WriteLine(UserRegistration.validateFirstName(last_name));
        }
    }
}
