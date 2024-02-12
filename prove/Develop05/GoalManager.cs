using System;
using System.IO;
class GoalManager 
{
    private List <Goal> _goalList = new List<Goal>();
    /*private string _goalsFileName = "goals1.txt";
    string[] lines = System.IO.File.ReadAllLines("goals1.txt");

    foreach (string line in lines)
    {
        string[] parts = line.Split(",");
        string[] name = parts[0];
        string[] description = parts[1];
    }*/
    private int _goalCount;
    private int _score = 0;
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


    public GoalManager(int score)
    {
        _score = score;
       // _goalList = System.IO.File.ReadAllLines(goals1.txt);
       // _goalCount = _goalList.Length;
    }
    public void Start()
    {
        bool exit = false;
        int choice;
        while (!exit)
        {
            Console.WriteLine(_mainMenuString);
            choice = int.Parse(Console.ReadLine());
            switch(choice){
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
                    Console.WriteLine("Hey! You entered and incorrect option!");
                    exit = true;
                    break;

            }
        }
    }

    private void ShowCreateNewGoalsMenu()
    {
        String menu = """
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
                Console.WriteLine("Hey! You entered and incorrect option!");
                break;
        }
    }
    public void CreateGoal(string kind)   //switch statment to create "kind" of goal
    { 
        Console.WriteLine($"Building a goal {kind}.");
        Console.WriteLine($"Enter a short name for this Goal.");
        string name = Console.ReadLine();
        Console.WriteLine($"{name}");
        Console.WriteLine($"Enter a description for this Goal.");
        string desc = Console.ReadLine();
        Console.WriteLine($"{desc}");
        Console.WriteLine($"Enter a description for this Goal.");
        string points = Console.ReadLine();
        int pointsInt = int.Parse(points);
        Console.WriteLine($"{pointsInt}");
        
        switch(kind){
            case "simple": 
                Console.WriteLine("What is the name of your goal");
                string sName = Console.ReadLine();
                Console.WriteLine($"{sName}");
                break;
            case "eternal":
                Console.WriteLine("What is the name of your goal");
                string eName = Console.ReadLine();
                Console.WriteLine($"{eName}");
                break;
            case "checklist":
                Console.WriteLine("What is the name of your goal");
                string cName = Console.ReadLine();
                Console.WriteLine($"{cName}");
                break;
            default:
                Console.WriteLine("Hey! You entered and incorrect option!");
                break;
        }
    }
    
    private void ShowListGoalsMenu() // Output all the goals in the list.
    {
        
    }

    private void ShowSaveGoalsMenu()
    {
        
    }

    private void ShowLoadGoalsMenu()
    {
        
    }

    private void ShowRecordEventMenu()
    {
        Console.WriteLine("ShowRecordEventMenu");
    }
    public void DisplayPlayerInfo()//ex. 1.[ ] goal,discription 
    {


    }
    public void ListGoalNames()
    {

    }
    public void ListGoalDetails()
    {

    }
    
    public void RecordEvent()//abstract?
    {

    }
    public void SaveGoals()
    {/* Console.WriteLine("Enter a name for this file:");
        string fileName = Console.ReadLine();

        Console.WriteLine("Saving to file...");
        fileName += ".csv";
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Goals g in _goals)
            {
                outputFile.WriteLine(g.GetStringRepresentation());
            }
        }*/

    }
    public void LoadGoals()
    {/*  Console.WriteLine("Enter a file to read from:");
        string fileName = Console.ReadLine();
        fileName += ".csv";

        _entries = new List<Entry>();

        string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            //splitting lines into parts with .Split 
            //Console.WriteLine(line);
            string[] parts = line.Split(',');
            //new Entry object and adding that data to _entries list
            //Console.WriteLine($"{parts[0]} and {parts[1]}");
            Goal g = new Goal(parts[1], parts[2], parts[3]);
            _goals.Add(g);
        }
        Console.WriteLine("Finished loading the data.");
        */

    }
    

}