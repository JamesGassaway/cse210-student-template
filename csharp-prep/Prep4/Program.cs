using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        List<int> numbers;
        numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        string input = "";
        bool sentinel = true;

        while (sentinel) {
            Console.Write("Enter number: ");
            input = Console.ReadLine();
            int number = int.Parse(input);
            if (number != 0){
                numbers.Add(number);
            }
            else {
                sentinel = false;
            }
        }
        float average = 0;
        int sum = 0;
        int largest = numbers[0];

        foreach (int value in numbers)
        {
            sum += value;
            if (largest < value)
            {
                largest = value;
            }
        }
        average = sum/numbers.Count;

        Console.WriteLine($"The sum is: {sum}.");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");
    }
}