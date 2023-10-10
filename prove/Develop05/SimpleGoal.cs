using System;

public class SimpleGoal : Goal
{
    public SimpleGoal(string name, int points) : base(name, points) {}

    public override int RecordEvent()
    {
        Completed = true;
        return Points;
    }

    public override void Display()
    {
        string status = Completed ? "[X]" : "[ ]";
        Console.WriteLine($"{status} {Name}");
    }
}
