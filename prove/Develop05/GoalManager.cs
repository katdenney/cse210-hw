using System;
using System.ComponentModel;
using System.IO;
using System.IO.Enumeration;
using System.Reflection.Metadata;
using static Constants;
class GoalManager 
{
    private List <Goal> _goalList = new List<Goal>();
    
    //private int _score = 0; //this is now a function that adds up all the points 
    private string _mainMenuString = """
        Menu Options:
            1. Create New Goal
            2. List Goals
            3. Save Goals
            4. Load Goals
            5. Record Event
            6. Quit
        Select a choice from the menu:
        """;

    public GoalManager() {} //total score of all Goals in the List
    
    public void Start()
    {
        bool exit = false;
        int choice;
        while (!exit)
        {
            Console.WriteLine(_mainMenuString);
            choice = int.Parse(Console.ReadLine());
            switch(choice)
            {
                case 1: 
                    ShowCreateNewGoalsMenu();
                    break;
                case 2:
                    ListGoalNames();
                    break;
                case 3:
                    ShowSaveGoalsMenu();
                    break;
                case 4:
                    ShowLoadGoalsMenu();
                    break;
                case 5:
                    ShowRecordEventMenu();
                    break;
                case 6:
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Hey! You entered an incorrect option!");
                    exit = true;
                    break;

            }
        }
    }

    private void ShowCreateNewGoalsMenu()
    {
        String menu ="""
        The Types of Goals are:
              1. Simple Goal
              2. Eternal Goal
              3. Checklist Goal
        Which type of goal would you like to create?
        """;
        
        Console.WriteLine(menu);
        int choice = int.Parse(Console.ReadLine());
        switch(choice)
        {
            case 1: 
                CreateGoal("simple");
                break;
            case 2:
                CreateGoal("eternal");
                break;
            case 3:
                CreateGoal("checklist");
                break;
            default:
                Console.WriteLine("Hey! You entered an incorrect option!");
                break;
        }
    }
    public void CreateGoal(string kind)   //switch statment to create "kind" of goal
    {
        Console.WriteLine($"Building a {kind} goal.");
        Console.WriteLine($"Enter a short name for this Goal.");
        string name = Console.ReadLine();
        //Console.WriteLine($"{name}");
        Console.WriteLine($"Enter a description for this Goal.");
        string desc = Console.ReadLine();
        //Console.WriteLine($"{desc}");
        Console.WriteLine($"Enter an amount of points this goal will be worth.");
        string points = Console.ReadLine();
        int pointsInt = int.Parse(points);
        //Console.WriteLine($"{pointsInt}");
        
        switch(kind)
        {
            case "simple": 
                Goal simpleGoal = new SimpleGoal(name, desc, pointsInt);  
                _goalList.Add(simpleGoal);              
                break;
            case "eternal":
                Goal eternalGoal = new EternalGoal(name, desc, pointsInt); 
                _goalList.Add(eternalGoal);
                break;
            case "checklist":
                Console.WriteLine("Enter how many times would you like to acomplish this goal?");
                string userData = Console.ReadLine();
                int target = int.Parse(userData);
                Console.WriteLine($"What is the bonus point reward once it is completed {target} times?");
                userData = Console.ReadLine();
                int bonus = int.Parse(userData);
                int count = 0; //Yegor helped me here and said we create a new goal, so there will be 0 completed goals at the start
                Goal checklistGoal = new ChecklistGoal(name, desc, pointsInt, target, bonus, count);  
                _goalList.Add(checklistGoal);
                break;
            default:
                Console.WriteLine("Hey! You entered an incorrect option!");
                break;
        }
        foreach (Goal goal in _goalList)
        {
            Console.WriteLine($"{kind}goal: {name}, {desc} points:{pointsInt}");

        }
    }
    public void ListGoalNames()
    {
        string nameList = "";
        foreach (Goal goal in _goalList)
        {
          string name = goal.GetName(); 
          nameList += $"{name}\n";
          Console.WriteLine(name);
        }
        // Console.writeLine(nameList);
    }

    public void ListGoalDescriptions()
    {
        string descriptionsList = "";
        foreach (Goal goal in _goalList)
        {
          string desc = goal.GetDescription(); 
          descriptionsList += $"{desc}\n";
          Console.WriteLine(desc);
        }
        // Console.writeLine(descriptionsList);
    }
    private void ShowSaveGoalsMenu()
    {
        Console.WriteLine("Enter a filename to save goals:");
        string fileName = Console.ReadLine();
        SaveGoalsToFile(fileName);
    }
    public void SaveGoalsToFile(string fileName)
    { 
        if(fileName.IndexOf(".txt") == -1)
            fileName += ".txt";
        Console.WriteLine($"Saving to file...{fileName}");
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Goal goal in _goalList)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
    }
    private void ShowLoadGoalsMenu()
    {
        Console.WriteLine("Enter a txt filename to load goals from:");
        string fileName = Console.ReadLine();
        if(fileName.IndexOf(".txt") == -1)
        {
            _goalList.Clear();
            LoadGoalsFromFile(fileName);
        }
        else fileName += ".txt";
        _goalList.Clear();
        LoadGoalsFromFile(fileName); 
    }
    public void LoadGoalsFromFile(string fileName)//this section is pretty closely coppied from instructor I need to go back though after I have better understanding and change things. 
    {
        using (StreamReader reader = new StreamReader(fileName))
        {
            while(!reader.EndOfStream)
            try
            {
                string kindLine = reader.ReadLine();
                switch (kindLine)
                {
                    case "Goal.SimpleGoal":
                        _goalList.Add(new SimpleGoal(reader));
                        break;
                    case "GoalTracker.ChecklistGoal":
                        _goalList.Add(new ChecklistGoal(reader));
                        break;
                    case "GoalTracker.EternalGoal":
                        _goalList.Add(new EternalGoal(reader));
                        break;
                    default:
                        new Exception("Unknown type found in file");
                        break;
                    
                    
                }
                Console.WriteLine("Finished loading the data.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading goals: {ex.Message}");
            }
        }
    }
     private void ShowRecordEventMenu()
    {
        Console.WriteLine("ShowRecordEventMenu");
        //print "Which Goal have you compleated?"
        //print list of goals and ask for user input for the number of the goal compleated.
    }
    public void DisplayPlayerInfo()//ex. 1.[ ] goal,discription 
    {


    }
    public void ListGoalDetails(Goal goal)
    { 
        Console.WriteLine($"{goal}Goal:{goal.GetName()}, {goal.GetDescription()}:{goal.GetPoints()}"); 
    }
    public void RecordEvent()
    {

    }
    

        /*private string _goalsFileName = "goals1.txt";
        string[] lines = System.IO.File.ReadAllLines("goals1.txt");

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");
            string[] name = parts[0];
            string[] description = parts[1];
        }*/
    
    public int  GetTotalScore()
    {
        int totalScore = 0;
        foreach(Goal goal in _goalList)
        {
            int _score = goal.GetScore();
            totalScore += _score;
        }
        return totalScore;
    }
}