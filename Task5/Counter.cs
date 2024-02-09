namespace Task5;

public class Counter
{
    int _value;
    public Counter(int value)
    {
        _value=value;
    }
    public void Decrement()
    {
        if(_value>0)_value--;
        else return;
    }
    public void Reset()
    {
        _value=0;
    }
    public void PrintValue()
    {
        System.Console.WriteLine($"Counter value : {_value}");
    }
}
