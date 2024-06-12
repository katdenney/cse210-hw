using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop02 World!");
        Console.WriteLine("Welcome to the Journal Program");
        /* setting things up: declaring boolean variable(attribute) for exit initializing it false
           declaring integer variable(attribute) named choice */
        bool exit = false;
        int choice;
        /* making an instance of the class named Prompt using the "new" keyword to call the Prompt constructor and assigning the instance to the variable promptInstance 
           making an instance of the class named Journal using the "new" keyword to call the Journal constructor and assigning the instance to the variable journalInstance
            the reading says one instance is not an object (which is confusing)*/
        Prompt promptInstance = new Prompt();
        Journal journalInstance = new Journal();
        // the menu, defigning a multi line string and naming it menu  
        string menu = """
            Please select one of the following choices:
            1. Write
            2. Display
            3. Save 
            4. Load
            5. Quit
        """;
        // a while loop that loops as long as the exit variable is false 
        while (!exit)
        {   //printing the menu
            Console.WriteLine(menu);
            //reading the user input and turning the string into an integer and assigning it to the variable named choice
            choice = int.Parse(Console.ReadLine());
            //if and else if statments checking the value of the variable named choice
            if (choice == 1) // 1. Write
            {
                // get date from user
                Console.WriteLine("Enter today's date:");
                string date = Console.ReadLine();

                // display prompt string
                string prompt = promptInstance.GetPrompt();
                Console.WriteLine($"{prompt}");

                // get entry from user 0
                Console.WriteLine("Answer: ");
                string answerPrompt = Console.ReadLine();

                // add new Entry to the Journal
                journalInstance.AddEntry(date, prompt, answerPrompt);
            }
            else if (choice == 2)//2. Display
            { 
                journalInstance.DisplayAll();
            }
            else if (choice == 3)//3. Save 
            {
                journalInstance.SaveToFile();
            }
            else if (choice == 4)//4. Load
            {
                journalInstance.LoadFromFile();
            }
            else if (choice == 5)//5. Quit
            {
                exit = true;
            }
        }
        // the end of the program
        
    }
    
}