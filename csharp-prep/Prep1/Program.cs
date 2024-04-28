using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();
        Console.WriteLine("What is your first name? ");
        String fname = Console.ReadLine();

        Console.WriteLine();
        Console.WriteLine("What is your last name? ");
        String lname = Console.ReadLine();
        
        Console.WriteLine();
        Console.WriteLine($"Your name is {lname}, {fname} {lname}.");
        Console.WriteLine();
    }
}