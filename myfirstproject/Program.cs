using System;
using System.Collections.Generic;
using System.Linq;

namespace myfirstproject // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string fname, lname;
            Console.Write("Enter your first name: ");
            fname = Console.ReadLine();
            Console.Write("Enter your last name: ");
            lname = Console.ReadLine();
            Console.Write("Your full name is: " + fname + " " + lname);
        }
    }
}