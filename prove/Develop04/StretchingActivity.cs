public class StretchingActivity : Activity
{
    public StretchingActivity()
    {
        Name = "Stretching";
        Description = "This activity will guide you through a series of stretches to help you relax and improve flexibility.";
    }

    public override void ExecuteActivity()
    {
        StartActivity();

        int stretchesCount = Duration / 30;
        for(int i = 0; i < stretchesCount; i++)
        {
            DoStretch("arms", 10);
            DoStretch("legs", 10);
            DoStretch("chest", 10);
        }

        EndActivity();
    }

    private void DoStretch(string bodyPart, int seconds)
    {
        Console.WriteLine($"Stretch your {bodyPart}...");
        DisplayCountdown(seconds);
    }
}
