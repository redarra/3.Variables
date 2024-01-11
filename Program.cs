using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declare variables
            String name;
            int age;



            //Initialise
            name = "Mabhonyoko";
            age = 23;


            //Declare and Initialise
            String lastName = "hi";


            Console.WriteLine("My Fullname is " + name + " " + lastName + " and I am  " + age + "  Years old");
            Console.WriteLine("Turning " + (age + 1) + " next year");


            //Re initialise variables
            age = 23 + 20;
            Console.WriteLine("In 20 years I'll be " + age + "  Years Old");

            //Creating a space between two people
            Console.WriteLine();

            name = "Sara";
            age = 10;

            Console.WriteLine("My name is " + name + " and I am  " + age + "  Years old");
            Console.WriteLine("Turning " + (age + 1) + " next year");

            //Re initialise variables
            age = +20;
            Console.WriteLine("In 20 years I'll be " + age + "  Years Old");

            //Freeze Console
            Console.ReadLine();
        }
    }
}
