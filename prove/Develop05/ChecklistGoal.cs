class ChecklistGoal : BaseGoal
{
    private int _currentCount;
    private int _targetCount;
    private int _bonus;

    public ChecklistGoal() : base("ChecklistGoal")
    {
        Console.Write("How many times does this goal need to be completed? ");
        _targetCount = Program.ReadPositiveNumber();
        Console.Write("What is the bonus for finishing the checklist? ");
        _bonus = Program.ReadNumber();
        _currentCount = 0;
    }

    public ChecklistGoal(string name, string description, int points, bool complete, string goalType,
        int currentCount, int targetCount, int bonus)
        : base(name, description, points, complete, goalType)
    {
        _currentCount = currentCount;
        _targetCount = targetCount;
        _bonus = bonus;
    }

    public override int RecordEvent()
    {
        if (IsComplete())
        {
            Console.WriteLine("This checklist is already complete.");
            return 0;
        }

        _currentCount++;
        int earned = GetPoints();
        if (_currentCount >= _targetCount)
        {
            MarkComplete();
            earned += _bonus;
        }
        return earned;
    }

    public override string GetConsoleString()
    {
        return $"{base.GetConsoleString()} -- Completed {_currentCount}/{_targetCount}";
    }

    public override string GetSaveString()
    {
        return $"{base.GetSaveString()}|{_currentCount}|{_targetCount}|{_bonus}";
    }
}
