using System;   

namespace Day01_Hello_World_and_Basic_Syntax
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


            int number = 19;

            string name = "Raiko";
            
            double price = 9899.99;
            bool isActive = true;

            Console.WriteLine("Number: " + number);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Price: " + price);
            Console.WriteLine("Is Active: " + isActive);

            if (number > 5)
            {
                Console.WriteLine("Number is greater than 5.");
            }
            else
            {
                Console.WriteLine("Number is 5 or less.");
            }

            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine("Loop iteration: " + i);
            }
        }
    }
}