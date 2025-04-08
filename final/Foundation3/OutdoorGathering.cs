class OutdoorGathering: Event {
    private string _weather;
    public OutdoorGathering(string weather, string title, string description, string date, string time, string address): base(title, description, date, time, address) {
        _weather = weather;
    }
    public string generateFullDetails() {
        return $"'{_title}',\n{_description}\nExpected weather: {_weather}\n{_date}, {_time}\n{_address}";
        // Title, description, date, time, address, Event type, and special info
    }
    public string generateShortDescription() {
        return $"Outdoor Gathering:\n'{_title}',\n{_date}";
        //Event type, title, date
    }
}