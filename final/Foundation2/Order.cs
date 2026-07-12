using System.Collections.Generic;

public class Order
{
    private List<Product> _aaoProducts;
    private Customer _aaoCustomer;

    public Order(Customer customer)
    {
        _aaoProducts = new List<Product>();
        _aaoCustomer = customer;
    }

    public void AddProduct(Product product)
    {
        _aaoProducts.Add(product);
    }

    public double CalculateTotalCost()
    {
        double _aaoTotal = 0;

        foreach (Product product in _aaoProducts)
        {
            _aaoTotal += product.GetTotalCost();
        }

        if (_aaoCustomer.LivesInUSA())
        {
            _aaoTotal += 5;
        }
        else
        {
            _aaoTotal += 35;
        }

        return _aaoTotal;
    }

    public string GetPackingLabel()
    {
        string _aaoPackingLabel = "Packing Label:\n";

        foreach (Product product in _aaoProducts)
        {
            _aaoPackingLabel += 
                $"{product.GetName()} - {product.GetProductId()}\n";
        }

        return _aaoPackingLabel;
    }

    public string GetShippingLabel()
    {
        string _aaoShippingLabel = "Shipping Label:\n";

        _aaoShippingLabel += 
            $"Customer: {_aaoCustomer.GetName()}\n";

        _aaoShippingLabel += 
            _aaoCustomer.GetAddress().GetFullAddress();

        return _aaoShippingLabel;
    }
}