using System;
using System.IO;

class Program
{
    private List<Goal> Goals = new List<Goal>(); 
    private int points = 0;
    private int level = 0;

    string filename;

    static void Main(string[] args)
    {
        Program program = new Program();
        Console.WriteLine("Hello Develop05 World!");
        bool _is_finished =  false;
        bool _valid_selection = false;
        // Create a base "Assignment" object
        Console.WriteLine("Hello Develop04 World!");
        Menu menu = new Menu();
        

        while (!_is_finished) {
            program.level = program.points / 100;
            Console.WriteLine("");
            Console.WriteLine($"You are currently level {program.level}. You have {program.GetScore()} points.");
            Console.WriteLine("");
            Console.WriteLine("Select a choice from the menu");
            menu.DisplayMenu();
            Console.Write("> ");
            string selection = Console.ReadLine();

            Console.Clear();
            switch (selection) {
                case "1":
                    _valid_selection = false;
                    while (!_valid_selection) {

                        menu.DisplayGoalMenu();
                        Console.WriteLine("Which goal do you want?");
                        Console.Write("> ");
                        string goal_type = Console.ReadLine();
                        Console.Write("What is the name of your goal? ");
                        string goal_name = Console.ReadLine();
                        Console.Write("Please provide a short description: ");
                        string goal_description = Console.ReadLine();
                        Console.Write("How many points is this goal worth? ");
                        int goal_points = Convert.ToInt32(Console.ReadLine());
                        switch (goal_type) {
                            case "1":
                                SimpleGoal simpleGoal = new SimpleGoal(goal_name, goal_description, goal_points);
                                program.AddGoal(simpleGoal);
                                _valid_selection = true;
                                break;
                            case "2":
                                EternalGoal eternalGoal = new EternalGoal(goal_name, goal_description, goal_points);
                                program.AddGoal(eternalGoal);
                                _valid_selection = true;
                                break;
                            case "3":
                                ChecklistGoal checklistGoal = new ChecklistGoal(goal_name, goal_description, goal_points);
                                program.AddGoal(checklistGoal);
                                _valid_selection = true;
                                break;
                            default :
                                Console.WriteLine("Please enter a valid goal. (1, 2, or 3).");
                                break;
                        }   
                    }
                    break;
                case "2":
                    program.DisplayGoals();
                    break;
                case "3":
                    Console.Write("Please enter a filename: ");
                    program.filename = Console.ReadLine();
                    program.SaveGoals(program.filename);
                    break;
                case "4":
                    Console.Write("Please enter a filename: ");
                    program.filename = Console.ReadLine();
                    string[] filedata = program.LoadGoals(program.filename);
                        bool firstLine = true;
                        foreach (string line in filedata)
                        {
                            if (firstLine) {
                                program.points = Convert.ToInt32(line);
                                firstLine = false; 
                            }
                            else {
                                string[] parts = line.Split(":");

                                string goalName = parts[0];
                                string[] data = parts[1].Split(",");
                                switch (goalName) {
                                    case "SimpleGoal":
                                        SimpleGoal simpleGoal = new SimpleGoal(data[0], data[1], Convert.ToInt32(data[2]), Convert.ToBoolean(data[3]));
                                        program.AddGoal(simpleGoal);
                                        _valid_selection = true;
                                        break;
                                    case "EternalGoal":
                                        EternalGoal eternalGoal = new EternalGoal(data[0], data[1], Convert.ToInt32(data[2]), Convert.ToBoolean(data[3]));
                                        program.AddGoal(eternalGoal);
                                        _valid_selection = true;
                                        break;
                                    case "ChecklistGoal":
                                        ChecklistGoal checklistGoal = new ChecklistGoal(data[0], data[1], Convert.ToInt32(data[2]), Convert.ToBoolean(data[3]), Convert.ToInt32(data[4]), Convert.ToInt32(data[5]), Convert.ToInt32(data[6]));
                                        program.AddGoal(checklistGoal);
                                        _valid_selection = true;
                                        break;
                                    default :
                                        Console.WriteLine("That line didn't apply to any goals.");
                                        break;
                                }
                            }   
                        }
                    break;
                case "5":
                    program.RecordGoalEvent();
                    program.isLevelUp(program.level, program.points);
                    break;
                case "6":
                    _is_finished =  true;
                    break;
                default:
                    Console.WriteLine("That was an invalid input. Please try again.");
                    break;
            }
        }
    }

    public void AddGoal(Goal goal) {
        Goals.Add(goal); 
    }
    public void RecordGoalEvent() {
        Console.WriteLine("Which goal did you accomplish?");
        for (int i = 0; i < Goals.Count(); i++) {
            Console.WriteLine($"{i+1}. {Goals[i].GetName()}");
        }
        Console.Write("> ");
        int selected_goal = Convert.ToInt32(Console.ReadLine()) - 1;
        int points_to_add = Goals[selected_goal].GetPoints();
        Console.WriteLine($"Congratulations! You just got {points_to_add} points!");
        points += points_to_add;
    }
    public void DisplayGoals() {
        for (int i = 0; i < Goals.Count(); i++) {
            Goals[i].Display();
        }
    }
    public void SaveGoals(string filename) {
        string content = $"{points}\n";
        File.WriteAllText(filename, string.Empty);
        File.AppendAllText(filename, content);
        for (int i = 0; i < Goals.Count(); i++) {
            Goals[i].SaveGoal(filename);
        }
    }
    public string[] LoadGoals(string filename) {
        if (!File.Exists(filename))
        {
            Console.WriteLine($"Warning: The file '{filename}' was not found. Creating a new one...");
            File.WriteAllText(filename, ""); // Create an empty file
            return new string[0];
        }
        string[] lines = System.IO.File.ReadAllLines(filename);

        return lines;
    }
    public int GetScore() {
        return points;
    }
    public void isLevelUp(int level, int points) {
        int newLevel = points / 100;
        if (level < newLevel) {
            Console.WriteLine($"Congrats! You just leveled up to level {newLevel}!");
        }
    }
}