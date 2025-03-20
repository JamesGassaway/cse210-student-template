public abstract class Goal {
    private string name;
    private string description;
    private int points;
    public abstract bool IsCompleted();

    public abstract void SetCompleted();
    public virtual int GetGoalPoint() {
        return 0;
    }
    public Goal(string name, string description, int points) {

    }

    public abstract void Display();
    public abstract int GetPoints();
    public abstract void SetRep();
    public abstract string GetName();
    public abstract void SaveGoal(string filename);
}