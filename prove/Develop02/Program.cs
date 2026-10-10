// To exceed the requirements, I added a mood to each journal entry.
// The program asks how the user is feeling and saves their mood
// along with the date, prompt, and response.
class Program
{
    static void Main(string[] args)
    {
        Menu myMenu = new Menu();
        Journal myJournal = new Journal();

        int response = myMenu.ProcessMenu();

        while (response != 5)
        {
            switch (response)
            {
                case 1:
                    Console.WriteLine("Create");
                    myJournal.CreateJournalEntry();
                    break;

                case 2:
                    Console.WriteLine("Display");
                    myJournal.DisplayJournal();
                    break;

                case 3:
                    Console.WriteLine("Save");
                    myJournal.SaveJournal();
                    break;

                case 4:
                    Console.WriteLine("Load");
                    myJournal.LoadJournal();
                    break;
            }

            response = myMenu.ProcessMenu();
        }
    }
}