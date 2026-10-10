class Menu
{
    public int ProcessMenu()
    {
        int input = 0;

        while (input < 1 || input > 5)
        {
            Console.WriteLine("Welcome to the journal program");
            Console.WriteLine("Create, display, save, or read entries");
            Console.WriteLine("1. Create journal entry");
            Console.WriteLine("2. Display all journal entries");
            Console.WriteLine("3. Save journal to a file");
            Console.WriteLine("4. Read journal from a file");
            Console.WriteLine("5. Quit");
            Console.WriteLine(">");

            int.TryParse(Console.ReadLine(), out input);
        }

        return input;
    }
}