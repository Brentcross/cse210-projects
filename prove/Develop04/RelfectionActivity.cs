using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

public class ReflectionActivity : Activity
{
    private static readonly List<string> prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private static readonly List<string> questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    private Random random = new Random();

    public ReflectionActivity()
    {
        Name = "Reflection";
        Description = "This activity will help you reflect on times in your life when you have shown strength and resilience. " +
                      "This will help you recognize the power you have and how you can use it in other aspects of your life.";
    }

    public override void ExecuteActivity()
    {
        StartActivity();
        DateTime endTime = DateTime.Now.AddSeconds(Duration);

        string selectedPrompt = prompts[random.Next(prompts.Count)];
        Console.WriteLine(selectedPrompt);
        Thread.Sleep(2000);

        while (DateTime.Now < endTime)
        {
            string randomQuestion = questions[random.Next(questions.Count)];
            Console.WriteLine(randomQuestion);
            DisplaySpinner(5);
        }

        EndActivity();
    }

    private void DisplaySpinner(int seconds)
    {
        char[] spinnerChars = { '|', '/', '-', '\\' };
        for (int i = 0; i < seconds * 4; i++)  
        {
            Console.Write(spinnerChars[i % 4] + "\r");
            Thread.Sleep(250);
        }
    }
}
