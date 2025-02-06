public class Fraction {

    private int _top = 0;
    private int _bottom = 0;


    // Method to return job information as a formatted string
    public Fraction()
    {
        // Default to 1/1
        _top = 1;
        _bottom = 1;
    }
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }
    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }
    public double GetDecimalString()
    {
        return (double)_top/(double)_bottom;
    }
}