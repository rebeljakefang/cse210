
using System;
using System.Collections.Generic;

class ReflectingActivity : BaseActivity
{
    private List<string> _prompts = new List<string>()
    {
        "Think of a time when you helped someone.",
        "Think of a time when you accomplished something difficult.",
        "Think of a time when someone helped you.",
        "Think of a time when you made a good decision.",
        "Think of a time when you learned something new."
    };

    private List<string> _questions = new List<string>()
    {
        "Why was this experience important to you?",
        "What did you learn from this experience?",
        "How did you feel when it happened?",
        "What would you do differently next time?",
        "How has this experience helped you?",
        "What was the hardest part?",
        "How could you use what you learned in the future?"
    };

    private Random _random = new Random();

    public ReflectingActivity() : base(
        "Reflecting",
        "This activity will help you reflect on times when you have shown strength and resilience. Think about these experiences and what you learned from them.")
    {
    }

    public string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }

    public string GetRandomQuestion()
    {
        int index = _random.Next(_questions.Count);
        return _questions[index];
    }

    public void RunActivity()
    {
        StartActivity();

        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        Console.WriteLine($"--- {GetRandomPrompt()} ---");
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press Enter to continue.");

        Console.ReadLine();

        Console.WriteLine("Now think about the following questions.");
        RunCountDownMessage("Get Ready", 5);

        StartTimer();

        List<string> usedQuestions = new List<string>();

        while (!HasTimerExpired())
        {
            if (usedQuestions.Count == _questions.Count)
            {
                usedQuestions.Clear();
            }

            string question = GetRandomQuestion();

            while (usedQuestions.Contains(question))
            {
                question = GetRandomQuestion();
            }

            usedQuestions.Add(question);

            Console.Clear();
            Console.WriteLine($"> {question}");
            Console.WriteLine();

            RunSpinnerMessage("Thinking", 10);
        }

        EndActivity();
    }
}
