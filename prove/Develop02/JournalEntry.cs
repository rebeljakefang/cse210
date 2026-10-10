class JournalEntry
{
    public string _date;
    public string _prompt;
    public string _response;
    public string _mood;

    public void DisplayJournalEntry()
    {
        Console.WriteLine($"{_date}, {_prompt}");
        Console.WriteLine(_response);
        Console.WriteLine($"Mood: {_mood}");
    }

    public void CreateJournalEntry()
    {
        string[] prompts =
        {
            "How was your day?",
            "Talk about someone you met.",
            "What was the best part of your day?",
            "What is something you learned today?",
            "What would you change about today?"
        };

        Random random = new Random();
        int index = random.Next(prompts.Length);

        _date = DateTime.Now.ToShortDateString();
        _prompt = prompts[index];

        Console.WriteLine(_prompt);
        _response = Console.ReadLine();

        Console.WriteLine("How are you feeling today?");
        _mood = Console.ReadLine();
    }
}