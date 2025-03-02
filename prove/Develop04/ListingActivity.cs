public class ListingActivity : Activity
{  
    private const string _activityName = "Listing";
    private const string _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    int _numberOfEntries;
    List<string> _prompts = [
        "Who are people that you appreciate?",
    "What are personal strengths of yours?",
    "Who are people that you have helped this week?",
    "When have you felt the Holy Ghost this month?",
    "Who are some of your personal heroes?"
    ];
    public ListingActivity() : base(_activityName, _description) {
        StartActivity();
        DoActivity();
        EndActivity();
        
    }
    public void DoActivity()
    {
        int time = getDuration();
        string randomPrompt = GetRandomPrompt(_prompts);

        Console.WriteLine("List as many responses as you can to the following prompt: ");
        Console.WriteLine($"--{randomPrompt}--");
        Console.Write("You may begin in ");
        RunCountdown(5);
        Console.WriteLine("");


        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(time);
        DateTime currentTime = DateTime.Now;

        while(currentTime < futureTime) {

            Console.Write("> ");
            Console.ReadLine();
            _numberOfEntries ++;
            currentTime = DateTime.Now;
        }

        Console.WriteLine($"\nYou listed {_numberOfEntries} items!");

    }
}