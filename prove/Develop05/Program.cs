using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop05 World!");
        SimpleGoal goal1 = new SimpleGoal("thename","thedescription",9);
        string name = goal1.GetStringRepresentation();
        List<Goal> goals = new List<Goal>();
        goals.Add(goal1);
        foreach (Goal goal in goals)
        {
            string print = goal.GetStringRepresentation();
            Console.WriteLine(goal.GetStringRepresentation());
            Console.WriteLine(print);
        }
        GoalManager manager = new GoalManager(0);
        manager.Start();
                
    }
}