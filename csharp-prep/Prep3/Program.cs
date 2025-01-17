using System;

class Program
{
    static void Main(string[] args)
    {
        string gameRunning = "yes";

        Console.Write("What is the magic number? ");

        string input = Console.ReadLine();
        int magicNumber = int.Parse(input);


        
        while (gameRunning == "yes")
        {
            Console.Write("What is your guess? ");
            input = Console.ReadLine();
            int number = int.Parse(input);
            if (number == magicNumber) {
                Console.WriteLine("You guessed it!");
                gameRunning = "no";
            }
            if (number < magicNumber) {
                Console.WriteLine("Lower");
            }
            if (number > magicNumber) {
                Console.WriteLine("Higher");
            }
        }
    }
}