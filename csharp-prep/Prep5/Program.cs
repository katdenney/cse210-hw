using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        string name = PromptUserName();
        int number = PromptUserNumber();
        int numsquared = SquareNumber(number);
        DisplayResult(name, number,numsquared);
    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Hello, Welcome to the Prep5 Program. Glad you're here! ");
    }
    static string PromptUserName()
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();
        return name;

    }
    static int PromptUserNumber()
    {
        Console.Write("Enter your favorite number: ");
        string userInput = Console.ReadLine();
        int number = int.Parse(userInput);
        return number;

    }
    static int SquareNumber(int number)
    {
        
        return number * number;

    }
    static void DisplayResult(string name,int number,int numsquared)
    {
        Console.WriteLine($"Your name is: {name}. Your favorite number is: {number}. Your favorite number squared is: {numsquared}.");
    }
}