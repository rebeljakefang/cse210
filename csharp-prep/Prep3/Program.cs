using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the magic number? ");
        string magicString = Console.ReadLine();
        int magicNumber = int.Parse(magicString);

        Console.Write("What is your guess? ");
        string guessString = Console.ReadLine();
        int guess = int.Parse(guessString);

        if (guess < magicNumber)
        {
            Console.WriteLine("Higher");
        }
        else if (guess > magicNumber)
        {
            Console.WriteLine("Lower");
        }
        else
        {
            Console.WriteLine("You guessed it!");
        }
    }
}