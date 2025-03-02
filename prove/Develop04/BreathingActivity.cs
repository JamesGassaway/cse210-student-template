using System.Reflection.Metadata;

public class BreathingActivity : Activity
{  
    private const string _activityName = "Breathing";
    private const string _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    public BreathingActivity() : base(_activityName, _description) {
        StartActivity();
        DoActivity();
        EndActivity();
    }
    public void DoActivity()
    {
        int _numberOfBreaths = getDuration();
        BreatheIn(3);
        BreatheOut(4);
        while(_numberOfBreaths > 0) {
            BreatheIn(4);
            BreatheOut(6);
            _numberOfBreaths -= 10;

        }

    }
    public void BreatheIn(int length) {
        Console.Write("Breathe In...");
        RunCountdown(length);
        Console.WriteLine();

    }
    public void BreatheOut(int length) {
        Console.Write("Now Breathe Out...");
        RunCountdown(length);
        Console.WriteLine();
        Console.WriteLine();
    }
}