using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
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
       
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;
        
        //Display job 1
        //job1.Display();

        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._startYear = 2022;
        job2._endYear = 2023;
        
        //Display job 2
        //job2.Display();
        

        
        //new instance of the resume class
        Resume resume1 = new Resume();
        resume1._name = "Allison Rose";
            
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);

        resume1.Display();
          
    }
}