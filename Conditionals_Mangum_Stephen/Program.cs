namespace Conditionals_Mangum_Stephen
{
    using System;

    class Program
    {
        static void Main()
        {
            // Checks if the number entered is positive or negative and even or odd
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

            // Does the same with these next two entered numbers
            Console.Write("Enter another whole number: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.Write("Enter one more whole number: ");
            int num3 = int.Parse(Console.ReadLine());

            int largest = Math.Max(num1, Math.Max(num2, num3)); // Determines the largest value of the three entered numbers
            Console.WriteLine($"The largest number among {num1}, {num2}, and {num3} is {largest}.");

            //User enters a grade, and the system will determine what kind of grade the entered char is
            Console.Write("Enter a grade (A, B, C, D, F): ");
            char grade = char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();  // Moves down to the next line

            switch (grade) // Determines what kind of letter grade the user entered is. If 'A' is typed, it returns as "Superior", and so forth
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