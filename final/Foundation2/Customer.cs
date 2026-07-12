public class Customer
{
    private string _aaoName;
    private Address _aaoAddress;

    public Customer(string name, Address address)
    {
        _aaoName = name;
        _aaoAddress = address;
    }

    public string GetName()
    {
        return _aaoName;
    }

    public void SetName(string name)
    {
        _aaoName = name;
    }

    public Address GetAddress()
    {
        return _aaoAddress;
    }

    public void SetAddress(Address address)
    {
        _aaoAddress = address;
    }

    public bool LivesInUSA()
    {
        return _aaoAddress.IsInUSA();
    }
}