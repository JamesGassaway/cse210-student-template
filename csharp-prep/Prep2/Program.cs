using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string grade = Console.ReadLine();
        int number = int.Parse(grade);
        string percent = "";
        if (number >= 90)
        {
            percent = "A";
        }
        else if (number >= 80)
        {
            percent = "B";
        }
        else if (number >= 70)
        {
            percent = "C";
        }
        else if (number >= 60)
        {
            percent = "D";
        }
        else
        {
            percent = "F";
        }
        Console.WriteLine($"Your final grade is: {percent}");
    }
}