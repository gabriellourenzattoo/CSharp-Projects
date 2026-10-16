using System;

namespace visual;

public class Program
{
    private List<Account> accounts = new ();

    public static void Main()
    {
        Program programa = new Program();
        programa.display(); 
    }

    public void display ()
    {
        while (true){
            Console.Clear();
            Console.WriteLine("\n┌──────────────────────────────────┐ ");
            Console.WriteLine(  "│              Main Menu           │ ");
            Console.WriteLine(  "├──────────────────────────────────┤ ");
            Console.WriteLine(  "│ 1. Login.                        │ ");
            Console.WriteLine(  "│ 2. Register.                     │ ");
            Console.WriteLine(  "│ 3. Exit.                         │ ");
            Console.WriteLine(  "├──────────────────────────────────┤ ");
            Console.Write    (  "│ Enter your choice: ");
            int choice = int.Parse(Console.ReadLine() ?? "0");
            switch (choice)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("\n┌──────────────────────────────────┐ ");
                    Console.WriteLine(  "│                Login             │ ");
                    Console.WriteLine(  "├──────────────────────────────────┤ ");
                    Console.Write("│ Enter your name: ");
                    string loginName = Console.ReadLine() ?? "";
                    var account = findAccount(loginName);
                    if (account != null)
                    {
                        Console.Write("│ Enter your password: ");
                        string loginPassword = Console.ReadLine() ?? "";
                        if (login(account, loginPassword))
                        {
                            logged(account);
                            break;   
                        }
                    
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("\n┌──────────────────────────────────┐ ");
                            Console.WriteLine(  "│          Incorrect Password      │ ");
                            Console.WriteLine(  "└──────────────────────────────────┘ ");
                            Console.ReadKey();
                            break;
                        }
                    }else
                    {
                            Console.Clear();
                            Console.WriteLine("\n┌──────────────────────────────────┐ ");
                            Console.WriteLine(  "│         Account not found.       │ ");
                            Console.WriteLine(  "└──────────────────────────────────┘ ");
                            Console.ReadKey();
                            break;
                    }
                    

                case 2:
                    Console.Clear();
                    Console.WriteLine("\n┌──────────────────────────────────┐ ");
                    Console.WriteLine(  "│              Register...         │ ");
                    Console.WriteLine(  "└──────────────────────────────────┘ ");
                    string registerName;
                    string registerPassword;
                    do
                    {
                        Console.Write    (  "│ Enter Name of Your Account: ");
                        registerName = Console.ReadLine() ?? "";
                    } while ( string.IsNullOrWhiteSpace( registerName ) || findAccount( registerName ) != null );
                    do
                    {
                        Console.Write( "│ Enter Your Password: ");
                        registerPassword = Console.ReadLine() ?? "";
                    } while ( string.IsNullOrWhiteSpace( registerPassword ) );
                    Console.Write("│ Enter Your email: ");
                    string registerEmail = Console.ReadLine() ?? "";

                    register(registerName, registerPassword, registerEmail);
                    Console.Clear();
                    Console.WriteLine("\n┌──────────────────────────────────┐ ");
                    Console.WriteLine(  "│     Successfully Registered      │ ");
                    Console.WriteLine(  "└──────────────────────────────────┘ ");
                    Console.ReadKey();
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("\n┌──────────────────────────────────┐ ");
                    Console.WriteLine(  "│              Exiting...          │ ");
                    Console.WriteLine(  "└──────────────────────────────────┘ ");
                    return;

                default:
                    Console.Clear();
                    Console.WriteLine("\n┌──────────────────────────────────┐ ");
                    Console.WriteLine(  "|         Option not Found.        |" );
                    Console.WriteLine(  "└──────────────────────────────────┘ ");
                    Console.ReadKey();
                    break;

            }
        }
    }

    public void register ( string name, string password, string? email )
    {
            var newAccount = new Account(name, password, email);
            accounts.Add(newAccount);
    }

    public bool login ( Account account, string password)
    {
        return account.checkPassword(password);
    }

    public Account? findAccount(string name)
    {
     foreach (Account account in accounts)
        {
            if (account.accountName == name.Trim())
            {
                return account;
            }
        }   
        return null;
    }
    public void logged(Account account)
    {
        while (true){
            Console.Clear();
            Console.WriteLine("\n┌──────────────────────────────────┐ ");
            Console.WriteLine(  $"│ Hello, {account.accountName, - 12 } │ {account.accountSale, -10 :C} │ ");
            Console.WriteLine(  "├──────────────────────────────────┤ ");
            Console.WriteLine(  "│ 1. Deposit.                      │ ");
            Console.WriteLine(  "│ 2. WithDraw.                     │ ");
            Console.WriteLine(  "│ 3. Pix.                          │ ");
            Console.WriteLine(  "│ 4. Change Info.                  │ ");
            Console.WriteLine(  "│ 5. Enable/Disable Account.       │ ");
            Console.WriteLine(  "│ 6. View Account Info.            │ ");
            Console.WriteLine(  "│ 7. Exit.                         │ ");
            Console.WriteLine(  "├──────────────────────────────────┤ ");
            Console.Write    (  "│ Enter your choice: ");
            int choice = int.Parse(Console.ReadLine() ?? "");
            switch (choice)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("\n┌──────────────────────────────────┐ ");
                    Console.WriteLine(  "|             Deposit.             |" );
                    Console.WriteLine(  "├──────────────────────────────────┘ ");
                    Console.Write("│ Enter the value of deposit: ");
                    int valueDeposit = int.Parse(Console.ReadLine() ?? "");
                    Console.Clear();
                    if (account.deposit(valueDeposit))
                    {
                        Console.WriteLine("\n┌──────────────────────────────────┐ ");
                        Console.WriteLine(  "│     Successfully Deposit.        │ ");
                        Console.WriteLine(  "└──────────────────────────────────┘ ");
                    }
                    else
                    {
                        Console.WriteLine("\n┌──────────────────────────────────┐ ");
                        Console.WriteLine(  "│     Deposit Unsuccessful.        │ ");
                        Console.WriteLine(  "└──────────────────────────────────┘ ");
                    }

                    Console.ReadKey();
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("\n┌──────────────────────────────────┐ ");
                    Console.WriteLine(  "|             Withdraw.            |" );
                    Console.WriteLine(  "├──────────────────────────────────┘ ");
                    Console.Write("│ Enter the value of withdraw: ");
                    int valueWithdraw = int.Parse(Console.ReadLine() ?? "");
                    Console.Clear();
                    if (account.withdraw(valueWithdraw))
                    {
                        Console.WriteLine("\n┌──────────────────────────────────┐ ");
                        Console.WriteLine(  "│     Successfully Withdraw.       │ ");
                        Console.WriteLine(  "└──────────────────────────────────┘ ");
                    }
                    else
                    {
                        Console.WriteLine("\n┌──────────────────────────────────┐ ");
                        Console.WriteLine(  "│       Insufficient balance.      │");
                        Console.WriteLine(  "└──────────────────────────────────┘ ");
                    }

                    Console.ReadKey();
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("\n┌──────────────────────────────────┐ ");
                    Console.WriteLine(  "|                 PIX.             |" );
                    Console.WriteLine(  "├──────────────────────────────────┘ ");
                    Console.Write("│ Enter the value of pix: ");
                    int valuePix = int.Parse(Console.ReadLine() ?? "");
                    Console.Write("│ Enter the account of pix: ");
                    string nameAccountPix = Console.ReadLine() ?? "";
                    Account? accountPix = findAccount(nameAccountPix);
                    Console.Clear();
                    if (accountPix != null)
                    {
                        if (account.pix(accountPix,valuePix) )
                        {
                            Console.WriteLine("\n┌──────────────────────────────────┐ ");
                            Console.WriteLine(  "│       Successfully PIX.          │ ");
                            Console.WriteLine(  "└──────────────────────────────────┘ ");
                        }
                        else
                        {
                            Console.WriteLine("\n┌──────────────────────────────────┐ ");
                            Console.WriteLine(  "│       Insufficient balance.      │");
                            Console.WriteLine(  "└──────────────────────────────────┘ ");
                        }
                    }
                    else
                    {
                            Console.WriteLine("\n┌──────────────────────────────────┐ ");
                            Console.WriteLine(  "│       Account not found.         │");
                            Console.WriteLine(  "└──────────────────────────────────┘ ");
                    }
                    Console.ReadKey();
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("\n┌──────────────────────────────────┐ ");
                    Console.WriteLine(  "|             Change info.         | " );
                    Console.WriteLine(  "├──────────────────────────────────┘ ");
                    Console.WriteLine(  "│ 1. Name.                         | ");
                    Console.WriteLine(  "| 2. Email.                        | ");
                    Console.WriteLine(  "├──────────────────────────────────┤ ");
                    Console.Write(  "| Enter your coice: ");
                    int choiceChange = int.Parse(Console.ReadLine() ?? "");
                    switch (choiceChange)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine("\n┌──────────────────────────────────┐ ");
                            Console.WriteLine(  "│            Change Name.          │ ");
                            Console.WriteLine(  "├──────────────────────────────────┤ ");
                            Console.Write(" │ Enter to new name: ");
                            string newName = Console.ReadLine() ?? "";
                            if (account.changeName(newName))
                            {
                                Console.Clear();
                                Console.WriteLine("\n┌──────────────────────────────────┐ ");
                                Console.WriteLine(  "│    Change Name Successfully.     │ ");
                                Console.WriteLine(  "├──────────────────────────────────┤ ");
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("\n┌──────────────────────────────────┐ ");
                                Console.WriteLine(  "│  Change Name  Not Successfully.  │ ");
                                Console.WriteLine(  "├──────────────────────────────────┤ ");
                            }
                            Console.ReadKey();
                            break;
                        case 2:
                            Console.Clear();
                            Console.WriteLine("\n┌──────────────────────────────────┐ ");
                            Console.WriteLine(  "│            Change Email.         │ ");
                            Console.WriteLine(  "├──────────────────────────────────┤ ");
                            Console.Write(" │ Enter to new name: ");
                            string newEmail = Console.ReadLine() ?? "";
                            if (account.changeName(newEmail))
                            {
                                Console.Clear();
                                Console.WriteLine("\n┌──────────────────────────────────┐ ");
                                Console.WriteLine(  "│    Change Email Successfully.    │ ");
                                Console.WriteLine(  "├──────────────────────────────────┤ ");
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("\n┌──────────────────────────────────┐ ");
                                Console.WriteLine(  "│  Change Email Not Successfully.  │ ");
                                Console.WriteLine(  "├──────────────────────────────────┤ ");
                            }
                            Console.ReadKey();

                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("\n┌──────────────────────────────────┐ ");
                            Console.WriteLine(  "|         Option not Found.        |" );
                            Console.WriteLine(  "└──────────────────────────────────┘ ");
                            Console.ReadKey();
                            break;
                    }
                    break;
                case 5:
                    if (account.isActive)
                    {
                            Console.Clear();
                            account.disableAccount();
                            Console.WriteLine("\n┌──────────────────────────────────┐ ");
                            Console.WriteLine(  "|        Account Deactivated       |" );
                            Console.WriteLine(  "└──────────────────────────────────┘ ");
                            Console.ReadKey();
                    }
                    else
                    {
                            Console.Clear();
                            account.enableAccount();
                            Console.WriteLine("\n┌──────────────────────────────────┐ ");
                            Console.WriteLine(  "|          Account Enable.         |" );
                            Console.WriteLine(  "└──────────────────────────────────┘ ");
                            Console.ReadKey();
                    }
                    break;
                case 6:
                    account.viewAccount();
                    Console.ReadKey();
                    break;
                case 7:
                    Console.Clear();
                    Console.WriteLine("\n┌──────────────────────────────────┐ ");
                    Console.WriteLine(  "│              Exiting...          │ ");
                    Console.WriteLine(  "└──────────────────────────────────┘ ");
                    return;
                default:
                        Console.Clear();
                        Console.WriteLine("\n┌──────────────────────────────────┐ ");
                        Console.WriteLine(  "|         Option not Found.        |" );
                        Console.WriteLine(  "└──────────────────────────────────┘ ");
                        Console.ReadKey();
                        break;
            }
        }
    }
}