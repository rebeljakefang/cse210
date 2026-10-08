class Journal
{
    public void DisplayJournal()
    {
        foreach(JournalEntry entry in _entries)
        {
            entry.DisplayJournalEntry();
        }
    }
    public void CreateJournalEntry()
    {
        CreateJournalEntry newEntry = new JournalEntry();
        newEntry.CreateJournalEntry();
        _entries .add(newEntry);
    }
}