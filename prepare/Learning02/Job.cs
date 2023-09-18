using System.Reflection;
using System.Transactions;

public  class Job
{
    public string _jobTitle;
    public string _company;
    public double _startYear;
    public double _endYear;

    public void Display()

    {
        Console.WriteLine($"I was a {_jobTitle} for {_company}, during the years of {_startYear}-{_endYear}!");
    }

}