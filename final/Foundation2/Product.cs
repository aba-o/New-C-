public class Product
{
    private string _aaoName;
    private string _aaoProductId;
    private double _aaoPricePerUnit;
    private int _aaoQuantity;

    public Product(string name, string productId, double pricePerUnit, int quantity)
    {
        _aaoName = name;
        _aaoProductId = productId;
        _aaoPricePerUnit = pricePerUnit;
        _aaoQuantity = quantity;
    }

    public string GetName()
    {
        return _aaoName;
    }

    public void SetName(string name)
    {
        _aaoName = name;
    }

    public string GetProductId()
    {
        return _aaoProductId;
    }

    public void SetProductId(string productId)
    {
        _aaoProductId = productId;
    }

    public double GetPricePerUnit()
    {
        return _aaoPricePerUnit;
    }

    public void SetPricePerUnit(double pricePerUnit)
    {
        _aaoPricePerUnit = pricePerUnit;
    }

    public int GetQuantity()
    {
        return _aaoQuantity;
    }

    public void SetQuantity(int quantity)
    {
        _aaoQuantity = quantity;
    }

    public double GetTotalCost()
    {
        return _aaoPricePerUnit * _aaoQuantity;
    }
}