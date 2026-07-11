using System;

public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
        : base(name, description, points)
    {
    }

    public override int RecordEvent()
    {
        return _aaoPoints;
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetDetailsString()
    {
        return $"[ ] {_aaoName} ({_aaoDescription})";
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal|{_aaoName}|{_aaoDescription}|{_aaoPoints}";
    }
}