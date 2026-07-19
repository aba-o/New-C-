public class Reception : Event
{
    private string _aaoRsvpEmail;

    public Reception(
        string title,
        string description,
        string date,
        string time,
        Address address,
        string rsvpEmail)
        : base(
            title,
            description,
            date,
            time,
            address)
    {
        _aaoRsvpEmail = rsvpEmail;
    }

    public override string GetEventType()
    {
        return "Reception";
    }

    public override string GetFullDetails()
    {
        return
            $"Event Type: {GetEventType()}\n" +
            $"{GetStandardDetails()}\n" +
            $"RSVP Email: {_aaoRsvpEmail}";
    }

    public override string GetShortDescription()
    {
        return
            $"Event Type: {GetEventType()}\n" +
            $"Title: {GetTitle()}\n" +
            $"Date: {GetDate()}";
    }
}