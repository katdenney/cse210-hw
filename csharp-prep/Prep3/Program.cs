using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

        Console.Write("what is the magic number? ");
        string userInput = Console.ReadLine();
        int magicNumber = int.Parse(userInput);
        string userGuess;
        int guess;
        
        do
        {   
            Console.Write("what is your guess?");
            userGuess = Console.ReadLine();
            guess = int.Parse(userGuess);
            
            if (guess < magicNumber)
            {
                Console.WriteLine("guess higher");
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("guess lower");
            }
            else
            {
                Console.Write("something went wrong");
            }
        } while (guess != magicNumber);

        Console.Write("You guessed it!");

       
    }
}