public abstract class Goal
{
    private String _shortName;
    private String _description;
    private int _points;

    //----------------------------------

    public Goal(String name, String description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    //---------------------------------------

    public abstract void RecordEvent();

    public abstract Boolean IsComplete();

    public virtual String GetDetailsString()
    {
        return "";
    }

    public abstract String GetStringRepresentation();
}