using System;

public class Job
{
    public string _jobTitle;
    public string _company;
    public int startYear;
    public int endYear;
    public void Display()
    {
        Console.WriteLine($"{_jobTitle} {_company} {startYear}-{endYear}");
    }
}