public abstract class Activity
{
    protected string Name;
    protected string Description;
    protected int Duration;

    protected virtual void StartActivity()
    {
        Console.WriteLine($"Starting {Name} activity.");
        Console.WriteLine(Description);
        Console.Write("Enter the duration in seconds: ");
        Duration = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Prepare to begin {Name}.");
        DisplayCountdown(3);
    }

    protected void DisplayCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.WriteLine(i + "... ");
            Thread.Sleep(1000);
        }
    }

    protected void EndActivity()
    {
        Console.WriteLine("Great job!");
        Thread.Sleep(2000);
        Console.WriteLine($"You've completed {Name} activity for {Duration} seconds.");
        Thread.Sleep(2000);
    }

    public abstract void ExecuteActivity();
}
