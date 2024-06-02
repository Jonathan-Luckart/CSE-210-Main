public class Customer
{
    private String _customerName;
    private Address _address;

    //----------------------------

    public Customer(String customerName, Address address)
    {
        _customerName = customerName;
        _address = address;
    }

    public Boolean InStates()
    {
        Boolean isIn;

        if (_address.InUsa() == true)
        {
            isIn = true;
        }
        else
        {
            isIn = false;
        }

        return isIn;
    }

    public String GetCustomer()
    {
        return _customerName;
    }

    public String GetAddress()
    {
        return _address.AddressText();
    }
}