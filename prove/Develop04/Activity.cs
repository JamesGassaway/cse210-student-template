using System.Runtime.Versioning;

public class Activity
{  
    private Random _random = new Random();
    private int _duration;
    private string _activityName;
    private string _description;
    public Activity(string activityName, string description)
    {
        _activityName = activityName;
        _description = description;

        Console.WriteLine($"Welcome to the {_activityName} activity.");
        Console.WriteLine($"");
        Console.WriteLine($"{_description}");
        Console.WriteLine($"");
        Console.WriteLine($"Please enter the duration you want for this activity.");
        Console.Write("> ");
        string duration = Console.ReadLine();
        _duration = Int32.Parse(duration);
    }
    public void RunCountdown(int timer)
    {
        while (timer > 0) {
            Console.Write(timer);
            Thread.Sleep(1000);
            Console.Write("\b \b"); // Erase the + character
            timer--;
        }
    }
    public string GetRandomPrompt(List<string> prompts)
    {
        int randomIndex = _random.Next(prompts.Count);
        string randomString = prompts[randomIndex];
        return randomString;
    }
    public int RunAnim(int duration)
    {
        int frame = 0;
        List<char> anim = ['-', '/', '|', '\\'];
        while (duration > 0) {
            Console.Write(anim[frame]);
            Thread.Sleep(250);
            Console.Write("\b \b"); // Erase the + character
            if (frame == 3) {
                frame = 0;
                duration--;
            }
            else {
                frame++;
            }
        }

        return 0;
    }
    public void StartActivity(){
        Console.WriteLine("Get Ready...");
        RunAnim(5);
        Console.WriteLine("");
    }
    public void EndActivity(){
        Console.WriteLine("");
        Console.WriteLine("Well done!!");
        RunAnim(5);
        Console.WriteLine($"You have completed another {_duration} seconds of the {_activityName} activity.");
        RunAnim(5);
    }
    public int getDuration() {
        return _duration;
    }
}