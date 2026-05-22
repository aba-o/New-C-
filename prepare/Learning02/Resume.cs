using System;

public class Resume
{
    public string _aaoName;
    public List<Job> _aaoJobList =new List<Job>() ;

    public void Display()
    {
        Console.WriteLine($"Name: {_aaoName}");
        Console.WriteLine($"Jobs: ");
        
        foreach (Job job in _aaoJobList)
        {
            job.DisplayJobDetails();
        }
    }

    // another way the display function could be done is to declare a tostring function
    // eg public void toString()
    //{
    //string value = _aaoJobTitle + "("+company+)
    //}
}