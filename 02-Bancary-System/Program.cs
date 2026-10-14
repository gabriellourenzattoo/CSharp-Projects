using System;

public class Account
{
    private static int _accountCounter = 1000;

    public string accountName     { get; set;         }
    public string? accountEmail   { get; set;         }
    public double accountSale     { get; private set; }

    public bool isActive          { get; private set; }
    public int accountNumber      { get; private set; }
    public double accountLimit    { get; private set; }

    private string _accountPassword;

    public Account(string name, string password, string? email)
    {
        accountName = name.Trim();
        accountEmail = email.Trim();
        accountSale = 0;

        isActive = true;
        accountNumber = _accountCounter;
        accountLimit = 0;

        _accountPassword = password;

        _accountCounter++;
    }

    public void viewAccount()
    {
        Console.WriteLine("\n┌──────────────────────────────────┐");
        Console.WriteLine("│           Account Details        │");
        Console.WriteLine("├──────────────────────────────────┤"); //36 caracters
        Console.WriteLine($"│ Account Number: {accountNumber, -16} │");
        Console.WriteLine($"│ Name: {accountName, - 26} │");
        Console.WriteLine($"│ Email: {accountEmail ?? "Uninformed", - 25} │");
        Console.WriteLine($"│ Sale: {accountSale, -26:c} │");
        Console.WriteLine($"│ Limit: {accountLimit, - 25:c} │");
        Console.WriteLine($"│ IsActive: {isActive, - 22} │");
        Console.WriteLine("└──────────────────────────────────┘");

    }

    public bool deposit(double depositValue)
    {
        Console.Clear();
        if (depositValue < 5000)
        {
           accountSale += depositValue;
           return true;
        }
        return false;
    }
    
    public bool withdraw( double withdrawValue)
    {
        Console.Clear();
        if (withdrawValue > 0 && (accountSale + accountLimit)- withdrawValue >= 0)
        {
            accountSale -= withdrawValue;
            return true;
        }
        return false;
    }
}

public class Program
{
    public static void Main()
    {
        var arthur = new Account("arthut", "senha123", "Arthurlindao@gmail.com");
        arthur.viewAccount();

        
    }
}
