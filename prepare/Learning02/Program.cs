using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");
        //Create a new job instance named job1
        //Set the member variables using the dot notation (for example, job1._jobTitle = "Software Engineer";
        //Verify that you can display the company of this job on the screen, again using the dot notation to access the member variable
        //Create a second job, set its variables, display this company on the screen as well
       
        Job job1 = new Job
        {
            _jobTitle = "Software Engineer",
            _company = "Microsoft",
            _startYear = 2019,
            _endYear = 2022,
        };
        job1.Display();

        Job job2 = new Job
        {
            _jobTitle = "Manager",
            _company = "Apple",
            _startYear = 2022,
            _endYear = 2023
        };
        job2.Display();


    }
}