public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        Name = "Breathing";
        Description = "This activity will help you relax by walking you through breathing in and out slowly.";
    }

    public override void ExecuteActivity()
    {
        StartActivity();
        DateTime end = DateTime.Now.AddSeconds(Duration);
        while (DateTime.Now < end)
        {
            Console.WriteLine("Breathe in...");
            DisplayCountdown(5);
            Console.WriteLine("Breathe out...");
            DisplayCountdown(5);
        }
        EndActivity();
    }
}