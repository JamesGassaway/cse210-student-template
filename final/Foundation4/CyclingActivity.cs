public class CyclingActivity: Activity {
    private double _speed;
    public CyclingActivity(string date, int duration, double speed): base(date, duration) {
        _speed = speed;

    }
    public override double getDistance() {
        return Math.Round(_speed / 60 * getDuration(), 2);
    }
    public override double getSpeed() {
        return _speed;
    }
    public override double getPace() {
        return Math.Round(getDuration() / getDistance(), 2);
    }
    public override string getSummary() {
        return $"{getDate()} Running ({getDuration()} min) - Distance: {getDistance()} miles, Speed: {getSpeed()} mph, Pace: {getPace()} min per mile";
    }
}