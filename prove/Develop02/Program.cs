using System;

class Program
{
    static void Main(string[] args)
    {
        Menu myMenu = new Menu();

        myMenu.ProcessMenu();
        int response = myMenu.ProcessMenu();
        while (response != 5)
        {
        switch(response)
        {
            case 1:
            Console.WriteLine("Create");
            break;
            case 2:
            Console.WriteLine("Display");
            break;
            case 3:
            Console.WriteLine("save");
            break;
            case 4:
            Console.WriteLine("Write");
            break;
        }}
    }
}