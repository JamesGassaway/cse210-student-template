class Event {
    protected string _title;
    protected string _description;
    protected string _date;
    protected string _time;
    protected string _address;
    public Event(string title, string description, string date, string time, string address) {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;

    }
    public string generateStandardDetails() {
        return $"'{_title}',\n {_description}\n{_date}\n{_time}\n{_address}";
        //Title, description, date, time, and address
    }
    
}