using System;
using System.Net.Mail;

namespace Library
{
    class Program
    {
        public static List<Account> Accounts = new();
        public static void Main()
        {
            Display();
        }

        public static void Display()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("\n┌───────────────────────────────────────────┐"  ); //45 Caracters
                Console.WriteLine(  "│                Main Menu                  │"  );
                Console.WriteLine(  "├───────────────────────────────────────────┤"  );
                Console.WriteLine(  "│ [1]. Login                                │"  );
                Console.WriteLine(  "│ [2]. Register.                            │"  );
                Console.WriteLine(  "│ [3]. Exit.                                │"  );
                Console.WriteLine(  "├───────────────────────────────────────────┤"  );
                Console.Write    (  "│ Enter your choice: ");
                int choice = int.Parse(Console.ReadLine() ?? "");
                switch (choice)
                {
                    case 1:
                    case 2:
                        Register();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("\n┌───────────────────────────────────────────┐"  ); //45 Caracters
                        Console.WriteLine(  "│                     Exit.                 │"  );
                        Console.WriteLine(  "└───────────────────────────────────────────┘"  );
                        Console.ReadKey();
                        return;
                    default:
                        Console.Clear();
                        Console.WriteLine("\n┌───────────────────────────────────────────┐"  ); //45 Caracters
                        Console.WriteLine(  "│              Option Not Found             │"  );
                        Console.WriteLine(  "└───────────────────────────────────────────┘"  );
                        Console.ReadKey();
                        break;
                }
            }
        }

        public Account? FindAccount(string NameOrId)
        {
            foreach( Account account in Accounts)
            {
                if (account.Name == NameOrId || account.Id == NameOrId)
                {
                return account;
                }
            }
            return null;
        }

        public static void Register()
        {
            Console.Clear();
            Console.WriteLine("\n┌───────────────────────────────────────────┐"  ); //45 Caracters
            Console.WriteLine(  "│                  Register.                │"  );
            Console.WriteLine(  "├───────────────────────────────────────────┤"  );
            string NameRegister = GetCorrectName();
            string EmailRegister = GetCorrectEmail();
            Account NewAccount = new Account(NameRegister, EmailRegister);
            Accounts.Add(NewAccount);
            Console.ReadKey();
        }

        public static string GetCorrectName()
        {
            while (true)
            {
                Console.Write(  "\n│ Enter your name: ");
                string Name = Console.ReadLine() ?? "";
                if (string.IsNullOrWhiteSpace(Name))
                {
                    Console.WriteLine(  "┌───────────────────────────────────────────┐"  ); //45 Caracters
                    Console.WriteLine(  "│  The name field cannot be null or empty.  │"  );
                    Console.WriteLine(  "└───────────────────────────────────────────┘"  );
                    continue;
                }
                else if (Name.Length > 20)
                {
                    Console.WriteLine(  "┌───────────────────────────────────────────┐"  ); //45 Caracters
                    Console.WriteLine(  "│   The name field cannot exceed 20 char.   │"  );
                    Console.WriteLine(  "└───────────────────────────────────────────┘"  );
                    continue;
                }
                else if (Name.Length < 3)
                {
                    Console.WriteLine(  "┌───────────────────────────────────────────┐"  ); //45 Caracters
                    Console.WriteLine(  "│The name field cannot be shorter than 3 cha│"  );
                    Console.WriteLine(  "└───────────────────────────────────────────┘"  );   
                    continue;
                }
                else if(Name.All(char.IsDigit))
                {
                    Console.WriteLine(  "┌───────────────────────────────────────────┐"    ); //45 Caracters
                    Console.WriteLine(  "│The name field cannot contain only numbers.│"    );
                    Console.WriteLine(  "└───────────────────────────────────────────┘"    );   
                    continue;
                }
                else
                {
                    Console.WriteLine(  "┌───────────────────────────────────────────┐"  ); //45 Caracters
                    Console.WriteLine(  "│                 Valid Name.               │"  );
                    Console.WriteLine(  "└───────────────────────────────────────────┘"  );
                    return Name;
                }
            }
        }

        public static string GetCorrectEmail()
        {
            while (true)
            {
                Console.Write(  "\n│ Enter your email: ");
                string Email = Console.ReadLine() ?? "";
                if (string.IsNullOrWhiteSpace(Email))
                {
                    Console.WriteLine(  "┌───────────────────────────────────────────┐"  ); //45 Caracters
                    Console.WriteLine(  "│  The email field cannot be null or empty. │"  );
                    Console.WriteLine(  "└───────────────────────────────────────────┘"  );
                    continue;
                }
                else if(Email.Length < 3)
                {
                    Console.WriteLine(  "┌───────────────────────────────────────────┐"  ); //45 Caracters
                    Console.WriteLine(  "│The email field cannot be shorter than 3 ch│"  );
                    Console.WriteLine(  "└───────────────────────────────────────────┘"  );
                    continue;
                }
                else if(Email.All(char.IsDigit))
                {
                    Console.WriteLine(  "┌───────────────────────────────────────────┐"    ); //45 Caracters
                    Console.WriteLine(  "│The email field cannot contain only numbers│"    );
                    Console.WriteLine(  "└───────────────────────────────────────────┘"    );
                    continue;   
                }
                else if(!MailAddress.TryCreate(Email, out _))
                {
                    Console.WriteLine(  "┌───────────────────────────────────────────┐"    ); //45 Caracters
                    Console.WriteLine(  "│   The email field must be a valid email.  │"    );
                    Console.WriteLine(  "└───────────────────────────────────────────┘"    );     
                    continue;
                }
                else
                {
                    Console.WriteLine(  "┌───────────────────────────────────────────┐"  ); //45 Caracters
                    Console.WriteLine(  "│                Valid Email.               │"  );
                    Console.WriteLine(  "└───────────────────────────────────────────┘"  );
                    return Email;
                }
            }
        }
    }
}
// ┌─┐
// │ │    
// └─┘
