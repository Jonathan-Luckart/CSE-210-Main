public class OutdoorGathering : Event
{
    private String _weatherStatement;

    //---------------------------------

    public OutdoorGathering(String eventType, String title, String description, DateTime eventTime, Address address, String weatherStatement) : base(eventType, title, description, eventTime, address)
    {
        _weatherStatement = weatherStatement;
    }

    //----------------------------------------------

    public String FullText()
    {
        String text = $"Event: {_eventType}\r\n{StandardText()}\r\nWeather: {_weatherStatement}";
        return text;
    }
}