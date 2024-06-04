public class Event
{
    protected String _eventType;
    private String _title;
    private String _description;
    private DateTime _eventTime;
    private Address _address;

    //----------------------------

    public Event(String eventType, String title, String description, DateTime eventTime, Address address)
    {
        _eventType = eventType;
        _title = title;
        _description = description;
        _eventTime = eventTime;
        _address = address;
    }

    //-------------------------------------------
    public String FormatDate()
    {
        String formatDate = _eventTime.ToString("dddd, dd MMMM yyyy, hh:mm tt");
        return formatDate;
    }

    public String StandardText()
    {
        return $"Title: {_title}\r\nDesc: {_description}\r\nDate: {FormatDate()}\r\nAddress:\r\n{_address.CreateAddress()}";
    }

    public String ShortText()
    {
        return $"Event: {_eventType}\r\nTitle: {_title}\r\nDate: {FormatDate()}";
    }
}