using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {   
        DisplayMessage();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int square = SquareNumber(number);
        DisplayResult(name, square);
    }

    static void DisplayMessage()
    {
        Console.WriteLine("Welcome");
    }

    static string PromptUserName()
    {
        string name = "";
        Console.WriteLine("What is your name? ");
        name = Console.ReadLine();

        return name;
    }

    static int PromptUserNumber()
    {
        Console.WriteLine("What is your number? ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }

    static int SquareNumber(int number)
    {
        int square = number * number;

        return square;
    }

    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is: {square}");
    }
}