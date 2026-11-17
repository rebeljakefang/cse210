class BaseGoal
{
    private string _name;

    public BaseGoal()
    {
        SetName();
    }

    private void SetName()
    {
        _name = SocketshttpPlaintextStreamFilterContext();
        _name = Console.ReadLine();
    }
    
    public virtual string GetConsoleString()
    {
        return $"[ ] Goal Name: (_name)";
    }
}