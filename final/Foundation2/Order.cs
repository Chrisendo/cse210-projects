public class Order
{
    private Customer _customer;
    private Product[] _product;


    public Order(Customer customer, Product[] product)
    {
        _customer = customer;
        _product = product;
    }


    public double GetTotalPrice()
    {
        double productTotal = 0;
        for (int i = 0; i < _product.Length; i++)
        {
            productTotal = productTotal + _product[i].GetCost();
        }

        double shippingCost;
        if (_customer.IsUSA())
        {
            shippingCost = 5;
        }

        else
        {
            shippingCost = 35;
        }

        return productTotal + shippingCost;
    }


    public string GetPackingLabel()
    {
        string label = "Packing Label: \n";
        for (int i = 0; i < _product.Length; i++)
        {
            label = label + _product[i]._productName + " (ID: " +_product[i]._productID + ")\n";
        }
        return label;
    }


    public string GetShippingLabel()
    {
        return "Shipping Label:\n" + _customer._name + "\n" + _customer._address.GetAddress();
    }
}