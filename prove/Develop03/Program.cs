using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // For the extra part I added a few scriptures so it picks a random one
        // when you start. I also made it only hide words that are not hidden yet
        // so it does not keep picking the same words.

        List<Scripture> scriptures = new List<Scripture>();

        Reference reference1 = new Reference("Moses", 1, 39);
        scriptures.Add(new Scripture(reference1,
            "For behold, this is my work and my glory—to bring to pass the immortality and eternal life of man."));

        Reference reference2 = new Reference("Proverbs", 3, 5, 6);
        scriptures.Add(new Scripture(reference2,
            "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths."));

        Reference reference3 = new Reference("1 Nephi", 3, 7);
        scriptures.Add(new Scripture(reference3,
            "I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them."));

        Random random = new Random();
        Scripture myScripture = scriptures[random.Next(scriptures.Count)];

        while (true)
        {
            Console.Clear();
            myScripture.ShowScripture();

            if (myScripture.IsCompletelyHidden())
            {
                break;
            }

            Console.WriteLine();
            Console.WriteLine("Press Enter to hide words or type quit to exit:");

            string input = Console.ReadLine();

            if (input == null || input.ToLower() == "quit")
            {
                break;
            }

            if (input == "")
            {
                myScripture.HideRandomWords(3);
            }
        }
    }
}