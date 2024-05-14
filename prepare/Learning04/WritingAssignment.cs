public class WritingAssignment : Assignment
{
    private String _title = "";

    //--------------------------

    public WritingAssignment(String studentName, String topic, String title) : base(studentName, topic)
    {
            _title = title;
    }

    //-----------------------------------------------------

    public string GetWritingInformation()
    {
        String writeInfo = $"{_title} by {_studentName}";

        return writeInfo;
    }
}