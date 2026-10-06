class Menu
{
    public int ProcessMenu()
    {
        Console.WriteLine("In the menu class");
        int input = 0;
        while (input < 1 || input > 5)
        {
           Console.WriteLine("welcome to the jornal program");
           Console.WriteLine("create display save or read entries");
           Console.WriteLine("1. create journal entry");
           Console.WriteLine("2. display all jornal entry");
           Console.WriteLine("3. save jornal to a file");
           Console.WriteLine("4. read jornal to a file");
           Console.WriteLine("5. quit");
           Console.WriteLine(">");
           input = int.Parse(Console.ReadLine()); 
        }
        return input;
    }
}