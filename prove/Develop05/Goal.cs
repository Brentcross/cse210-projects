public abstract class Goal
{
    public string Name { get; protected set; }
    protected int Points { get; set; }
    protected bool Completed { get; set; }

    public Goal(string name, int points)
    {
        this.Name = name;
        this.Points = points;
    }

    public abstract int RecordEvent();
    public abstract void Display();
}
