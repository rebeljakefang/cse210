
using System;
using System.Collections.Generic;

class ListingActivity : BaseActivity
{
    private List<string> _prompts = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are some things you are good at?",
        "What are things that make you happy?",
        "What are some goals you want to accomplish?",
        "What are things you are grateful for?"
    };

    private int _count;
    private Random _random = new Random();

    public ListingActivity() : base(
        "Listing",
        "This activity will help you think about the good things in your life by listing as many things as you can in a certain amount of time.")
    {
    }

    public string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }

    public void GetListFromUser()
    {
        _count = 0;

        StartTimer();

        while (!HasTimerExpired())
        {
            Console.Write("> ");
            string answer = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(answer))
            {
                _count++;
            }
        }
    }

    public void RunActivity()
    {
        StartActivity();

        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine();
        Console.WriteLine($"--- {GetRandomPrompt()} ---");
        Console.WriteLine();

        Console.WriteLine("You may begin in:");
        RunCountDownMessage("Get Ready", 5);

        Console.Clear();
        Console.WriteLine("Start listing your answers:");

        GetListFromUser();

        Console.WriteLine();
        Console.WriteLine($"You listed {_count} items!");

        EndActivity();
    }
}
