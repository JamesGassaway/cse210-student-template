using System;

class Program
{
    private Lecture lecture = new Lecture("Matt Foley", 4, "A Van Down by the River", "Matt Foley will give his legendary motivational speech about living in a van down by the river.", "5/9/2024", "2 PM", "167 Fake Rd");
    private Reception reception = new Reception("1234kermitthefrog@nomail.com", "Kermit and Miss Piggy's Wedding", "Marriage of Kermit the Frog and Miss Piggy", "Sept 7th, 2026", "13 PM", "834 Chapel Ln.");
    private OutdoorGathering outdoorGathering = new OutdoorGathering("Cloudy", "Coldplay Concert", "Coldplay presents: Yellow", "5/6/2025", "8 PM", "1441 Rock and Roll Ave.");
    static void Main(string[] args)
    {
        Program program = new Program();
        program.GenerateMessages();
    }
    public void GenerateMessages() {
        Console.WriteLine(lecture.generateStandardDetails()+"\n");
        Console.WriteLine(reception.generateStandardDetails()+"\n");
        Console.WriteLine(outdoorGathering.generateStandardDetails()+"\n");

        Console.WriteLine(lecture.generateFullDetails()+"\n");
        Console.WriteLine(reception.generateFullDetails()+"\n");
        Console.WriteLine(outdoorGathering.generateFullDetails()+"\n");

        Console.WriteLine(lecture.generateShortDescription()+"\n");
        Console.WriteLine(reception.generateShortDescription()+"\n");
        Console.WriteLine(outdoorGathering.generateShortDescription()+"\n");
    }

}