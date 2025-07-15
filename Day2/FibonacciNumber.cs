using System;
using System.Diagnostics.Metrics;
class FibonacciNUmber
{


    public static int ComputeFibonacciNUmber(int n)
    {
        int a = 0;
        int b = 1;
        int c = 0;
        Console.WriteLine($"{1}st Fibonacci Number  {c}");
        for (int i = 1; i < n; i++)
        {
            c = a + b;
            Console.WriteLine($"{i + 1}th Fibonacci Number  {c}");
            a = b;
            b = c;


        }
        return c;
    }


    static void Main()
    {
        Console.WriteLine("Enter Number");
        int num = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("ComputeFibonacciNUmber {0} = {1}", num, ComputeFibonacciNUmber(num));


    }
}

/*INPUT:
Enter Number
5
OUTPUT:
1st Fibonacci Number  0
2th Fibonacci Number  1
3th Fibonacci Number  2
4th Fibonacci Number  3
5th Fibonacci Number  5
ComputeFibonacciNUmber 5 = 5*/