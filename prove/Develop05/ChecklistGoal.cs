public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    //----------------------------------

    public ChecklistGoal(String name, String description, int points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;

        _amountCompleted = 0;
    }

//for loading
    public ChecklistGoal(String name, String description, int points, int amountCompleted, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;

        _amountCompleted = amountCompleted;

        if (_amountCompleted == _target)
        {
            _markedDone = "X";
        }
    }

    //----------------------------------------------------------

    public override void RecordEvent()
    {
        _amountCompleted += 1;

        if (_amountCompleted == _target)
        {
            _markedDone = "X";
            _points += _bonus;
        }

        Console.WriteLine($"Congratulations! You have earned {_points} points! ");
    }

    public override string GetStringRepresentation()
    {
        String cgFull = $"CG:{_shortName}#{_description}#{_points}#{_amountCompleted}#{_target}#{_bonus}";
        return cgFull;
    }

    public override string GetDetailsString()
    {
        String listedItem = $"[{_markedDone}] {_shortName} ({_description}) -- Currently completed: {_amountCompleted}/{_target}";
        return listedItem;
    }
}