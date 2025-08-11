using System;
namespace Beginner
{
    class Day02_Variables_and_Data_Types
    {
        static void Main(string[] args)
        {
            int age = 19;
            double height = 5.7;
            char initial = 'R';
            string name = "Raiko";
            bool isStudent = true;

            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Height: " + height);
            Console.WriteLine("Initial: " + initial);
            Console.WriteLine("Is Student: " + isStudent);
        }
    }
}