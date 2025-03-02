namespace project;

public class Account {
    private string _name;
    private int _balance;
    private float _rate;

    public Account() {
        // Defalut
        _name = "";
        _balance = 0;
        _rate = 0;
    }

    public Account(string name, int balance, float rate) {
        _name = name;
        _balance = balance;
        _rate = rate;
    }
}