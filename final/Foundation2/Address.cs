public class Address
{
    private String _streetAddress;
    private String _city;
    private String _stateOrProv;
    private String _country;

    //---------------------------------

    public Address(String streetAddress, String city, String stateOrProv, String country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _stateOrProv = stateOrProv;
        _country = country;
    }

    //------------------------------------------------

    public Boolean InUsa()
    {
        Boolean isIn;

        if (_country == "United States")
        {
            isIn = true;
        }
        else
        {
            isIn = false;
        }

        return isIn;
    }

    public String AddressText()
    {
        String fullAddress = $"{_streetAddress} \r\n{_city}, {_stateOrProv} \r\n{_country}";
        return fullAddress;
    }
}