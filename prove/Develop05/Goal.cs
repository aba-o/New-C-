using System;

public abstract class Goal
{
    protected string _aaoName;
    protected string _aaoDescription;
    protected int _aaoPoints;

    //Creates a new goal and initializes the shared information.
    public Goal(string name, string description, int points)
    {
        _aaoName = name;
        _aaoDescription = description;
        _aaoPoints = points;
    }

    //Getters
    public string GetName()
    {
        return _aaoName;
    }

    public int GetPoints()
    {
        return _aaoPoints;
    }

    //Defines the action that happens when the user completes a goal.
    public abstract int RecordEvent();

    //Checks whether the goal has been completed.
    public abstract bool IsComplete();

    //Creates the display version of a goal.
    public abstract string GetDetailsString();

    //Creates the format used when saving the goal to a file.
    public abstract string GetStringRepresentation();
}