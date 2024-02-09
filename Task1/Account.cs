namespace Task1;

public class Account
{
    int _id;
    string _name;
    decimal _balance;
    public Account(int id, string name, decimal balence)
    {
        _id = id;
        _name = name;
        _balance = balence;
    } 
    public void TakenBalance(decimal balance)
    {
        _balance = _balance - balance;
    }
    public void AddBalance(decimal balance)
    {
        _balance = _balance + balance;
    }
    public void GetInfo()
    {
        System.Console.WriteLine("account : "+_id);
        System.Console.WriteLine("account owner : "+_name);
        System.Console.WriteLine("Balance : " +_balance);
    }
    public void Transfer(Account account1, decimal balance)
    {
        _balance=_balance-balance;
        account1.AddBalance(balance);
    }
}
