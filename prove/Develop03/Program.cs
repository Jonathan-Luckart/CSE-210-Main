using System;

class Program
{
    static void Main(string[] args)
    {
        //Begin creative reqs -----------------------------------------------------
        #region 
        List<string> passages = new List<string>();
        String line;

        StreamReader sr = new StreamReader("scripturefile.txt");
        line = sr.ReadLine();
        while (line != null)
        {
            passages.Add(line);
            line = sr.ReadLine();
        }

        Random randPass = new Random();
        int selected = randPass.Next(0, passages.Count);
        String[] cutPass = passages[selected].Split("&");

        String book = cutPass[0];
        int chapter = int.Parse(cutPass[1]);
        int startVerse = int.Parse(cutPass[2]);
        int endVerse = int.Parse(cutPass[3]);
        String scriptVar = cutPass[4];
        #endregion
        //end creative reqs -------------------------------------------------------


        Reference reference = new Reference(book, chapter, startVerse, endVerse);
        Scripture scripture = new Scripture(reference, scriptVar);

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());

        while (true)
        {
            Console.WriteLine();
            Console.Write("Press enter to continue or type quit to exit: ");
            String userInput = Console.ReadLine();

            if (userInput.ToLower() == "quit")
            {
                break;
            }
            else if (userInput == "")
            {
                Console.Clear();
                scripture.HideRandomWords(3);
                Console.WriteLine(scripture.GetDisplayText());

                if (scripture.IsCompletelyHidden() == true)
                {
                    break;
                }
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Please enter a valid arguement. ");
            }
        }
    }
}