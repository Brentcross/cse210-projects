using System;

public class ChecklistGoal : Goal
{
    private int TargetCount { get; set; }
    private int CurrentCount { get; set; }
    private int Bonus { get; set; }

    public ChecklistGoal(string name, int points, int targetCount, int bonus) : base(name, points)
    {
        this.TargetCount = targetCount;
        this.Bonus = bonus;
    }

    public override int RecordEvent()
    {
        CurrentCount++;
        if (CurrentCount >= TargetCount && !Completed)
        {
            Completed = true;
            return Points + Bonus;
        }
        return Points;
    }

    public override void Display()
    {
        string status = Completed ? "[X]" : $"[{CurrentCount}/{TargetCount}]";
        Console.WriteLine($"{status} {Name}");
    }
}
