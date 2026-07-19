public class Address
{
    private string _aaoStreet;
    private string _aaoCity;
    private string _aaoState;
    private string _aaoCountry;

    public Address(
        string street,
        string city,
        string state,
        string country)
    {
        _aaoStreet = street;
        _aaoCity = city;
        _aaoState = state;
        _aaoCountry = country;
    }

    public string GetFullAddress()
    {
        return
            $"{_aaoStreet}, " +
            $"{_aaoCity}, " +
            $"{_aaoState}, " +
            $"{_aaoCountry}";
    }
}