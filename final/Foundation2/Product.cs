public class Product
{
    public string _productName;
    public int _productID;
    private double _pricePerUnit;
    private int _quantity;


    public Product(string productName, int productID, double pricePerUnit, int quantity)
    {
        _productName = productName;
        _productID = productID;
        _pricePerUnit = pricePerUnit;
        _quantity = quantity;
    }


    public double GetCost()
    {
        return _pricePerUnit * _quantity;
    }
}