using System;

class Program
{
    
//    static void Main(string[] args)
//    {
//     Console.Write("What is your height? ");
//     string height = Console.ReadLine();
//     int number = int.Parse(height);
//     if (number < 48)
//     {
//         Console.WriteLine("You are to short");
//     } 
//     if (number > 72)
//         {
//             Console.WriteLine("you are too tall");
//         }
//     else
//         {
//             Console.WriteLine("you are the perfect height");
//         }
//     }
// }


   static void Main(string[] args)
    {
        static void greet()
        {
            Console.WriteLine("Hello");
        }
        static int Add(int firstnumber, int secondnumber)
        {
         int total = firstnumbernumber + secondnumber;
         return total;   
        }

        static void PrintMessage()
        {
            Console.WriteLine("Welcome!");
        }
        static string getname()
        {
            return "Jacob";
        }
        static void SayHello(string name)
        {
            SayHello("Jacob");
        }
        static string GetGrade(int score)
        {
            if (score >= 90)
            {
                return "A";
            }
            else
            {
                return "not an A";
            }
            static int DoubleNumber(int number)
            {
                return number * 2;
            }
            Console.WriteLine(DoubleNumber(5));
        }
    }
}