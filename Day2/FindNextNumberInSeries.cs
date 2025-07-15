//program to FindNextNuberSeries 
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
class FindNextNumberInSeries
{

    public static int NextNumberInSeries(List<int> myDs, int oddValue, int evenValue)
    {
        int ans = -1;
        if ((myDs.Count) % 2 == 0)
        {
            ans = myDs[myDs.Count - 1] + (evenValue); //even case
        }
        else if ((myDs.Count) % 2 != 0)
        {

            ans = myDs[myDs.Count - 1] + (oddValue); //odd case 
        }
        return ans;
    }

    public static void Main()
    {
        List<int> arr = new List<int>();
        Console.WriteLine("Enter Number N");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Enter {n} Numbers ");
        for (int i = 0; i < n; i++)
        {
            int x = Convert.ToInt32(Console.ReadLine());
            arr.Add(x);
        }


        // foreach(int val in arr)
        // {
        //     Console.Write(val+" ,");
        // }

        // series 1=7,10,8,11,9,12  oddLength=+3 evenLength=-3
        //series 2=22,21,23,22,24,23 oddLength=+3 evenLength=-3
        //series 3=31,29,24,22,17 oddLength=-2 evenLength=-5
        Console.Write("NextNumberInSeries :" + NextNumberInSeries(arr, -2, -5));

    }
}


/*
INPUT:
Enter Number N
5
Enter 5 Numbers 
31
29
24
22
17
OUTPUT:
NextNumberInSeries: 15*/
