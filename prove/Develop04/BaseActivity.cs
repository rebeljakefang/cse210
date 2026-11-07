
using System;

class BaseActivity
{
    private string _name;
    private string _description;
    private int _duration;
    private DateTime _endTime;

    public BaseActivity(string name, string description)
    {
        _name = name;
        _description = description;
        _duration = 30;
    }

    public void ObtainDuration()
    {
        Console.Write("How long, in seconds, would you like for your session? ");

        string input = Console.ReadLine();
        int duration;

        if (int.TryParse(input, out duration) && duration > 0)
        {
            _duration = duration;
        }
        else
        {
            Console.WriteLine("Invalid duration. Using 30 seconds.");
            _duration = 30;
        }
    }

    public void StartActivity()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} Activity.");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();

        ObtainDuration();

        Console.WriteLine();
        RunSpinnerMessage("Get ready", 3);
        Console.WriteLine();
    }

    public void EndActivity()
    {
        Console.WriteLine();
        Console.WriteLine("Well done!");
        RunSpinnerMessage("Finishing", 3);

        Console.WriteLine();
        Console.WriteLine($"You have completed {_duration} seconds of the {_name} Activity.");
        RunSpinnerMessage("Returning to menu", 3);
    }

    public void StartTimer()
    {
        _endTime = DateTime.Now.AddSeconds(_duration);
    }

    public bool HasTimerExpired()
    {
        return DateTime.Now > _endTime;
    }

    public int GetDuration()
    {
        return _duration;
    }

    public void RunCountDownMessage(string message, int seconds)
    {
        Console.CursorVisible = false;

        for (int i = seconds; i > 0; i--)
        {
            Console.Clear();
            Console.WriteLine($"{message} - {i}");
            Thread.Sleep(1000);
        }

        Console.CursorVisible = true;
    }

    public void RunSpinnerMessage(string message, int seconds)
    {
        Console.CursorVisible = false;

        Console.Write($"{message} ");

        DateTime endTime = DateTime.Now.AddSeconds(seconds);

        while (DateTime.Now < endTime)
        {
            Console.Write("+");
            Thread.Sleep(200);
            Console.Write("\b");
            Console.Write("-");
            Thread.Sleep(200);
            Console.Write("\b");
            Console.Write("*");
            Thread.Sleep(200);
            Console.Write("\b");
        }

        Console.CursorVisible = true;
        Console.WriteLine();
    }
}
