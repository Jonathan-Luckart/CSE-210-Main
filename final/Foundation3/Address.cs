public class Address
{
    private String _streetAddress;
    private String _city;
    private String _state;

    //---------------------------------

    public Address(String streetAddress, String city, String state)
    {
        _streetAddress = streetAddress;
        _city = city;
        _state = state;
    }

    //--------------------------------------

    public String CreateAddress()
    {
        return $"{_streetAddress}\r\n{_city}, {_state}";
    }
}