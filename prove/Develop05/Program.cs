using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        GoalManager goalManager = new GoalManager();

        while (true)
        {
            goalManager.Start();
            String userInput = Console.ReadLine();

            if (userInput == "1")
            {
                goalManager.CreateGoal();
            }
            else if (userInput == "2")
            {
                goalManager.ListGoalDetails();
            }
            else if (userInput == "3")
            {
                goalManager.SaveGoals();
            }
            else if (userInput == "4")
            {
                goalManager.LoadGoals();
            }
            else if (userInput == "5")
            {
                goalManager.RecordEvent();
            }
            else if (userInput == "6")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid option. ");
                Console.WriteLine();
            }
        }
    }
}