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
        }
    }
}
