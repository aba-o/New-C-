public class MathAssignment : Assignment
{
    private string _aaoTextbookSection;
    private string _aaoProblems;
    public MathAssignment(string studentName, string topic, string textbookSection, string problems)
        : base(studentName, topic)
    {
        // Here we set the MathAssignment specific variables
        _aaoTextbookSection = textbookSection;
        _aaoProblems = problems;
    }

    public string GetHomeworkList()
    {
        return $"Section {_aaoTextbookSection} Problems {_aaoProblems}";
    }
}