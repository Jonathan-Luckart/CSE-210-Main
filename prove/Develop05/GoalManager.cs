using System.IO;
public class GoalManager
{
    private List<Goal> _goals;
    private int _score;
    private String _medal;

    //---------------------------------------

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
        _medal = "";
    }

    //--------------------------------

    public void Start()
    {
        DisplayPlayerInfo();
        Console.WriteLine();
        Console.WriteLine("Menu Options: ");
        Console.WriteLine("1. Create New Goal ");
        Console.WriteLine("2. List Goals ");
        Console.WriteLine("3. Save Goals ");
        Console.WriteLine("4. Load Goals ");
        Console.WriteLine("5. Record Event ");
        Console.WriteLine("6. Quit ");
        Console.Write("Select a choice from the menu: ");
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points. ");

        if (_score >= 1000)
        {
            _medal = "Bronze";

            if (_score >= 5000)
            {
                _medal = "Silver";

                if (_score >= 10000)
                {
                    _medal = "Gold";
                }
            }
        }
        else
        {
            _medal = "Beginner's";
        }

        Console.WriteLine($"You have the {_medal} medal. ");
    }

    public void ListGoalDetails()
    {
        Console.Clear();
        int listed = 0;
        foreach (Goal goalType in _goals)
        {
            listed += 1;
            Console.WriteLine($"{listed}. {goalType.GetDetailsString()}");
        }
        Console.WriteLine();
    }

    public void CreateGoal()
    {
        Console.WriteLine();
        Console.WriteLine("The types of Goals are: ");
        Console.WriteLine("1. Simple Goal ");
        Console.WriteLine("2. Eternal Goal ");
        Console.WriteLine("3. Checklist Goal ");
        Console.Write("Which type of goal would you like to create? ");
        String userChoice = Console.ReadLine();
        Console.Write("What is the name of your goal? ");
        String goalNameInput = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        String goalDescInput = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        int goalPoints = int.Parse(Console.ReadLine());
        
        if (userChoice == "1")
        {
            SimpleGoal simpleGoal = new SimpleGoal(goalNameInput, goalDescInput, goalPoints);
            _goals.Add(simpleGoal);
            Console.Clear();
        }
        else if (userChoice == "2")
        {
            EternalGoal eternalGoal = new EternalGoal(goalNameInput, goalDescInput, goalPoints);
            _goals.Add(eternalGoal);
            Console.Clear();
        }
        else if (userChoice == "3")
        {
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int userTarget = int.Parse(Console.ReadLine());
            Console.Write("What is the bonus for accomplishing it that many times? ");
            int userBonus = int.Parse(Console.ReadLine());

            ChecklistGoal checklistGoal = new ChecklistGoal(goalNameInput, goalDescInput, goalPoints, userTarget, userBonus);
            _goals.Add(checklistGoal);
            Console.Clear();
        }
    }

    public void RecordEvent()
    {
        Console.WriteLine();
        Console.WriteLine("The goals are: ");

        int listed = 0;
        foreach (Goal goalType in _goals)
        {
            listed += 1;
            Console.WriteLine($"{listed}. {goalType.GetName()}");
        }

        Console.Write("Which goal did you accomplish? ");
        int userIndex = int.Parse(Console.ReadLine());

        userIndex -= 1;

        _goals[userIndex].RecordEvent();
        int toAdd = _goals[userIndex].GetPoints();
        _score += toAdd;

        Console.WriteLine($"You now have {_score} points. ");
        Console.WriteLine();
    }

    public void SaveGoals()
    {
        Console.WriteLine();
        Console.Write("What is the filename for your goal file? ");
        String userFile = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(userFile))
        {
            outputFile.WriteLine(_score);
            foreach (Goal goalType in _goals)
            {
                outputFile.WriteLine(goalType.GetStringRepresentation());
            }
        }
        Console.Clear();
    }

    public void LoadGoals()
    {
        Console.WriteLine();
        Console.Write("What is the filename for the goal file? ");
        String userFile = Console.ReadLine();

        String[] lines = System.IO.File.ReadAllLines(userFile);

        _score = int.Parse(lines[0]);

        List<string> betterLines = new List<string>();
        
        foreach (String arrayLine in lines)
        {
            betterLines.Add(arrayLine);
        }

        betterLines.RemoveAt(0);

        foreach (String line in betterLines)
        {
            String[] fullParts = line.Split(":");
            String goalType = fullParts[0];
            String goalDetails = fullParts[1];

            if (goalType == "SG")
            {
                String[] details = goalDetails.Split("#");
                String name = details[0];
                String desc = details[1];
                int points = int.Parse(details[2]);
                String markedDone = details[3];

                SimpleGoal simpleGoalLoad = new SimpleGoal(name, desc, points, markedDone);
                _goals.Add(simpleGoalLoad);
            }
            else if (goalType == "EG")
            {
                String[] details = goalDetails.Split("#");
                String name = details[0];
                String desc = details[1];
                int points = int.Parse(details[2]);

                EternalGoal eternalGoalLoad = new EternalGoal(name, desc, points);
                _goals.Add(eternalGoalLoad);
            }
            else if (goalType == "CG")
            {
                String[] details = goalDetails.Split("#");
                String name = details[0];
                String desc = details[1];
                int points = int.Parse(details[2]);
                int amountCompleted = int.Parse(details[3]);
                int target = int.Parse(details[4]);
                int bonus = int.Parse(details[5]);

                ChecklistGoal checklistGoalLoad = new ChecklistGoal(name, desc, points, amountCompleted, target, bonus);
                _goals.Add(checklistGoalLoad);
            }
        }
        Console.Clear();
    }
}