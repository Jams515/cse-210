using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {   
        int guess = -1;

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);

        //Console.WriteLine("What is the magic number? ");
        //int magicNumber = int.Parse(Console.ReadLine());
        //string number = Console.ReadLine();
        //int magicNumber = int.Parse(number);

        while (guess != magicNumber)
        {
            Console.WriteLine("What is your guess?");
            guess = int.Parse(Console.ReadLine());
            //string guess = Console.ReadLine();
            //answer = int.Parse(guess);

            if (guess < magicNumber)
            {
                Console.Write("Higher. ");
            }

            else if (guess > magicNumber)
            {
                Console.Write("Lower. ");
            }

            else
            {
                Console.Write("You guessed the magic number!!!");
            }
        }












    }
}