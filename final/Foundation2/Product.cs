public class Product
{
    private String _productName;
    private int _productId;
    private int _quantity;
    private Double _productPrice;

    //-------------------------------------

    public Product(String productName, int productId, int quantity, Double productPrice)
    {
        _productName = productName;
        _productId = productId;
        _quantity = quantity;
        _productPrice = productPrice;
    }

    //-------------------------------------

    public Double TotalCost()
    {
        Double totalPrice = _productPrice * _quantity;
        return totalPrice;
    }

    public Double GetCost()
    {
        return _productPrice;
    }

    public String GetName()
    {
        return _productName;
    }

    public int GetId()
    {
        return _productId;
    }
}