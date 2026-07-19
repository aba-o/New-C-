public class Event
{
    private string _aaoTitle;
    private string _aaoDescription;
    private string _aaoDate;
    private string _aaoTime;
    private Address _aaoAddress;

    public Event(
        string title,
        string description,
        string date,
        string time,
        Address address)
    {
        _aaoTitle = title;
        _aaoDescription = description;
        _aaoDate = date;
        _aaoTime = time;
        _aaoAddress = address;
    }

    public string GetTitle()
    {
        return _aaoTitle;
    }

    public string GetDate()
    {
        return _aaoDate;
    }

    public virtual string GetEventType()
    {
        return "Event";
    }

    public virtual string GetStandardDetails()
    {
        return
            $"Title: {_aaoTitle}\n" +
            $"Description: {_aaoDescription}\n" +
            $"Date: {_aaoDate}\n" +
            $"Time: {_aaoTime}\n" +
            $"Address: {_aaoAddress.GetFullAddress()}";
    }

    public virtual string GetFullDetails()
    {
        return GetStandardDetails();
    }

    public virtual string GetShortDescription()
    {
        return
            $"Event Type: {GetEventType()}\n" +
            $"Title: {_aaoTitle}\n" +
            $"Date: {_aaoDate}";
    }
}