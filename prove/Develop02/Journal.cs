class Journal
{
    private List<JournalEntry> _entries = new List<JournalEntry>();

    public void DisplayJournal()
    {
        foreach (JournalEntry entry in _entries)
        {
            entry.DisplayJournalEntry();
        }
    }

    public void CreateJournalEntry()
    {
        JournalEntry newEntry = new JournalEntry();
        newEntry.CreateJournalEntry();
        _entries.Add(newEntry);
    }

    public void SaveJournal()
    {
        Console.WriteLine("What is the filename?");
        string filename = Console.ReadLine();

        using (StreamWriter file = new StreamWriter(filename))
        {
            foreach (JournalEntry entry in _entries)
            {
                file.WriteLine($"{entry._date}|{entry._prompt}|{entry._response}|{entry._mood}");
            }
        }
    }

    public void LoadJournal()
    {
        Console.WriteLine("What is the filename?");
        string filename = Console.ReadLine();

        if (File.Exists(filename))
        {
            string[] lines = File.ReadAllLines(filename);

            _entries.Clear();

            foreach (string line in lines)
            {
                string[] parts = line.Split("|");

                JournalEntry entry = new JournalEntry();

                entry._date = parts[0];
                entry._prompt = parts[1];
                entry._response = parts[2];
                entry._mood = parts[3];

                _entries.Add(entry);
            }
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}