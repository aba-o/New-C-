public class OutdoorGathering : Event
{
    private string _aaoWeatherForecast;

    public OutdoorGathering(
        string title,
        string description,
        string date,
        string time,
        Address address,
        string weatherForecast)
        : base(
            title,
            description,
            date,
            time,
            address)
    {
        _aaoWeatherForecast = weatherForecast;
    }

    public override string GetEventType()
    {
        return "Outdoor Gathering";
    }

    public override string GetFullDetails()
    {
        return
            $"Event Type: {GetEventType()}\n" +
            $"{GetStandardDetails()}\n" +
            $"Weather Forecast: {_aaoWeatherForecast}";
    }

    public override string GetShortDescription()
    {
        return
            $"Event Type: {GetEventType()}\n" +
            $"Title: {GetTitle()}\n" +
            $"Date: {GetDate()}";
    }
}