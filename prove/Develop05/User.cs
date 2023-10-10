using System.Collections.Generic;

public class User
{
    private int Score { get; set; }
    private List<Goal> Goals { get; set; }

    public User()
    {
        this.Score = 0;
        this.Goals = new List<Goal>();
    }

    public void AddGoal(Goal goal)
    {
        Goals.Add(goal);
    }

    public void RecordEvent(string goalName)
    {
        foreach (var goal in Goals)
        {
            if (goal.Name == goalName)
            {
                Score += goal.RecordEvent();
                break;
            }
        }
    }

    public void DisplayGoals()
    {
        foreach (var goal in Goals)
        {
            goal.Display();
        }
    }

    public int GetScore()
    {
        return Score;
    }
    public void ClearGoalsAndScores()
    {
            Goals.Clear();
            Score = 0;
    }
}
