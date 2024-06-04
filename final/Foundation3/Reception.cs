public class Reception : Event
{
    private String _email;

    //--------------------------

    public Reception(String eventType, String title, String description, DateTime eventTime, Address address, String email) : base(eventType, title, description, eventTime, address)
    {
        _email = email;
    }

    //------------------------------------------

    public String FullText()
    {
        String text = $"Event: {_eventType}\r\n{StandardText()}\r\nRSVP at: {_email}";
        return text;
    }
}