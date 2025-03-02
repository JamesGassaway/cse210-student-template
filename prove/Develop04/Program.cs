using System;

class Program
{
    static void Main(string[] args)
    {
        bool _isFinished =  false;
        Logger logger = new Logger();
        // Create a base "Assignment" object
        Console.WriteLine("Hello Develop04 World!");
        Menu menu = new Menu();

        while (!_isFinished) {
            Console.Clear();
            Console.WriteLine("Select a choice from the menu");
            menu.DisplayMenu();
            Console.Write("> ");
            string selection = Console.ReadLine();

            Console.Clear();
            switch (selection) {
                case "1":
                    BreathingActivity breathingActivity = new BreathingActivity();
                    logger.addCount("Breathing");
                    break;
                case "2":
                    ReflectionActivity reflectionActivity = new ReflectionActivity();
                    logger.addCount("Reflection");
                    break;
                case "3":
                    ListingActivity ListingActivity = new ListingActivity();
                    logger.addCount("Listing");
                    break;
                case "4":
                    logger.DisplayLog();
                    break;
                case "5":
                    _isFinished =  true;
                    break;
                default:
                    Console.WriteLine("That was an invalid input. Please try again.");
                    break;
            }
        }
    }
}