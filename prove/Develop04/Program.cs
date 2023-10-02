using System;
using System.Collections.Generic;

public static class Program
{
    public static void Main()
    {
        bool continueRunning = true;

        while (continueRunning)
        {
            Console.WriteLine("Choose an activity:");
            Console.WriteLine("1) Breathing");
            Console.WriteLine("2) Reflection");
            Console.WriteLine("3) Listing");
            Console.WriteLine("4) Exit");

            int choice;
            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                continue;
            }

            Activity activity = null;

            switch (choice)
            {
                case 1:
                    activity = new BreathingActivity();
                    break;
                case 2:
                    activity = new ReflectionActivity();
                    break;
                case 3:
                    activity = new ListingActivity();
                    break;
                case 4:
                    continueRunning = false;
                    Console.WriteLine("Thank you for using the Meditaion Simulation :) Have a peaceful day!");
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    continue;
            }

            if (activity != null)
            {
                activity.ExecuteActivity();
            }
        }
    }
}
