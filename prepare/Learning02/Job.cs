    //Class:Job
    //_company:string
    //_jobTitle:string
    //_startYear:int
    //_endYear:int
    //Behaviors:
    //Display():void
public class Job
    {//I know I need to use getters and setters though I dont totally understand them yet.
        public string _jobTitle { get; set;}
        public string _company {get; set;}
        public int _startYear {get; set;}
        public int _endYear {get; set;}

    public void Display()
    {
        Console.WriteLine($"{_company},{_jobTitle} {_startYear}-{_endYear} ");
    }

    
}