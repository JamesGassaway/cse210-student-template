public class ReflectionActivity : Activity
{  
    private const string _activityName = "Reflection";
    private const string _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    List<string> _prompts = [
        "Think of a time when you stood up for someone else.",
    "Think of a time when you did something really difficult.",
    "Think of a time when you helped someone in need.",
    "Think of a time when you did something truly selfless."
    ];
    List<string> _responses = [
    "Why was this experience meaningful to you?",
    "Have you ever done anything like this before?",
    "How did you get started?",
    "How did you feel when it was complete?",
    "What made this time different than other times when you were not as successful?",
    "What is your favorite thing about this experience?",
    "What could you learn from this experience that applies to other situations?",
    "What did you learn about yourself through this experience?",
    "How can you keep this experience in mind in the future?"
    ];
    public ReflectionActivity() : base(_activityName, _description){
        StartActivity();
        DoActivity();
        EndActivity();

    }
    public void DoActivity()
    {
        
        int time = getDuration();
        string randomPrompt = GetRandomPrompt(_prompts);

        Console.WriteLine("Consider the following prompt: ");
        Console.WriteLine("");
        Console.WriteLine($"--{randomPrompt}--");
        Console.WriteLine("");
        Console.WriteLine("When you have something in mind, please press enter to continue.");
        Console.ReadLine();

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(time);
        DateTime currentTime = DateTime.Now;
        string randomResponse;

        Console.Clear();
        while(currentTime < futureTime) {
            randomResponse = GetRandomPrompt(_responses);
            Console.Write($"{randomResponse} ");
            RunAnim(10);
            Console.WriteLine();
            currentTime = DateTime.Now;
        }

    }
}