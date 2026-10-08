class JournalEntry
{
    public string _date;

    public string _prompt;
    
    public string _response;

    public void DisplayJournalEntry()
    {
        console.WriteLine($"{_date}, {_prompt}");
        console.WriteLine(_response);
    }
    public void CreateJournalEntry()
    {
        string [] prompts =
        {
            "How was your day. ",
            "Talk about someone you met. "
        };
        _date = DateTime.now.ToString();
        _prompt ="How was your Day? ";
        Console.WriteLine($"{_prompt}: ");
        _response = Console.ReadLine();
    }
}