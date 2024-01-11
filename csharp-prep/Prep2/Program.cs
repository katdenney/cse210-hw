using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("Hello Welcome to Prep2!");
        Console.Write("Please enter your grade percentage. ");
        string userInput = Console.ReadLine();
        int number = int.Parse(userInput);
        string grade;
        if (number >= 90)
        {
            grade = "A";
        }
        else if (number >= 80)
        {
            grade = "B";
        }
        else if (number >= 70)
        {
            grade = "C";
        }
        else if (number >= 60)
        {
            grade = "D";
        }
        else if (number < 60)
        {
            grade = "F";
        }
        else
        {
            Console.WriteLine("Something went wrong.");
            return;
        }
        string sign = " ";
        if (grade == "A" && number <= 93)
        {
            sign = "-";
        }
        else if (grade == "B")
        {
            if (number >= 87)
            {
                sign = "+";
            }
            else if (number <=83)
            {
                sign ="-";
            }
        }
        else if (grade == "C")
        {
            if (number >= 77)
            {
                sign = "+";
            }
            else if (number <=73)
            {
                sign ="-";
            }
        }
        else if (grade == "D")
        {
            if (number >= 67)
            {
                sign = "+";
            }
            else if (number <=63)
            {
                sign ="-";
            }
        }
        else
        {
            sign = " ";
        }
    
        Console.WriteLine($"Your grade is {sign}{grade}");
        if (number >= 70)
        {
            Console.WriteLine("Congratulations you passed the class!");
        }
        else if (number <70)
        {
            Console.WriteLine("You have not passed the class. Keep trying and you will do better next time.");
        }
        else
        {
            Console.WriteLine("Something went wrong.");
            return;
        }
        

    }
}