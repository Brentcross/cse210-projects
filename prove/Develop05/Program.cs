using System;
using System.Runtime.CompilerServices;

namespace YourNamespaceName
{
public class Program
{
    public static void Main(string[] args)
    {
        User user = new User();

        while (true)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Create a new goal");
            Console.WriteLine("2. Record a goal accomplishment");
            Console.WriteLine("3. Display all goals");
            Console.WriteLine("4. Display score");
            Console.WriteLine("5. Clear all goals and scores");
            Console.WriteLine("6. Exit");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    CreateGoal(user);
                    break;
                case "2":
                    RecordGoal(user);
                    break;
                case "3":
                    user.DisplayGoals();
                    break;
                case "4":
                    Console.WriteLine($"Your Score: {user.GetScore()}");
                    break;
                case "5":
                    user.ClearGoalsAndScores();
                    Console.WriteLine("All goals and scores have been cleared");
                    break;
                case "6":
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    private static void CreateGoal(User user)
    {
        Console.WriteLine("Select goal type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        string goalType = Console.ReadLine();
        Console.WriteLine("Enter goal name:");
        string name = Console.ReadLine();
        Console.WriteLine("Enter points for this goal:");
        int points = Convert.ToInt32(Console.ReadLine());

        switch (goalType)
        {
            case "1":
                user.AddGoal(new SimpleGoal(name, points));
                break;
            case "2":
                user.AddGoal(new EternalGoal(name, points));
                break;
            case "3":
                Console.WriteLine("Enter target count for this goal:");
                int target = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter bonus points for completing the goal:");
                int bonus = Convert.ToInt32(Console.ReadLine());
                user.AddGoal(new ChecklistGoal(name, points, target, bonus));
                break;
            default:
                Console.WriteLine("Invalid choice.");
                break;
        }
    }

    private static void RecordGoal(User user)
    {
        Console.WriteLine("Enter the name of the goal you accomplished:");
        string name = Console.ReadLine();
        user.RecordEvent(name);
        Console.WriteLine($"Goal recorded! Your current score: {user.GetScore()}");
    }
}
}