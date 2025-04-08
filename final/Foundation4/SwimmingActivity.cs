public class SwimmingActivity: Activity {
    private int _laps;
    public SwimmingActivity(string date, int duration, int laps): base(date, duration) {
        _laps = laps;

    }
    public override double getDistance() {
        return Math.Round(_laps * 50 / 1000 * 0.62, 2);
    }
    public override double getSpeed() {
        return Math.Round(getDistance() / getDuration() * 60, 2);
    }
    public override double getPace() {
        return Math.Round(getDuration() / getDistance(), 2);
    }
    public override string getSummary() {
        return $"{getDate()} Running ({getDuration()} min) - Distance: {getDistance()} miles, Speed: {getSpeed()} mph, Pace: {getPace()} min per mile";
    }
}