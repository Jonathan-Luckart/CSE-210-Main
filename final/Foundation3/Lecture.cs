public class Lecture : Event
{
    private String _speakerName;
    private int _capacity;

    //-----------------------------

    public Lecture(String eventType, String title, String description, DateTime eventTime, Address address, String speakerName, int capacity) : base(eventType, title, description, eventTime, address)
    {
        _speakerName = speakerName;
        _capacity = capacity;
    }

    //-----------------------------------------

    public String FullText()
    {
        String text = $"Event: {_eventType}\r\n{StandardText()}\r\nSpeaker: {_speakerName}, Capacity: {_capacity}";
        return text;
    }
}