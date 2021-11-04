using System;

namespace RhombusPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Rhombus Pyramid");
            //Write a program that asks an user to enter a whole number and draws a rhombus pyramid. For example: 
            //If the user enters 6 numbers the output will be as follows:
            /*
            *
            **
            ***
            ****
            *****
            ******
            */

            Console.WriteLine("Please enter a number and I will paint a pyramid:");
            int number = Convert.ToInt32(Console.ReadLine());

            for (int counter = 1; counter <= number; counter++)
            {
                for (int asterisk = 1; asterisk <= counter; asterisk++)
                {
                    Console.WriteLine("*");
                }
            }
        }
    }
}
