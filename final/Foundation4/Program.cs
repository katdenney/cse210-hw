using System;
using System.Diagnostics;
using ExerciseProj;
using ExerciseProj =ExerciseProj.Exercise;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation4 World!");

        List<Exercise> exerciseList =new List<Exercise>();
        Running running1 = new Running(DateTime.Now,30,3);
        exerciseList.Add(running1);

        Running running2 = new Running(DateTime.Now,45,5.5F);
        exerciseList.Add(running2);

        Swimming swimming1 = new Swimming(DateTime.Now,30,50);
        exerciseList.Add(swimming1);

        Swimming swimming2 = new Swimming(DateTime.Now.AddDays(2),20,30);
        exerciseList.Add(swimming2);

        Cycling cycling1 = new Cycling(DateTime.Now.AddDays(4),25,6.2F);
        exerciseList.Add(cycling1);

        Cycling cycling2 = new Cycling(DateTime.Now.AddDays(1),60,14.7F);
        exerciseList.Add(cycling2);

        foreach(Exercise exercise in exerciseList)
        {
            exercise.DisplaySummary();
        }

    }
}