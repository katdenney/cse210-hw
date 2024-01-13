using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        string name = PromptUserName();
        int userNumber = PromptUserNumber();
        int number = GetSquareNumber();
        int numsquared = SquareNumber(number);
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
        int userNumber = int.Parse(userInput);
        return userNumber;

    }
    static int GetSquareNumber()
    {
        Console.Write("Enter a number to square: ");
        string userInput = Console.ReadLine();
        int number = int.Parse(userInput);
        return number;
    }
    static int SquareNumber(int number)
    {
        
        return number * number;

    }
    static void DisplayResult()
    {
        Console.WriteLine($"{}{}{}")
    }
}