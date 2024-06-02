public class Order
{
    private List<Product> _productList;
    private Customer _customer;

    //-----------------------------

    public Order(List<Product> productList, Customer customer)
    {
        _productList = productList;
        _customer = customer;
    }

    //------------------------------------

    public Double TotalOrderCost()
    {
        Double totalCost = 0;

        foreach (Product product in _productList)
        {
            totalCost += product.GetCost();
        }

        if (_customer.InStates() == true)
        {
            totalCost += 5;
        }
        else
        {
            totalCost += 35;
        }

        return totalCost;
    }

    public String PackingLabel()
    {
        String packLabel = "";

        foreach (Product product in _productList)
        {
            packLabel += $"{product.GetName()} {product.GetId()}\r\n";
        }

        return packLabel;
    }

    public String ShippingLabel()
    {
        String shipLabel;

        shipLabel = $"{_customer.GetCustomer()} \r\n{_customer.GetAddress()}";

        return shipLabel;
    }
}