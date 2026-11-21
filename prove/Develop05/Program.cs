using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static List<BaseGoal> _goals = new List<BaseGoal>();
    static int _score = 0;

    // Creativity feature: the player's level increases every 1000 points.
    // The program also shows how many points are needed for the next level.
    static void Main(string[] args)
    {
        int choice = 0;
        while (choice != 6)
        {
            Console.WriteLine($"\nYou have {_score} points.");
            Console.WriteLine($"Level: {_score / 1000 + 1} ({1000 - _score % 1000} points until next level)");
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = ReadNumber();

            if (choice == 1)
            {
                CreateGoal();
            }
            else if (choice == 2)
            {
                ListGoals();
            }
            else if (choice == 3)
            {
                SaveGoals();
            }
            else if (choice == 4)
            {
                LoadGoals();
            }
            else if (choice == 5)
            {
                RecordEvent();
            }
            else if (choice != 6)
            {
                Console.WriteLine("Please choose a valid menu option.");
            }
        }
    }

    public static int ReadNumber()
    {
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out int number) && number >= 0)
                return number;
            Console.Write("Please enter a valid nonnegative number: ");
        }
    }

    public static int ReadPositiveNumber()
    {
        while (true)
        {
            int number = ReadNumber();
            if (number > 0) return number;
            Console.Write("Please enter a number greater than zero: ");
        }
    }

    static void CreateGoal()
    {
        Console.WriteLine("The types of goals are:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        int choice = ReadNumber();

        if (choice == 1)
        {
            _goals.Add(new SimpleGoal());
        }
        else if (choice == 2)
        {
            _goals.Add(new EternalGoal());
        }
        else if (choice == 3)
        {
            _goals.Add(new ChecklistGoal());
        }
        else
        {
            Console.WriteLine("Invalid goal type.");
        }
    }

    static void ListGoals()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("You do not have any goals yet.");
            return;
        }
        Console.WriteLine("The goals are:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetConsoleString()}");
        }
    }

    static void RecordEvent()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("Create a goal first.");
            return;
        }
        Console.WriteLine("The goals are:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetName()}");
        }
        Console.Write("Which goal did you accomplish? ");
        int choice = ReadNumber();
        if (choice < 1 || choice > _goals.Count)
        {
            Console.WriteLine("Invalid goal number.");
            return;
        }
        int earned = _goals[choice - 1].RecordEvent();
        _score += earned;
        Console.WriteLine($"You earned {earned} points! You now have {_score} points.");
    }

    static void SaveGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine() ?? "";
        try
        {
            using (StreamWriter file = new StreamWriter(filename))
            {
                file.WriteLine(_score);
                foreach (BaseGoal goal in _goals)
                {
                    file.WriteLine(goal.GetSaveString());
                }
            }
            Console.WriteLine("Goals saved.");
        }
        catch (Exception error)
        {
            Console.WriteLine($"Could not save goals: {error.Message}");
        }
    }

    // Load the score first, then rebuild each goal from the saved lines.
    static void LoadGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine() ?? "";
        try
        {
            string[] lines = File.ReadAllLines(filename);
            if (lines.Length == 0) throw new Exception("The file is empty.");
            int loadedScore = int.Parse(lines[0]);
            List<BaseGoal> loadedGoals = new List<BaseGoal>();
            for (int i = 1; i < lines.Length; i++)
            {
                if (string.IsNullOrWhiteSpace(lines[i]))
                {
                    continue;
                }
                string[] parts = lines[i].Split('|');
                string type = parts[0];
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);
                bool complete = bool.Parse(parts[4]);
                if (type == "SimpleGoal")
                {
                    loadedGoals.Add(new SimpleGoal(name, description, points, complete, type));
                }
                else if (type == "EternalGoal")
                {
                    loadedGoals.Add(new EternalGoal(name, description, points, complete, type));
                }
                else if (type == "ChecklistGoal")
                {
                    loadedGoals.Add(new ChecklistGoal(name, description, points, complete, type,
                        int.Parse(parts[5]), int.Parse(parts[6]), int.Parse(parts[7])));
                }
                else
                {
                    throw new Exception("Unknown goal type in save file.");
                }
            }
            _score = loadedScore;
            _goals = loadedGoals;
            Console.WriteLine("Goals loaded.");
        }
        catch (Exception error)
        {
            Console.WriteLine($"Could not load goals: {error.Message}");
        }
    }
}
