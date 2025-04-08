class Reception: Event {
    private string _rsvpEmail;
    public Reception(string rsvpEmail, string title, string description, string date, string time, string address): base(title, description, date, time, address) {
        _rsvpEmail = rsvpEmail;
    }
    public string generateFullDetails() {
        return $"'{_title}',\n{_description}\nRSVP: {_rsvpEmail}\n{_date}, {_time}\n{_address}";
        // Title, description, date, time, address, Event type, and special info
    }
    public string generateShortDescription() {
        return $"Reception:\n'{_title}',\n{_date}";
        //Event type, title, date
    }
}