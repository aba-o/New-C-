using System.Collections.Generic;
using System.IO;

public class FileManager
{
    private string _aaoFileName;

    public FileManager(string fileName)
    {
        _aaoFileName = fileName;
    }

    public void SaveEvents(List<Event> events)
    {
        using (StreamWriter _aaoOutputFile =
                new StreamWriter(_aaoFileName))
        {
            foreach (Event _aaoEvent in events)
            {
                _aaoOutputFile.WriteLine(
                    _aaoEvent.GetFullDetails());

                _aaoOutputFile.WriteLine(
                    "--------------------------------");
            }
        }
    }

    public List<string> LoadEvents()
    {
        List<string> _aaoEventData =
            new List<string>();

        if (File.Exists(_aaoFileName))
        {
            string[] _aaoLines =
                File.ReadAllLines(_aaoFileName);

            foreach (string _aaoLine in _aaoLines)
            {
                _aaoEventData.Add(_aaoLine);
            }
        }

        return _aaoEventData;
    }
}