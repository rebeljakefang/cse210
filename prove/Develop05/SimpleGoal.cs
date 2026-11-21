class SimpleGoal : BaseGoal
{
    public SimpleGoal(string name, string description, int points, bool complete, string goalType)
        : base(name, description, points, complete, goalType)
    {
    }

    public SimpleGoal() : base("SimpleGoal")
    {
    }

    public override int RecordEvent()
    {
        if (IsComplete())
        {
            Console.WriteLine("This goal is already complete.");
            return 0;
        }
        return MarkComplete();
    }
}
