public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    //----------------------------------

    public ChecklistGoal(String name, String description, int points, int target, int bonus) : base(name, description, points)
    {
    }

    //----------------------------------------------------------

    public override void RecordEvent()
    {
        //init
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        return "";
    }

    public override string GetDetailsString()
    {
        return "";
    }
}