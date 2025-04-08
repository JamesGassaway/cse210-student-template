class Lecture: Event {
    private string _speaker;
    private int _capacity;
    public Lecture(string speaker, int capacity, string title, string description, string date, string time, string address): base(title, description, date, time, address) {
        _speaker = speaker;
        _capacity = capacity;
    }
    public string generateFullDetails() {
        return $"'{_title}',\n{_description}\nSpeaker: {_speaker}\nCapacity: {_capacity}\n{_date}, {_time}\n{_address}";
        // Title, description, date, time, address, Event type, and special info
    }
    public string generateShortDescription() {
        return $"Lecture:\n'{_title}',\n{_date}";
        //Event type, title, date
    }
}