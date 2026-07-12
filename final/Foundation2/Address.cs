public class Address
{
    private string _aaoStreetAddress;
    private string _aaoCity;
    private string _aaoStateProvince;
    private string _aaoCountry;

    public Address(string streetAddress, string city, string stateProvince, string country)
    {
        _aaoStreetAddress = streetAddress;
        _aaoCity = city;
        _aaoStateProvince = stateProvince;
        _aaoCountry = country;
    }

    public string GetStreetAddress()
    {
        return _aaoStreetAddress;
    }

    public void SetStreetAddress(string streetAddress)
    {
        _aaoStreetAddress = streetAddress;
    }

    public string GetCity()
    {
        return _aaoCity;
    }

    public void SetCity(string city)
    {
        _aaoCity = city;
    }

    public string GetStateProvince()
    {
        return _aaoStateProvince;
    }

    public void SetStateProvince(string stateProvince)
    {
        _aaoStateProvince = stateProvince;
    }

    public string GetCountry()
    {
        return _aaoCountry;
    }

    public void SetCountry(string country)
    {
        _aaoCountry = country;
    }

    public bool IsInUSA()
    {
        return _aaoCountry.ToLower() == "usa" ||
                _aaoCountry.ToLower() == "united states";
    }

    public string GetFullAddress()
    {
        return $"{_aaoStreetAddress}\n{_aaoCity}, {_aaoStateProvince}\n{_aaoCountry}";
    }
}