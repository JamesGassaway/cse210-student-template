public class RunningActivity: Activity {
    private double _distance;
    public RunningActivity(string date, int duration, double distance): base(date, duration) {
        _distance = distance;

    }
    public override double getDistance() {
        return _distance;
    }
    public override double getSpeed() {
        return Math.Round(_distance / getDuration() * 60, 2);
    }
    public override double getPace() {
        return Math.Round(getDuration() / _distance, 2);
    }
    public override string getSummary() {
        return $"{getDate()} Running ({getDuration()} min) - Distance: {getDistance()} miles, Speed: {getSpeed()} mph, Pace: {getPace()} min per mile";
    }
}