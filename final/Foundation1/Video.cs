class Video {
    private string _title;
    private string _author;
    private string _length;
    private List<Comment> _comments = new List<Comment>();
    public Video(string title, string author, string length) {
        _title = title;
        _author = author;
        _length = length;
    }
    public void CreateComment(string name, string text) {
        Comment comment = new Comment(name, text);
        _comments.Add(comment);
    }
    public void DisplayVideo() {
        Console.WriteLine($"{_title}, {_author}, {_length}");
        foreach (Comment comment in _comments)
        {
            comment.DisplayComment();
        }
        Console.WriteLine("");
    }
}