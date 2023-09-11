using System;


class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your score anywhere between 0-100: ");
        if (double.TryParse(Console.ReadLine(), out double score))
        {
            if (score >= 93)
            {
                Console.WriteLine("Great Job! Your grade is an A.");
            }
            else if (score >= 90)
            {
                Console.WriteLine("Your grade is an A-.");
            }
            else if (score >= 87)
            {
                Console.WriteLine("Your grade is B+.");
            }
            else if (score >= 83)
            {
                Console.WriteLine("Your grade is B.");
            }
            else if (score >= 80)
            {
                Console.WriteLine("Your grade is B-.");
            }
            else if (score >= 77)
            {
                Console.WriteLine("Your grade is C+.");
            }
            else if (score >= 73)
            {
                Console.WriteLine("Your grade is C.");
            }
            else if (score >= 70)
            {
                Console.WriteLine("Your grade is C-.");
            }
            else if (score >= 60)
            {
                Console.WriteLine("Try harder, Your grade is D.");
            }
            else
            {
                Console.WriteLine("You need some work. Your grade is F.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a number between 0 and 100.");
        }
    }
}
