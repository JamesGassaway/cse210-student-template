public class Logger {
    private int _numBreathing = 0;
    private int _numReflection = 0;
    private int _numListing = 0;
    public Logger() {

    }
    public void DisplayLog() {
        Console.Clear();
        Console.WriteLine($"Number of Breathing Activities completed: {_numBreathing}");
        Console.WriteLine($"Number of Reflection Activities completed: {_numReflection}");
        Console.WriteLine($"Number of Listing Activities completed: {_numListing}");
        Console.WriteLine("Press Enter to Continue");
        Console.ReadLine();

    }
    public void addCount(string activity) {
        switch (activity) {
            case "Breathing":
                _numBreathing++;
                break;
            case "Reflection":
                _numReflection++;
                break;
            case "Listing":
                _numListing++;
                break;
        }

    }
}