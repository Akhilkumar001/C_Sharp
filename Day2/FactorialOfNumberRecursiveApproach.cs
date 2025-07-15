//Program to Compute factorial of given number in Recursive Approach  

using System;
using System.Diagnostics.Metrics;
class FactorialOfNumberRecursiveApproach
{


    public static int FactorialOfNumber(int n)
    {
        if (n <= 1)
        {
            return 1;
        }
        return n * FactorialOfNumber(n - 1);
    }
    static void Main()
    {
        Console.WriteLine("Enter Number :");
        int num = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("FactorialOfNumber {0} = {1}", num, FactorialOfNumber(num));

    }
}

/*INPUT:
Enter Number :
5

OUTPUT:
FactorialOfNumber 5 = 120*/

