using System;

class GoalManager 
{
    private List <Goal> _goals = new List<Goal>();
    private int _score;
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


    public GoalManager()
    {

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
                    ShowListGoalsMenu();
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
        switch(choice){
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
    private void ShowListGoalsMenu()
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
    public void CreateGoal(string kind)   //switch statment to create "kind" of goal
    { 
        switch(kind){
            case "simple": 
                Console.WriteLine("What is the name of your goal");
                break;
            case "eternal":
                CreateGoal("eternal");
                break;
            case "checklist":
                CreateGoal("checklist");
                break;
            default:
                Console.WriteLine("Hey! You entered and incorrect option!");
                break;
        }
    }
    public void RecordEvent()
    {

    }
    public void SaveGoals()
    {

    }
    public void LoadGoals()
    {

    }
    //Console.WriteLine("select menu option");

}