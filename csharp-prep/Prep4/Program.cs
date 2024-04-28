using System;
using System.Data.Common;
using System.Drawing;
using System.Linq.Expressions;

class Program
{
    static void Main(string[] args)
    {
        List<float> numbers = new List<float>();

        Console.WriteLine();
        Console.WriteLine("Enter a list of numbers, type 0 when finished. ");
        Console.WriteLine();

        float loop = 0;

        while(loop == 0) 
        {
            Console.Write("Enter number: ");
            String inputAns = Console.ReadLine();
            float ans = float.Parse(inputAns);

            if (ans != 0) 
            {
                numbers.Add(ans);
            }
            else
            {
                break;
            }
        }

        //start computing
        float total = 0;
        float avgTotal = 0;
        float largest = 0;

        foreach (float value in numbers)
        {
            total += value;
            avgTotal += value;

            if (value > largest)
            {
                largest = value;
            }
        }

        avgTotal /= numbers.Count;

        Console.WriteLine();
        Console.WriteLine($"The sum is: {total}");
        Console.WriteLine($"The average is: {avgTotal}");
        Console.WriteLine($"The largest number is: {largest}");
        Console.WriteLine();
    }
}