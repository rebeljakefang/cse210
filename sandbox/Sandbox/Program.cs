using System;

class Program
{
    
   static void Main(string[] args)
   {
    Console.Write("What is your height? ");
    string height = Console.ReadLine();
    int number = int.Parse(height);
    if (number < 48)
    {
        Console.WriteLine("You are to short");
    } 
    if (number > 72)
        {
            Console.WriteLine("you are too tall");
        }
    else
        {
            Console.WriteLine("you are the perfect height");
        }
    }
}