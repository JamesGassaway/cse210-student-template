using System.Numerics;
using System.Runtime.CompilerServices;

public class ChecklistGoal : Goal {
    private bool _isComplete;
    private string _name;
    private string _description;
    private int _points;
    private int _total_completed = 0;
    private int _total_goal;
    private int _completion_bonus;


    public ChecklistGoal(string name, string description, int points) : base(name, description, points)
    {
        _isComplete = false; // Default value
        _name = name;
        _description = description;
        _points = points;

        Console.WriteLine("How many times do you want to accomplish this goal to get bonus points?");
        string _total_goal_str = Console.ReadLine();
        _total_goal = Convert.ToInt32(_total_goal_str);

        Console.WriteLine("How much is the bonus?");
        string _bonus_points_str = Console.ReadLine();
        _completion_bonus = Convert.ToInt32(_bonus_points_str);
    }
    public ChecklistGoal(string name, string description, int points, bool isComplete, int completion_bonus, int total_completed, int total_goal) : base(name, description, points)
    {
        _isComplete = isComplete; // Default value
        _name = name;
        _description = description;
        _points = points;
        _total_goal = total_goal;
        _completion_bonus = completion_bonus;
        _total_completed = total_completed;
    }
    public override void Display()
    {   
        string displayIsComplete = " ";
        if (_isComplete) {
            displayIsComplete = "X";
        }
        Console.WriteLine($"[{displayIsComplete}] {_name} ({_description}) -- Currently completed: {_total_completed} / {_total_goal}");
    }

    public override void SetCompleted() {
        _isComplete = true;
    }

    public override int GetPoints() {
        SetRep();
        int _points_to_add = _points;
        if (_total_completed == _total_goal) {
            _points_to_add += _completion_bonus;
            SetCompleted();
        }
        return _points_to_add;

    }
    public override void SetRep() {
        _total_completed+=1;
    }
    public override bool IsCompleted() {
        return _isComplete;
    }
    public override string GetName()
    {
        return _name;
    }
    public override void SaveGoal(string filename) {
        File.AppendAllText(filename, $"ChecklistGoal:{_name},{_description},{_points},{_isComplete},{_completion_bonus},{_total_completed},{_total_goal}\n");
    }
}