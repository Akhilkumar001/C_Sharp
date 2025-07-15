//Program to return SumOfDigits of given Number

using System;
using System.Diagnostics.Metrics;
class SumOfDigitsProgram
{


    public static int DigitSum(int n)
    {
        int sumOfDigits = 0;
        while (n > 0)
        {
            int currentLastDigit = n % 10;
            sumOfDigits += currentLastDigit;
            n /= 10;
        }
        return sumOfDigits;
    }
    static void Main()
    {
        Console.WriteLine("Enter Number :");
        int num = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("sumOfDigits :" + DigitSum(num));

    }
}

/*INPUT:2

Enter Number : 
123

OUTPUT:
sumOfDigits: 6*/
