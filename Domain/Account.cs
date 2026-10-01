namespace Domain;

public class Account
{
    public string Name {get;set;}
    public decimal Balance {get;set;}
    public decimal Deposit(decimal amount)
    {
       return Balance += amount; 
    }
    public decimal Withdraw(decimal amount)
    {
        return Balance -= amount;
    }
    public void ToString()
    {
        Console.WriteLine($"Name: {Name}, Balance: {Balance}");
    }
}
