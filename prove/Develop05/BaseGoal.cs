abstract class BaseGoal
{
    private string _name;
    private string _description;
    private int _points;
    private bool _complete;
    private string _goalType;

    public BaseGoal(string name, string description, int points, bool complete, string goalType)
    {
        _name = name;
        _description = description;
        _points = points;
        _complete = complete;
        _goalType = goalType;
    }

    public BaseGoal(string goalType)
    {
        SetName();
        SetDescription();
        SetPoints();
        _complete = false;
        _goalType = goalType;
    }

    private void SetName()
    {
        Console.Write("What is the name of your goal: ");
        _name = Console.ReadLine() ?? "";
    }

    private void SetDescription()
    {
        Console.Write($"What is the description of {_name} goal: ");
        _description = Console.ReadLine() ?? "";
    }

    private void SetPoints()
    {
        Console.Write($"What are the points for {_name} goal: ");
        _points = Program.ReadNumber();
    }

    public virtual string GetConsoleString()
    {
        string completeString = " ";
        if (_complete)
        {
            completeString = "X";
        }
        return $"[{completeString}] {_goalType} Goal Name: {_name}, Description: {_description} points: {_points}";
    }

    public int MarkComplete()
    {
        _complete = true;
        return _points;
    }

    public bool IsComplete()
    {
        return _complete;
    }

    public int GetPoints()
    {
        return _points;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetDescription()
    {
        return _description;
    }

    public string GetGoalType()
    {
        return _goalType;
    }

    // Each goal writes its own information so it can be loaded again.
    public virtual string GetSaveString()
    {
        return $"{_goalType}|{_name}|{_description}|{_points}|{_complete}";
    }

    public abstract int RecordEvent();
}
