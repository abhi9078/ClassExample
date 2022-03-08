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

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
