using System;

public class ChecklistGoal : Goal
{
    private int _aaoAmountCompleted;
    private int _aaoTargetAmount;
    private int _aaoBonusPoints;

    public ChecklistGoal(
        string name,
        string description,
        int points,
        int targetAmount,
        int bonusPoints)
        : base(name, description, points)
    {
        _aaoAmountCompleted = 0;
        _aaoTargetAmount = targetAmount;
        _aaoBonusPoints = bonusPoints;
    }
    public ChecklistGoal(
        string name,
        string description,
        int points,
        int amountCompleted,
        int targetAmount,
        int bonusPoints)
        : base(name, description, points)
    {
        _aaoAmountCompleted = amountCompleted;
        _aaoTargetAmount = targetAmount;
        _aaoBonusPoints = bonusPoints;
    }

    public override int RecordEvent()
    {
        if (IsComplete())
        {
            return 0;
        }

        _aaoAmountCompleted++;

        if (_aaoAmountCompleted == _aaoTargetAmount)
        {
            return _aaoPoints + _aaoBonusPoints;
        }

        return _aaoPoints;
    }

    public override bool IsComplete()
    {
        return _aaoAmountCompleted >= _aaoTargetAmount;
    }

    public override string GetDetailsString()
    {
        string status = IsComplete() ? "[X]" : "[ ]";

        return $"{status} {_aaoName} ({_aaoDescription}) -- Currently completed {_aaoAmountCompleted}/{_aaoTargetAmount}";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal|{_aaoName}|{_aaoDescription}|{_aaoPoints}|{_aaoAmountCompleted}|{_aaoTargetAmount}|{_aaoBonusPoints}";
    }
}