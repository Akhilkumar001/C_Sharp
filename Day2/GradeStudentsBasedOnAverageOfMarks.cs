//program to Grade Students on the basis of Average of Marks


using System;
using System.Diagnostics.Metrics;
class GradeStudentsBasedOnAverageOfMarks
{
    static void Main()
    {
        Console.WriteLine("Enter NumberofMarks   : ");
        int numberofMarks = Convert.ToInt32(Console.ReadLine());
        int sumOFAllMarks = 0;
        int count = numberofMarks;
        Console.WriteLine("Enter " + numberofMarks + " number of  Marks");
        while (count > 0)
        {
            int currentMarks = Convert.ToInt32(Console.ReadLine());
            sumOFAllMarks += currentMarks;
            count--;
        }
        int averageOfAllMarks = sumOFAllMarks / numberofMarks;
        string resultingGrade = (averageOfAllMarks >= 70 && averageOfAllMarks <= 75) ? "Excellent" :
        (averageOfAllMarks >= 60 && averageOfAllMarks <= 70) ? "Good" : averageOfAllMarks < 45 ? "Fail" : "Pass";

        Console.WriteLine("averageOfAllMarks :" + averageOfAllMarks);

        Console.WriteLine("resultingGrade :" + resultingGrade);
    }
}

/*Input:
Enter NumberofMarks   : 
5
Enter 5 number of  Marks
75
75
75
75
75

Output:
averageOfAllMarks: 75
resultingGrade: Excellent

Input :
Enter NumberofMarks   : 
5
Enter 5 number of  Marks
65
65
65
65
65

Output:
averageOfAllMarks: 65
resultingGrade: Good

Input :
Enter NumberofMarks   : 
5
Enter 5 number of  Marks
35
35
35
35
35

Output:
averageOfAllMarks: 35
resultingGrade: Fail

Input :
Enter NumberofMarks   : 
5
Enter 5 number of  Marks
55
55
55
55
55

Output:
averageOfAllMarks: 55
resultingGrade: Pass*/
