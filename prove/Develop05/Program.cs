using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop05 World!");
        GoalManager manager = new GoalManager();
        manager.Start();
        Console.WriteLine("Program closing.");         
    }
}