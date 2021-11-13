using System;

namespace _01_console_io
{
    class User
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the program new student! Please enter your information below");

            Console.WriteLine("Please enter your first name:");
            string firstName = Console.ReadLine();

            Console.WriteLine("Please enter your last name:");
            string lastName = Console.ReadLine();

            Console.WriteLine("Please enter your email:");
            string email = Console.ReadLine();

            Console.WriteLine("Please enter your phone number:");
            string phone = Console.ReadLine();

            Console.WriteLine("Thank you for entering your information " + firstName + " " + lastName);
            Console.WriteLine("Phone: " + phone);
            Console.WriteLine("Email: " + email);

            Console.WriteLine("Is all this information correct? (Y/N)");
            string confirm = Console.ReadLine();

            Console.Write("Press any key to exit...");
            Console.ReadKey();
        }
    }
}