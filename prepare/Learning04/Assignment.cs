public class Assignment
{
    protected String _studentName = "";
    private String _topic = "";

    //---------------------------------

    public Assignment(String studentName, String topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    //-------------------------------------------

    public string GetSummary()
    {
        String summary = $"{_studentName} - {_topic}";

        return summary;
    }
}