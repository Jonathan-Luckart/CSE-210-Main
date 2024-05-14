using System;

class Program
{
    static void Main(string[] args)
    {
        /*Assignment super = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(super.GetSummary());*/

        MathAssignment derived = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        WritingAssignment writeDerived = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");

        Console.WriteLine();
        Console.WriteLine(derived.GetSummary());
        Console.WriteLine(derived.GetHomeworkList());
        Console.WriteLine();
        Console.WriteLine(writeDerived.GetSummary());
        Console.WriteLine(writeDerived.GetWritingInformation());
        Console.WriteLine();
        
    }
}