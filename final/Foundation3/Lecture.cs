public class Lecture : Event
{
    private string _aaoSpeakerName;
    private int _aaoCapacity;

    public Lecture(
        string title,
        string description,
        string date,
        string time,
        Address address,
        string speakerName,
        int capacity)
        : base(
            title,
            description,
            date,
            time,
            address)
    {
        _aaoSpeakerName = speakerName;
        _aaoCapacity = capacity;
    }

    public override string GetEventType()
    {
        return "Lecture";
    }

    public override string GetFullDetails()
    {
        return
            $"Event Type: {GetEventType()}\n" +
            $"{GetStandardDetails()}\n" +
            $"Speaker Name: {_aaoSpeakerName}\n" +
            $"Capacity: {_aaoCapacity}";
    }

    public override string GetShortDescription()
    {
        return
            $"Event Type: {GetEventType()}\n" +
            $"Title: {GetTitle()}\n" +
            $"Date: {GetDate()}";
    }
}