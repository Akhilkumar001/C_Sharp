//basic Program in C#
using System;
class BasicProgram
{
    static void Main()
    {
        Console.WriteLine("Enter greetings Message : ");
        string greetings = Console.ReadLine();
        Console.WriteLine("Enter your ID ");
        int id = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Hi " + id + " " + greetings);
    }
}


/*
INPUT:
Enter greetings Message:
Welocme to Wipro
Enter your ID 
1001

OUTPUT:

Hi 1001 Welocme to Wipro*/
