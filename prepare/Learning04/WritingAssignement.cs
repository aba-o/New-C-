public class WritingAssignment : Assignment
{
    private string _aaoTitle;
    public WritingAssignment(string studentName, string topic, string title)
        : base(studentName, topic)
    {
        _aaoTitle = title;
    }

    public string GetWritingInformation()
    {
        string studentName = GetStudentName();

        return $"{_aaoTitle} by {studentName}";
    }
}