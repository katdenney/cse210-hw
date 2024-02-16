using System;
using System.ComponentModel;
using System.IO;
using System.IO.Enumeration;
using System.Reflection.Metadata;
using static Constants;
class GoalManager 
{
    private List <Goal> _goalList = new List<Goal>();
    private List <Goal> _recordableGoalList;
    private string _mainMenuString = """
        ******************************
        Menu Options:
            1. Create New Goal
            2. List Goals
            3. Save Goals
            4. Load Goals
            5. Record Event
            6. Quit
        Select a choice from the menu:
        """;

    public GoalManager(){}     
    public void Start()
    {
        Console.Clear();
        bool exit = false;
        int choice;
        while (!exit)
        {
            Console.WriteLine(_mainMenuString);
            choice = int.Parse(Console.ReadLine());
            switch(choice)
            {
                case 1: 
                    ShowCreateNewGoalsMenu();//this works and creates a goal
                    break;
                case 2:
                    DisplayPlayerInfo();
                    break;
                case 3:
                    ShowSaveGoalsMenu();//this works and saves goals
                    break;
                case 4:
                    ShowLoadGoalsMenu();//this works and loads goals 
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

    private void ShowCreateNewGoalsMenu()//this works. 
    {
        String menu ="""
        The Types of Goals are:
              1. Simple Goal
              2. Eternal Goal
              3. Checklist Goal
        Which type of goal would you like to create?
        """;
        int choice;
        while(true)
        {
            Console.WriteLine(menu);
        
            string userInput = Console.ReadLine();
            if (int.TryParse(userInput, out choice))
            {
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
                break;
            }
            else
            {
                Console.WriteLine("Error, Try again. Please Enter an Integer choice.");
            }
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
        // foreach (Goal goal in _goalList)
        // {
        //     Console.WriteLine($"{kind}goal: {name}, {desc} points:{pointsInt}");

        // }
    }
    public void ListGoalNames()//not using this right now
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

    public void ListGoalDescriptions()//not using this right now
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
    private void ShowSaveGoalsMenu()//this is working now
    {
        Console.WriteLine("Enter a filename to save goals:");
        string fileName = Console.ReadLine();
        SaveGoalsToFile(fileName);
    }
    public void SaveGoalsToFile(string fileName)//this is working now
    { 
        // if(fileName.EndsWith(".txt"))
        //     fileName += ".txt";
        Console.WriteLine($"Saving to file...{fileName}");
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Goal goal in _goalList)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
    }
    private void ShowLoadGoalsMenu()//this is working now
    {
        Console.WriteLine("Enter a txt filename to load goals from:");
        string fileName = Console.ReadLine();
        // if(!fileName.EndsWith(".txt"))
        // {
        //     fileName += ".txt";
        // }
        _goalList.Clear();
        LoadGoalsFromFile(fileName); 
    }
    public void LoadGoalsFromFile(string fileName)//this is not totally working it needs to tack on txt if not found in input.
    {
        using (StreamReader reader = new StreamReader(fileName))
        {
            while(!reader.EndOfStream)
            try
            {
                string nextLine = reader.ReadLine();
                string[] goalData = GetGoalDataStrings(nextLine);
                string goalType = goalData[0];  // count of 5 for simple and 6 for eternal, 7 for checklist
                //Console.WriteLine($"array is count {goalData.Length}");
                string[] baseData = {goalData[1], goalData[2], goalData[3], goalData[4]};
                switch (goalType)
                {
                    case "simple":
                       _goalList.Add(new SimpleGoal( baseData ));
                        break;
                    case "checklist":
                        string[] checklistData = {goalData[5], goalData[6], goalData[7]};
                        _goalList.Add(new ChecklistGoal(baseData, checklistData));
                        break;
                    case "eternal":
                        _goalList.Add(new EternalGoal(baseData, goalData[5]));
                        break;
                    default:
                        new Exception($"Unknown: {nextLine} is not a goal.");
                        break;
                }
                //Console.WriteLine("Finished loading a line of data.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading goals: {ex.Message}");
            }
        }
        Console.WriteLine("Finished loading Data From File.");
    }
    private string[] GetGoalDataStrings(string line){
        string[] data = line.Split(delimiter);
        return data;
    }

    private void ShowRecordEventMenu()
    {
        BuildListOfRecordableGoals();
        int choice;

        DisplayGoalList(_recordableGoalList);
        Console.WriteLine("Which goal would you like to record?");
        string userInput = Console.ReadLine();
        if (int.TryParse(userInput, out choice))
        {
            Goal g = _recordableGoalList[choice -1]; // subtract 1 so the index is now zero-based
            g.RecordEvent();
            Console.WriteLine($"The goal: {g.GetName()} has been Recorded.");
        }
        else 
        {
            Console.WriteLine("Error, Try again. Please Enter an Integer choice.");
        }
    }
    public int ShowEventToRecord()
    { 
        int index = 1;
        foreach (Goal goal in _goalList)
        {
            if (!goal.IsComplete())
                Console.WriteLine($"{index++}. {goal.GetName()}");
        }
        return index -1;

    }
    // public Goal GetEventToRecord(int indexToSelect)
    // {
    //     int index = 1;
    //     foreach(Goal goal in _goalList)
    //     {
    //         if (!goal.IsComplete())
    //         {
    //             if(index == indexToSelect)
    //                 return goal;
    //             index++;
    //         }
    //     }
    //     return null;
    // }
    // public bool CheckForGoalsToRecord()//unneeded
    // {
    //     foreach (Goal goal in _goalList)
    //     {
    //         if (!goal.IsComplete())
    //             return true;
    //     }
    //     return false;
    // }
    public void BuildListOfRecordableGoals()
    {
        _recordableGoalList = new List<Goal>();
        foreach (Goal goal in _goalList)
        {
            if (!goal.IsComplete())
                _recordableGoalList.Add(goal);
        }
        Console.WriteLine($"recordableGoalsList count = {_recordableGoalList.Count}");
    }

    public void DisplayGoalList(List<Goal> list)
    {
        int index = 1;
        foreach (Goal goal in list)
        {
            Console.WriteLine($"{index++} {goal.GetDetailsString()}");  
        }
    }
    public void DisplayPlayerInfo() 
    {
        if (_goalList.Count >0)
        {
            DisplayGoalList(_goalList);
        }
        else
        {
            Console.WriteLine("No goals created or loaded");
        }
        Console.WriteLine($"You have {GetTotalScore()} points.");
    }
    public void ListGoalDetails(Goal goal)
    { 
        Console.WriteLine($"{goal}Goal:{goal.GetName()}, {goal.GetDescription()}"); 
    }  
    public int GetTotalScore()
    {
        int totalScore = 0;
        foreach(Goal goal in _goalList)
        {
            totalScore += goal.GetScore();
        }
        return totalScore;
    }
}