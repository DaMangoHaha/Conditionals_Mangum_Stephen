﻿namespace Conditionals_Mangum_Stephen
{
    using System;

    class Program
    {
        static void Main()
        {
            // Check if a number is positive/negative and even/odd
            Console.Write("Enter a whole number: ");
            int num1 = int.Parse(Console.ReadLine());

            if (num1 > 0)
                Console.WriteLine($"{num1} is positive.");
            else if (num1 < 0)
                Console.WriteLine($"{num1} is negative.");
            else
                Console.WriteLine($"{num1} is zero.");

            if (num1 % 2 == 0)
                Console.WriteLine($"{num1} is even.");
            else
                Console.WriteLine($"{num1} is odd.");

            // Compare three numbers and find the largest
            Console.Write("Enter another whole number: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.Write("Enter one more whole number: ");
            int num3 = int.Parse(Console.ReadLine());

            int largest = Math.Max(num1, Math.Max(num2, num3));
            Console.WriteLine($"The largest number among {num1}, {num2}, and {num3} is {largest}.");

            // Switch statement for grade description
            Console.Write("Enter a grade (A, B, C, D, F): ");
            char grade = char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();  // Move to the next line

            switch (grade)
            {
                case 'A':
                    Console.WriteLine("Superior");
                    break;
                case 'B':
                    Console.WriteLine("Very Good");
                    break;
                case 'C':
                    Console.WriteLine("Average");
                    break;
                case 'D':
                    Console.WriteLine("Below Average");
                    break;
                case 'F':
                    Console.WriteLine("Fail");
                    break;
                default:
                    Console.WriteLine("Invalid grade entered.");
                    break;
            }
        }
    }
}