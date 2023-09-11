using System;
using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();

            Console.WriteLine("Enter a list of numbers, type 0 when finished.");

            while (true)
            {
                Console.Write("Enter number: ");
                bool isNumber = int.TryParse(Console.ReadLine(), out int userNumber);

                if (!isNumber)
                {
                    Console.WriteLine("Please enter a valid number.");
                    continue;
                }

                if (userNumber == 0) break;

                numbers.Add(userNumber);
            }

            int sum = 0;
            int largestNumber = int.MinValue;

            foreach (var number in numbers)
            {
                sum += number;

                if (number > largestNumber)
                {
                    largestNumber = number;
                }
            }

            double average = (double)sum / numbers.Count;

            Console.WriteLine($"The sum is: {sum}");
            Console.WriteLine($"The average is: {Math.Round(average, 2)}");
            Console.WriteLine($"The largest number is: {largestNumber}");
        }
    }
