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
            2. Start listing activity
            3. Start reflecting activity
            4. Quit
        Select a choice from the menu:
        """;
        while (!exit)
        {
            Console.WriteLine(menu);
            choice = int.Parse(Console.ReadLine());
            Console.WriteLine("Please give the duration for this activity in seconds.");
            duration = int.Parse(Console.ReadLine());
            DateTime startTime = DateTime.Now;
            if (choice == 1)
            {
                //instance of Breathing activity
                BreathingActivity breathing1 = new BreathingActivity();
                breathing1.SetName("Breathing");
                breathing1.SetDescription("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
                breathing1.SetDuration(duration);
                breathing1.DisplayStartingMessage();
                breathing1.SetStartTime(startTime);
                breathing1.Run();
            }
            else if (choice == 2)
            {
                //instance of Listing activity
                ListingActivity listing1 = new ListingActivity();
                listing1.SetName("Listing");
                listing1.SetDescription("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                listing1.SetDuration(duration);
            }
            else if (choice == 3)
            {
                //instance of Reflecting activity
                ReflectingActivity reflecting1 = new ReflectingActivity();
                reflecting1.SetName("Reflecting");
                reflecting1.SetDescription("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                reflecting1.SetDuration(duration);
                reflecting1.DisplayStartingMessage();
                reflecting1.SetStartTime(startTime);
                reflecting1.Run();
            }
            else if (choice == 4)
            {
                exit = true;
            }
        }
    }
}