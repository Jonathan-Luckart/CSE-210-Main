using System;

class Program
{
    static void Main(string[] args)
    {
        //Apply functions
        DisplayWelcome();
        String username = PromptUserName();
        int forSquare = PromptUserNumber();
        int squared = SquareNumber(forSquare);
        DisplayResult(username, squared);

        //-----------------------------------------------------------

        //function for display
        static void DisplayWelcome()
        {
            Console.WriteLine();
            Console.WriteLine("Welcome to the program! ");
        }

        //function for getting user string
        static String PromptUserName()
        {
            Console.WriteLine();
            Console.Write("Please enter your name: ");
            String username = Console.ReadLine();

            return username;
        }

        //fuction for getting number
        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            String userInput = Console.ReadLine();
            int userint = int.Parse(userInput);

            return userint;
        }

        //function for squaring user number
        static int SquareNumber(int forSquare)
        {
            int squared = forSquare * forSquare;
            return squared;
        }

        //function for displaying final message
        static void DisplayResult(String username, int squared)
        {
            Console.WriteLine();
            Console.WriteLine($"{username}, the square of your number is {squared}");
            Console.WriteLine();
        }
    }
}