
using System;

class Program
{
    static void Main(string[] args)
    {
        int choice = 0;
        int completedActivities = 0;

        // Creativity requirement:
        // I added a counter to track how many activities the user completes.
        // The counter shows up on the main menu after each activity.

        while (choice != 4)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program");
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
            Console.WriteLine();
            Console.WriteLine($"Activities completed: {completedActivities}");
            Console.Write("Select a choice from the menu: ");

            string input = Console.ReadLine();

            if (!int.TryParse(input, out choice))
            {
                choice = 0;
            }

            if (choice == 1)
            {
                BreathingActivity activity = new BreathingActivity();
                activity.RunActivity();
                completedActivities++;
            }
            else if (choice == 2)
            {
                ReflectingActivity activity = new ReflectingActivity();
                activity.RunActivity();
                completedActivities++;
            }
            else if (choice == 3)
            {
                ListingActivity activity = new ListingActivity();
                activity.RunActivity();
                completedActivities++;
            }
            else if (choice == 4)
            {
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid choice.");
                Thread.Sleep(1500);
            }
        }
    }
}
