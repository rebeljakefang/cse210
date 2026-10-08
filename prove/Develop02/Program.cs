using System;

class Program
{
    static void Main(string[] args)
    {
        Menu myMenu = new Menu();

        JournalEntry myEntry = new JournalEntry();

        Journal myJournal = new Journal();

        myMenu.ProcessMenu();

        int response = myMenu.ProcessMenu();
        while (response != 5)
        {
        switch(response)
        {
            case 1:
            Console.WriteLine("Create");
            myEntry.CreateJournalEntry();
            break;
            case 2:
            Console.WriteLine("Display");
            myEntry.CreateJournalEntry();
            break;
            case 3:
            Console.WriteLine("save");
            break;
            case 4:
            Console.WriteLine("Write");
            break;
        }
        }
    }
}