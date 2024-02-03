using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop04 World!");
        Console.WriteLine("Welcome to The Mindfulness Program");
        bool exit = false;
        int choice;
        int duration;

        string menu = """
        Menu Options:
            1. Start breathing activity
            2. Start reflecting activity
            3. Start listing activity
            4. Quit
        Select a choice from the menu:
        """;
        while (!exit)
        {
            Console.WriteLine(menu);
            choice = int.Parse(Console.ReadLine());
            Console.WriteLine("Please give the duration for this Avtivity");
            duration = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                //instance of Breathing activity
                BreathingActivity breathing1 = new BreathingActivity();
                breathing1.SetName("Breathing");
                breathing1.SetDescription("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
                breathing1.SetDuration(duration);
                breathing1.DisplayStartingMessage();
                breathing1.Run();

            }
            else if (choice == 2)
            {
                //instance of Listing activity
                ListingActivity listing1 = new ListingActivity();
                listing1.SetName("Listing");
                listing1.SetDescription("");
                listing1.SetDuration(duration);
            }
            else if (choice == 3)
            {
                    //instance of Reflecting activity
                ReflectingActivity reflecting1 = new ReflectingActivity();
                reflecting1.SetName("Reflecting");
                reflecting1.SetDescription("");
                reflecting1.SetDuration(duration);
            }
            else if (choice == 4)
            {
                exit = true;
            }
        }
    }
}