using System;

class Program
{
    static void Main(string[] args)
    {
        
        string numberString = "100"; 
        int myNumber = int.Parse(numberString);
        Console.WriteLine("");
        Console.Write("what is your grade ");
        string userInput = Console.ReadLine();
        int number = int.Parse(userInput);
        string letter = "";
        
        if (number >= 90)
        {
            letter = "A";
        }
        else if (number >= 80)
        {
            letter = "B";
        }
        else if (number >= 70)
        {
            letter = "C";
        }
        else if (number >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        Console.WriteLine($"your grade is {letter}");

        if (number >= 70)
        {
            Console.WriteLine("you passed!");
        }
        else
        {
            Console.WriteLine("you did not pass");
        }
    }
}