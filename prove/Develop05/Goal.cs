public abstract class Goal
{
    protected String _shortName;
    protected String _description;
    protected String _markedDone;
    protected int _points;
    

    //----------------------------------

    public Goal(String name, String description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;

        _markedDone = " ";
    }

    //---------------------------------------

    public String GetName()
    {
        return _shortName;
    }

    public int GetPoints()
    {
        return _points;
    }

    //---------------------------------------

    public abstract void RecordEvent();

    public virtual String GetDetailsString()
    {
        String goalListItem = $"[{_markedDone}] {_shortName} ({_description})";
        return goalListItem;
    }

    public abstract String GetStringRepresentation();
}