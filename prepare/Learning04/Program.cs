using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning 04 Homework World!");
        Assignment assignment1 = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(assignment1.GetSummary());

        MathAssignment mathassignment1 = new MathAssignment("Roberto Rodriguez","Fractions","7.3","8-19");
        Console.WriteLine(mathassignment1.GetSummary());
        Console.WriteLine(mathassignment1.GetHomeworkList());

        WritingAssignment writingassignment1 = new WritingAssignment("Mary Waters","European History","The Causes of World War II");
    }
}