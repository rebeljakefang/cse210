class EternalGoal : BaseGoal
{
    public EternalGoal(string name, string description, int points, bool complete, string goalType)
        : base(name, description, points, complete, goalType)
    {
    }

    public EternalGoal() : base("EternalGoal")
    {
    }

    public override int RecordEvent()
    {
        // Eternal goals never become complete.
        return GetPoints();
    }
}
