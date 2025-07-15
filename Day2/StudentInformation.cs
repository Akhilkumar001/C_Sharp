//program to print student informatin and average marks
using System;
using System.Collections.Generic;
class StudentInformation
{
    static void Main()
    {

        Console.WriteLine("enter your Name :");
        string name = Console.ReadLine();
        Console.WriteLine("enter your adress :");

        string address = Console.ReadLine();
        Console.WriteLine("enter your rollNo :");

        int rollNo = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("enter your date of Birth in DD/MM/YYYY fromat  :");
        string mydob = Console.ReadLine();

        string mydobYear = Convert.ToDateTime(mydob).Year.ToString();

        string currentYear = DateTime.Now.Year.ToString();

        Console.WriteLine("enter Number of Marks :");
        int n = Convert.ToInt32(Console.ReadLine());
        decimal sum = 0;
        int i = 1;

        List<int> marks = new List<int>();

        Console.WriteLine($"enter your {n}  Subject Marks : ");

        while (i <= n)
        {
            int marksForSubject = Convert.ToInt32(Console.ReadLine());

            marks.Add(marksForSubject);
            sum += marksForSubject;

            i++;
        }
        i = 1;


        Console.WriteLine("Basic Info of Student ");
        Console.WriteLine("Name :" + name);
        Console.WriteLine("RollNo :" + rollNo);
        Console.WriteLine("Address :" + address);
        Console.WriteLine($"Age : {Convert.ToInt32(currentYear) - Convert.ToInt32(mydobYear)}");


        foreach (int marksForSubject in marks)
        {
            Console.WriteLine($"marksForSubject_{i} ={marksForSubject}");
            i++;
        }

        Console.WriteLine("Average Marks of Student :" + Convert.ToDouble(sum / n));






    }
}
/*INPUT:

enter your Name:
Akhil
enter your adress :
Hyderabad
enter your rollNo :
101
enter your date of Birth in DD/MM/YYYY fromat  :
03 / 08 / 2002
enter Number of Marks :
5
enter your 5  Subject Marks : 
10
10
20
30
40

OUTPUT:

Basic Info of Student 
Name :Akhil
RollNo :101
Address: Hyderabad
Age : 22
marksForSubject_1 = 10
marksForSubject_2 = 10
marksForSubject_3 = 20
marksForSubject_4 = 30
marksForSubject_5 = 40
Average Marks of Student :22
*/