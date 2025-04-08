public class Activity {
    private string _date;
    private int _duration;
    public Activity(string date, int duration) {
        _date = date;
        _duration = duration;
    }
    public string getDate() {
        return _date;
    }
    public int getDuration() {
        return _duration;
    }
    public virtual double getDistance() {
        return 0;
    }
    public virtual double getSpeed() {
        return 0;
    }
    public virtual double getPace() {
        return 0;
    }
    public virtual string getSummary() {
        return "";
    }
}