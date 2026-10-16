using System;

public class Account
{
    private static int _accountCounter = 1000;

    public string accountName     { get; set;         }
    public string? accountEmail   { get; set;         }
    public double accountSale     { get; private set; }

    public bool isActive          { get; private set; }
    public int accountNumber      { get; private set; }

    private string _accountPassword;

    public Account(string name, string password, string? email)
    {
        accountName = name.Trim();
        accountEmail = email;
        accountSale = 0;

        isActive = true;
        accountNumber = _accountCounter;

        _accountPassword = password;
        _accountCounter++;
    }

    public bool disableAccount ()
    {
        isActive = false;
        return true;
    }

    public bool enableAccount ()
    {
        isActive = true;
        return true;
    }

    public bool changeName ( string newName )
    {
        accountName = newName;
        return true;
    }

    public bool changeEmail ( string newEmail )
    {
        accountEmail = newEmail;
        return true;
    }

    public bool deposit ( double depositValue )
    {
        if (isActive && depositValue < 5000 )
        {
           accountSale += depositValue;
           return true;
        }
        return false;
    }

    public bool withdraw ( double withdrawValue)
    {
        if ( isActive && withdrawValue > 0 && accountSale - withdrawValue >= 0 )
        {
            accountSale -= withdrawValue;
            return true;
        }
        return false;
    }

    public bool pix ( Account receiver, double value )
    {
        if (isActive && receiver.isActive && value > 0 && value < 5000 && accountSale - value >= 0 )
        {
            this.withdraw(value);
            receiver.deposit(value);
            return true;
        }
        return false;
    }

    public bool checkPassword( string password)
    {
        return _accountPassword == password;
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
        Console.WriteLine($"│ IsActive: {isActive, - 22} │");
        Console.WriteLine("└──────────────────────────────────┘");
    }
}
