namespace Task3;

public class Dog
{
    string _name;
    string _breed;
    int _age;
    public Dog(string name, string breed, int age)
    {
        _name = name;
        _breed = breed;
        _age = age;
    }
    public void GetInfo()
    {
        System.Console.WriteLine($"Dog's name : {_name}");
        System.Console.WriteLine($"Dog's breed : {_breed}");
        System.Console.WriteLine($"Dog's age : {_age}");
    }
}
