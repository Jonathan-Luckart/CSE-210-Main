using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();
        Console.WriteLine("Welcome to the Journal Program! ");

        int loop = 0;

        Journal journal = new Journal();

        while(loop == 0)
            {
            Console.WriteLine();
            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine("1. Write ");
            Console.WriteLine("2. Display ");
            Console.WriteLine("3. Load ");
            Console.WriteLine("4. Save ");
            Console.WriteLine("5. Quit ");
            Console.Write("What would you like to do? ");

            PromptGenerator randPrompt = new PromptGenerator();
            randPrompt._prompts.Add("What was your favorite thing about today?");
            randPrompt._prompts.Add("Have you felt the Spirit or had a spiritual experience today?");
            randPrompt._prompts.Add("Did you do something nice for someone today?");
            randPrompt._prompts.Add("Have you learned anything new that future you might use?");
            randPrompt._prompts.Add("What did you feel today and how did it effect your decisions?");

            String userInput = Console.ReadLine();

            if (userInput == "1")
            {
                String thePrompt = randPrompt.GetRandomPrompt();
                Console.WriteLine(thePrompt);

                Entry entry = new Entry();
                DateTime theCurrentTime = DateTime.Now;
                string dateText = theCurrentTime.ToShortDateString();

                String userWrite = Console.ReadLine();

                entry._date = dateText;
                entry._promptText = thePrompt;
                entry._entryText = userWrite;
                journal.AddEntry(entry);
            }
            else if (userInput == "2")
            {
                Console.WriteLine();
                journal.DisplayAll();
            }
            else if (userInput == "3")
            {
                Console.WriteLine("What is the filename? ");
                String fileNameLoad = Console.ReadLine();

                journal.LoadFromFile(fileNameLoad);
            }
            else if (userInput == "4")
            {
                Console.WriteLine("What is the filename? ");
                String fileName = Console.ReadLine();
                
                journal.SaveToFile(fileName);
            }
            else if (userInput == "5")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid command.");
            }
        }
    }
}