using System;

class Program
{
    private List<Activity> _activities = new List<Activity>();
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation4 World!");
        Program program = new Program();

        RunningActivity runningActivity = new RunningActivity("03 Nov 2022", 30, 3.0);
        program._activities.Add(runningActivity);

        CyclingActivity cyclingActivity = new CyclingActivity("03 Nov 2022", 40, 15);
        program._activities.Add(cyclingActivity);

        SwimmingActivity swimmingActivity = new SwimmingActivity("03 Nov 2022", 25, 20);
        program._activities.Add(swimmingActivity);

        foreach (Activity activity in program._activities) {
            Console.WriteLine(activity.getSummary());
        }

    }
}