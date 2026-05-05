using System;

public class Job
{
    public string _aaoCompanyTitle;
    public string _aaoJobTitle;
    public int _aaoStartYear;
    public int _aaoEndYear;

    public void DisplayJobDetails()
    {
        Console.WriteLine($"{_aaoJobTitle} ({_aaoCompanyTitle}) {_aaoStartYear}-{_aaoEndYear}");
    }


}