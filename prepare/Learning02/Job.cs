public class Job
{
    //Class:Job
    //_company:string
    //_jobTitle:string
    //_startYear:int
    //_endYear:int
    //Behaviors:
    //Display():void
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;

    public void Display()
    {
        Console.WriteLine($"{_company},{_jobTitle} {_startYear}-{_endYear} ");
    }

    
}