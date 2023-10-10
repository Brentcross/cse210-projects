using System;

public class EternalGoal : Goal
{
    public EternalGoal(string name, int points) : base(name, points) {}

    public override int RecordEvent()
    {
        return Points;
    }

    public override void Display()
    {
        Console.WriteLine($"[E] {Name}");
    }
}
