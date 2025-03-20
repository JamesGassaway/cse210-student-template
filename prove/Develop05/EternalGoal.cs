public class EternalGoal : Goal {
    private bool _isComplete;
    private string _name;
    private string _description;
    private int _points;
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
        _isComplete = false; // Default value
        _name = name;
        _description = description;
        _points = points;
    }
    public EternalGoal(string name, string description, int points, bool isComplete) : base(name, description, points)
    {
        _isComplete = isComplete; // Default value
        _name = name;
        _description = description;
        _points = points;
    }
    public override void Display()
    {
        string displayIsComplete = " ";
        if (_isComplete) {
            displayIsComplete = "X";
        }
        Console.WriteLine($"[{displayIsComplete}] {_name} ({_description})");
    }

    public override void SetCompleted() {

    }

    public override int GetPoints() {
        return _points;

    }
    public override void SetRep() {

    }
    public override bool IsCompleted() {
        return _isComplete;
    }
    public override string GetName()
    {
        return _name;
    }
    public override void SaveGoal(string filename) {
        File.AppendAllText(filename, $"EternalGoal:{_name},{_description},{_points},{_isComplete}\n");
    }
}