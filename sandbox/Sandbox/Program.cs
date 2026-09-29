using System;

class Program
{
    static void Main(string[] args)
     {
//         
        // bool done = false;

        // while (! done)
        // {
        //     Console.Write("are we done (y/n)? ")
        //     done = Console.ReadLine() == "y" ;  
        // }

        //  bool done = false;

        // do
        // {
        //     Console.Write("are we done (y/n)? ")
        //     done = Console.ReadLine().ToLower() == "y" ;  
        // } while (! done);

        for (double i = 0; i < 1.0; i += 0.01)
        {
            Console.WriteLine(i);
        }
        
        list<string> myFriends = new List<string>  ("bob","betty","Bubba");

        myFriends.Add("doug");
        foreach(string friend in myFriends);
        {
            Console.WriteLine(friend);
        }

        
    }
}