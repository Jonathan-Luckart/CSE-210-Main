using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Boolean begin = true;

        int breathingCount = 0;
        int reflectingCount = 0;
        int listingCount = 0;
        
        List<string> promptList = new List<string>();
        List<string> questionList = new List<string>();
        #region 
        promptList.Add("Think of a time when you stood up for someone else.");
        promptList.Add("Think of a time when you did something really difficult.");
        promptList.Add("Think of a time when you helped someone in need.");
        promptList.Add("Think of a time when you did something truly selfless.");
        questionList.Add("Why was this experience meaningful to you?");
        questionList.Add("Have you ever done anything like this before?");
        questionList.Add("How did you get started?");
        questionList.Add("How did you feel when it was complete?");
        questionList.Add("What made this time different than other times when you were not as successful?");
        questionList.Add("What is your favorite thing about this experience?");
        questionList.Add("What could you learn from this experience that applies to other situations?");
        questionList.Add("What did you learn about yourself through this experience?");
        questionList.Add("How can you keep this experience in mind in the future?");
        #endregion

        List<string> listActPrompts = new List<string>();
        #region 
        listActPrompts.Add("Who are people that you appreciate?");
        listActPrompts.Add("What are personal strengths of yours?");
        listActPrompts.Add("Who are people that you have helped this week?");
        listActPrompts.Add("When have you felt the Holy Ghost this month?");
        listActPrompts.Add("Who are some of your personal heroes?");
        #endregion

        while (begin)
            {
            Console.WriteLine();
            Console.WriteLine($"The Breathing Activity has been performed {breathingCount} times. ");
            Console.WriteLine($"The Reflecting Activity has been performed {reflectingCount} times. ");
            Console.WriteLine($"The Listing Activity has been performed {listingCount} times. ");
            Console.WriteLine();
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("1. Start breathing activity ");
            Console.WriteLine("2. Start reflecting activity ");
            Console.WriteLine("3. Start listing activity ");
            Console.WriteLine("4. Quit ");
            Console.Write("Select a choice from the menu: ");
            String userInput = Console.ReadLine();

            while (true)
            {
                if (userInput == "1")
                {
                    BreathingActivity breathAct = new BreathingActivity("Breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.", 0);
                    breathAct.DisplayStartingMessage();
                    breathAct.Run();
                    breathAct.DisplayEndingMessage();
                    breathingCount += 1;
                    break;
                }
                else if (userInput == "2")
                {
                    ReflectingActivity reflectAct = new ReflectingActivity("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", 0, promptList, questionList);
                    reflectAct.DisplayStartingMessage();
                    reflectAct.Run();
                    reflectAct.DisplayEndingMessage();
                    reflectingCount += 1;
                    break;
                }
                else if (userInput == "3")
                {
                    ListingActivity listAct = new ListingActivity("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", 0, 0, listActPrompts);
                    listAct.DisplayStartingMessage();
                    listAct.Run();
                    listAct.DisplayEndingMessage();
                    listingCount += 1;
                    break;
                }
                else if (userInput == "4")
                {
                    begin = false;
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Invalid input. ");
                    break;
                }
            }
        }
    }
}