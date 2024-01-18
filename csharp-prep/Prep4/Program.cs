using System;
using System.Numerics;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int uInput = -1;
        while (uInput != 0)
        {
            Console.Write("Please enter a number (0 to quit program): ");
            uInput = int.Parse(Console.ReadLine());

            if (uInput != 0)
            {
                numbers.Add(uInput);
            }
        }
        int total = 0;
        int entries = 0;
        int big = 0;

        foreach (int number in numbers)
        {
            total += number;
            entries += 1;
            if (number > big)
            {
                big = number;
            }
        }
        int average = total / entries;

        Console.WriteLine($"The sum is: {total}");
        Console.WriteLine($"The biggest number is: {big}");
        Console.WriteLine($"the average is: {average}");

    }
}