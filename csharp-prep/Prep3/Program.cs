using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        Random randomNum = new Random();
        int number = randomNum.Next(1, 101);

        int initialize = -1;

        Console.WriteLine();
        Console.WriteLine("You will try to guess a random computer generated number between 1 and 100. Good Luck! ");

        while (initialize != number) 
        {
            Console.WriteLine();
            Console.Write("What is your guess? ");
            String input = Console.ReadLine();
            int guess = int.Parse(input);

            if (guess > number) 
            {
                Console.WriteLine("Lower");
            }
            else if (guess < number)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("You guessed it! ");
                Console.WriteLine();
                break;
            }
        }
    }
}