using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.IO; 

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        PromptManager promptManager = new PromptManager();
        Journal journal = new Journal();
        
        bool programRunning = true;


        while (programRunning) {
            menu.Display();
            string selection = Console.ReadLine();
            Console.WriteLine("");
            Menu.options selection_int = (Menu.options)int.Parse(selection);

            if (selection_int == Menu.options.WRITE) {
                Console.WriteLine("Please enter the date for today: ");
                string date = Console.ReadLine();
                Console.WriteLine("What was your overall mood for today?: ");
                string mood = Console.ReadLine();
                string randomPrompt = promptManager.GetRandomPrompt();
                Console.WriteLine(randomPrompt);
                string text = Console.ReadLine();
                Entry entry = new Entry();
                entry._date = date;
                entry._mood = mood;
                entry._prompt = randomPrompt;
                entry._text = text;
                journal.AddEntry(entry);
            }
            if (selection_int == Menu.options.DISPLAY) {
                journal.Display();
            } 
            if (selection_int == Menu.options.LOAD) {
                Console.WriteLine("Please enter a filename: ");
                string filename = Console.ReadLine();
                journal = journal.Load(filename);
            }
            if (selection_int == Menu.options.SAVE) {
                Console.WriteLine("Please enter a filename: ");
                string filename = Console.ReadLine();
                journal.Save(filename);
            }
            if (selection_int == Menu.options.QUIT) {
                programRunning = false;
            } 
        }
    }
}

class Journal
{

    List<Entry> entries = new List<Entry>();

    public bool _changed;
    public Journal Load(string filename)
    {
        string[] lines = System.IO.File.ReadAllLines(filename);
        Journal journal = new Journal();

        foreach (string line in lines)
        {

            string[] parts = line.Split("|");

            string date = parts[0];
            string mood = parts[1];
            string prompt = parts[2];
            string text = parts[3];

            Entry entry = new Entry();
            entry._date = date;
            entry._mood = mood;
            entry._prompt = prompt;
            entry._text = text;

            
            journal.AddEntry(entry);
        }
        return journal;
    }
    public void Save(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in entries)
            {
                outputFile.WriteLine($"{entry._date}|{entry._mood}|{entry._prompt}|{entry._text}");
            }
        }
    }
    public void AddEntry(Entry entry)
    {
        entries.Add(entry);
    }
    public void Display()
    {
        for (int i = 0; i < entries.Count; i++)
        {
            Console.WriteLine("");
            Console.WriteLine(entries[i]._date);
            Console.WriteLine(entries[i]._mood);
            Console.WriteLine(entries[i]._prompt);
            Console.WriteLine(entries[i]._text);
            Console.WriteLine("");
        }
    }
}


class Entry
{
    public string _date;
    public string _mood;
    public string _prompt;
    public string _text;
    public void Display()
    {
        Console.WriteLine("Hello Develop02 World!");
    }
}


class PromptManager
{
    Random _random = new Random();
    List<string> _prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };
    public string GetRandomPrompt()
    {
        int randomIndex = _random.Next(_prompts.Count);
        string randomString = _prompts[randomIndex];
        return randomString;
    }
}


class Menu
{
    public void Display()
    {
        Console.WriteLine("Please Select one of the following choices:");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.WriteLine("What would you like to do? ");
    }

    public enum options{
        WRITE = 1,
        DISPLAY = 2,
        LOAD = 3,
        SAVE = 4,
        QUIT = 5,
    }
}