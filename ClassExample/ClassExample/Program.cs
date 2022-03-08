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

        public static int Age()
        {
            Console.WriteLine("Enter Your Age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            return age;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Program");
            string fname = FirstName();
            string lname = LastName();
            int age = Age();
            Console.WriteLine("Hello " + fname + " " + lname + ", Your age is:     " + age);

        }
    }
}
