using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

public class ListingActivity : Activity
{
    private static readonly List<string> prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    private Random random = new Random();
    private List<string> userEntries = new List<string>();

    public ListingActivity()
    {
        Name = "Listing";
        Description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }

    public override void ExecuteActivity()
    {
        StartActivity();
        DateTime endTime = DateTime.Now.AddSeconds(Duration);

        string selectedPrompt = prompts[random.Next(prompts.Count)];
        Console.WriteLine(selectedPrompt);
        DisplayCountdown(3);

        Console.WriteLine("Start listing items. Press Enter after each item:");
        while (DateTime.Now < endTime)
        {
            if (Console.KeyAvailable)
            {
                string userInput = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(userInput))
                {
                    userEntries.Add(userInput);
                }
            }
            Thread.Sleep(100);
        }

        Console.WriteLine($"You listed {userEntries.Count} items.");
        EndActivity();
    }
}