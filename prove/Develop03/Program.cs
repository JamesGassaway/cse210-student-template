using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

class Program
{
    List<Scripture> scriptures = new List<Scripture>();
    static void Main(string[] args)
    {
        Program program = new Program(); // Create an instance
        program.MainLoop();
    }

    public bool IsFinished()
    {
        for (int i = 0; i < scriptures.Count; i++) {
            if (!scriptures[i].IsFinished()) {
                return false;
            }
        }
        return true;
    }
    public void HideWords()
    {
        for (int i = 0; i < scriptures.Count; i++) {
            scriptures[i].HideWord();
        }
    }
    public void MainLoop()
    {
        Scripture scripture = new Scripture();
        scriptures.Add(scripture);
        Console.WriteLine(scriptures.Count);
        string response;
        bool running = true;
        while (running) {
            scriptures[0].DisplayAll();
            response = Console.ReadLine();
            if (response == "quit" || IsFinished()) {
                running = false;
            }
            else {
                scriptures[0].HideWord();
            }
        }
    }
}

class Scripture
{
    List<Verse> verses = new List<Verse>();
    Random _random = new Random();
    List<string> _sampleVerses = new List<string>
    {
        "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.",
        "Adam fell that men might be; and men are, that they might have joy.",
        "Angels speak by the power of the Holy Ghost; wherefore, they speak the words of Christ. Wherefore, I said unto you, feast upon the words of Christ; for behold, the words of Christ will tell you all things what ye should do.",
        "For the natural man is an enemy to God, and has been from the fall of Adam, and will be, forever and ever, unless he yields to the enticings of the Holy Spirit, and putteth off the natural man and becometh a saint through the atonement of Christ the Lord, and becometh as a child, submissive, meek, humble, patient, full of love, willing to submit to all things which the Lord seeth fit to inflict upon him, even as a child doth submit to his father.",
        "O, remember, my son, and learn wisdom in thy youth; yea, learn in thy youth to keep the commandments of God."
    };
    List<string> _sampleReferences = new List<string>
    {
        "1 Nephi 3:7",
        "2 Nephi 2:25",
        "2 Nephi 32:3",
        "Mosiah 3:19",
        "Alma 37:35"
    };
    private string _reference = "";
    public Scripture()
    {
        int randomIndex = _random.Next(_sampleVerses.Count);
        string randomString = _sampleVerses[randomIndex];
        Verse verse = new Verse(randomString);
        _reference = _sampleReferences[randomIndex];
        verses.Add(verse);
    }
    public bool IsFinished()
    {
        for (int i = 0; i < verses.Count; i++) {
            if (!verses[i].IsFinished()) {
                return false;
            }
        }
        return true;
    }
    public void DisplayAll()
    {
        Console.Clear();
        Console.Write(_reference+": ");
        for (int i = 0; i < verses.Count; i++) {
            verses[i].DisplayVerse();
        }
    }
    public void HideWord()
    {
        for (int i = 0; i < verses.Count; i++) {
            verses[i].HideWord();
        }
    }
}

class Verse
{
    Random _random = new Random();
    private List<Word> words = new List<Word>();

    public Verse(string verse)
    {
        string _sampleWord = "";

        for (int i = 0; i < verse.Length; i++) {
            if (verse[i] != ' ') {
                _sampleWord += verse[i];
            }
            else {
                Word _addWord = new Word(_sampleWord);
                words.Add(_addWord);
                _sampleWord = "";
            }
            
        }
        Word _lastWord = new Word(_sampleWord);
        words.Add(_lastWord);
    }
    public void DisplayVerse()
    {

        for (int i = 0; i < words.Count; i++) {
            Console.Write(words[i].DisplayWord()+' ');
        }
        Console.WriteLine("");
        Console.WriteLine("Press enter to continue or type 'quit' to finish.");
    }
    public bool IsFinished()
    {
        for (int i = 0; i < words.Count; i++) {
            if (!words[i].IsHidden()) {
                return false;
            }
        }
        return true;
    }
    public void HideWord()
    {
        int hiddenWords = 0;
        while (hiddenWords < 3) {
            int randomIndex = _random.Next(words.Count);
            Word randomWord = words[randomIndex];
            if (randomWord.IsHidden() == false) {
                randomWord.HideWord();
                if (IsFinished()) {
                    hiddenWords = 3;
                }
                else {
                    hiddenWords++;
                }
            }
        }
    }
}

class Word
{
    private string _word;
    private bool _hidden;
    public Word(string _sampleWord)
    {
        _word = _sampleWord;  
    }
    public string DisplayWord()
    {
        return _word;
    }
    public bool IsHidden()
    {
        return _hidden;
    }
    public void HideWord()
    {
        _word = new string('-', _word.Length);
        _hidden = true;
    }
}