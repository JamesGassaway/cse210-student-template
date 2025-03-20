public class SimpleGoal : Goal {
    private bool _isComplete;
    private string _name;
    private string _description;
    private int _points;
    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isComplete = false; // Default value
        _name = name;
        _description = description;
        _points = points;
    }
    public SimpleGoal(string name, string description, int points, bool isComplete)  : base(name, description, points)
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
        _isComplete = true;
    }

    public override int GetPoints() {
        SetCompleted();
        return _points;
    }
    public override void SetRep() {

    }
    public override bool IsCompleted() {
        return true;
    }
    public override string GetName()
    {
        return _name;
    }
    public override void SaveGoal(string filename) {
        File.AppendAllText(filename, $"SimpleGoal:{_name},{_description},{_points},{_isComplete}\n");
    }
}