


//Program to illustrate use of  Convert.ToInt32 

using System;
using System.Diagnostics.Metrics;
class ExampleToConvetToIntExplicitly
{
    static void Main()
    {

        Console.WriteLine("Enter Two Numbers ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        int num2 = Convert.ToInt32(Console.ReadLine());
        int sum = num1 + num2;
        Console.WriteLine("sum :" + sum);
    }
}

/*INPUT:
Enter Two Numbers
10
20
OUTPUT:
sum: 30
*/