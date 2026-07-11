using System;

public class SimpleGoal : Goal
{
    private bool _aaoIsComplete;

    //It restores the previous completion status.
    public SimpleGoal(string name, string description, int points)
        : base(name, description, points)
    {
        _aaoIsComplete = false;
    }
    public SimpleGoal(
        string name,
        string description,
        int points,
        bool isComplete)
        : base(name, description, points)
        {
            _aaoIsComplete = isComplete;
        }

    //Marks the goal complete and gives points.
    public override int RecordEvent()
    {
        if (!_aaoIsComplete)
        {
            _aaoIsComplete = true;
            return _aaoPoints;
        }

        return 0;
    }

    public override bool IsComplete()
    {
        return _aaoIsComplete;
    }

    public override string GetDetailsString()
    {
        string status = _aaoIsComplete ? "[X]" : "[ ]";

        return $"{status} {_aaoName} ({_aaoDescription})";
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal|{_aaoName}|{_aaoDescription}|{_aaoPoints}|{_aaoIsComplete}";
    }
}