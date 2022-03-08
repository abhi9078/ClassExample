using System;

namespace ClassExample
{
    internal class Program
    {
        public static string FirstName()
        {
            Console.WriteLine("Enter Your First Name: ");
            string fname = Console.ReadLine();
            return fname;
        }
        public static string LastName()
        {
            Console.WriteLine("Please Enter your Last Name: ");
            string lname = Console.ReadLine();
            return lname;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
