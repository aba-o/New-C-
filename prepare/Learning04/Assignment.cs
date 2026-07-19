using System;
public class Assignment
{
    private string _aaoStudentName;
    private string _aaoTopic;

    public Assignment(string studentName, string topic)
    {
        _aaoStudentName = studentName;
        _aaoTopic = topic;
    }
    public string GetStudentName()
    {
        return _aaoStudentName;
    }

    public string GetTopic()
    {
        return _aaoTopic;
    }

    public string GetSummary()
    {
        return _aaoStudentName + " - " + _aaoTopic;
    }
}