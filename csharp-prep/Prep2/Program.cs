using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What percent do you have in this class? ");
        string answer = Console.ReadLine();
        int percent = int.Parse(answer);
        string grade = "";

        if (percent >= 90)
        {
            grade = "A";
        }
        else if (percent >= 80)
        {
            grade = "B";
        }
        else if (percent >= 70)
        {
            grade = "C";
        }
        else if (percent >= 60)
        {
            grade = "D";
        }
        else
        {
            grade = "F";
        }

        Console.WriteLine($"Your grade is a(n) {grade}!");

        if (percent >= 70)
        {
            Console.Write("You passed!!");
        }
        else
        {
            Console.Write("You did not pass :( ");
        }


    }
}