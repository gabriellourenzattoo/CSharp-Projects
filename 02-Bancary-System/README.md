<p align="center">
  <img src="https://capsule-render.vercel.app/api?type=waving&color=0:0D1B2A,35:512BD4,100:9B4F96&height=200&section=header&text=Visual%20Bank&fontSize=55&fontColor=ffffff&animation=fadeIn&fontAlignY=35&desc=A%20CLI%20Banking%20System%20in%20C%23&descAlignY=60&descSize=16" width="100%" />
</p>

<p align="left">
  <img src="https://img.shields.io/badge/C%23-239120?style=flat-square&logo=csharp&logoColor=white" />
  <img src="https://img.shields.io/badge/.NET-512BD4?style=flat-square&logo=dotnet&logoColor=white" />
  <img src="https://img.shields.io/badge/Interface-CLI-informational?style=flat-square" />
  <img src="https://img.shields.io/badge/Status-Active-brightgreen?style=flat-square" />
</p>

A terminal-based **banking simulator** built in C#, developed as a hands-on exercise in object-oriented programming. It stores accounts in memory and lets the user register, log in, and manage money through interactive menus — all through a simple command-line interface.

---

## 🔎 Overview

`Visual Bank` is a small project designed to practice the core mechanics of the language: classes and encapsulation, collections, control flow, console input and output, and basic validation rules.

The program is built around two pieces:

- **`Program`** — draws the menus, reads the user's input and routes each choice to its action
- **`Account`** — holds the account data and enforces the business rules (balance, limits, active status)
- **`List<Account>`** — keeps every registered account while the program is running

---

## ✨ Features

**Main menu**

- 🔐 Log in with name and password
- 📝 Register a new account (unique name, password and optional email)
- 🚪 Exit

**Account menu (after login)**

- 💰 Deposit
- 💸 Withdraw
- ⚡ PIX transfer to another account
- ✏️ Change name and email
- 🔄 Enable / disable the account
- 📄 View account details
- 🔁 Menus that keep running until the user exits
- 🖥️ Formatted, box-style terminal output

---

## 📏 Business Rules

- Account names are unique and cannot be empty
- Each account receives an automatic number, starting at `1000`
- Deposits and PIX transfers are limited to values below `5000`
- Withdrawals and PIX transfers require a positive value and enough balance
- Disabled accounts cannot deposit, withdraw, or send/receive PIX

---

## 🧠 C# Concepts Applied

- Classes, constructors and properties (`get` / `private set`)
- Encapsulation with a private password field
- `static` field used as an account counter
- `List<T>` collection
- `while` and `do...while` loops
- `foreach` loop
- `switch` statement (nested menus)
- `if` / `else` conditionals
- Nullable reference types (`string?`, `Account?`)
- Null-coalescing operator (`??`)
- `Console.ReadLine()` and `Console.WriteLine()`
- String interpolation with alignment and currency format (`{value,-10:C}`)
- `int.Parse` for converting input

---

## 🛠️ Technologies

- **C# / .NET** — no external dependencies, base class library only
- **CLI** — runs and is fully operated through the terminal

---

## 🗂️ Project Structure

```
visual/
├── Program.cs
├── Account.cs
├── BancarySystem.csproj
└── README.md
```

`Program.cs` contains the menu loops and account lookup (`display`, `logged`, `register`, `login`, `findAccount`). `Account.cs` contains the `Account` class and its operations (`deposit`, `withdraw`, `pix`, `changeName`, `changeEmail`, `viewAccount`).

---

## ▶️ How to Run

```bash
# From the project folder
dotnet run
```

> Requires the [.NET SDK](https://dotnet.microsoft.com/download) 6 or newer. No external libraries needed.

If the box characters (`┌ ─ │ └`) look broken in the Windows terminal, add this line at the start of `Main`:

```csharp
Console.OutputEncoding = System.Text.Encoding.UTF8;
```

---

## 💻 Example Usage

```
┌──────────────────────────────────┐
│              Main Menu           │
├──────────────────────────────────┤
│ 1. Login.                        │
│ 2. Register.                     │
│ 3. Exit.                         │
├──────────────────────────────────┤
│ Enter your choice: 2

┌──────────────────────────────────┐
│              Register...         │
└──────────────────────────────────┘
│ Enter Name of Your Account: Alice
│ Enter Your Password: ****
│ Enter Your email: alice@mail.com

┌──────────────────────────────────┐
│     Successfully Registered      │
└──────────────────────────────────┘

Enter your choice: 1   (Login as Alice)

┌──────────────────────────────────┐
│ Hello, Alice        │ R$ 0,00    │
├──────────────────────────────────┤
│ 1. Deposit.                      │
│ 2. WithDraw.                     │
│ 3. Pix.                          │
│ 4. Change Info.                  │
│ 5. Enable/Disable Account.       │
│ 6. View Account Info.            │
│ 7. Exit.                         │
├──────────────────────────────────┤
│ Enter your choice: 1
│ Enter the value of deposit: 1000

┌──────────────────────────────────┐
│     Successfully Deposit.        │
└──────────────────────────────────┘
```

> This is a representative example of the current CLI flow — exact menu wording and spacing may vary slightly depending on the version of the code.

---

## ⚠️ Known Limitations

- Data lives only in memory and is lost when the program closes
- Passwords are stored in plain text (fine for study, not for real systems)
- Balance uses `double`; `decimal` is the right type for money
- Invalid numeric input (letters or an empty Enter) can crash the program because of `int.Parse`

---

## 🚧 Future Improvements

- [ ] Switch the balance and operations from `double` to `decimal`
- [ ] Input validation with `int.TryParse` and `decimal.TryParse`
- [ ] Reject negative deposits
- [ ] Block PIX to the same account and refund the withdrawal if the deposit fails
- [ ] Validate `changeName` (no empty or duplicated names, always `Trim()`)
- [ ] Case-insensitive account lookup
- [ ] Hash passwords (BCrypt or PBKDF2)
- [ ] Data persistence (saving accounts between sessions, e.g. to a file)
- [ ] Extract a reusable method to draw the menu boxes
- [ ] Rename members to PascalCase (`AccountName`, `Deposit`, `Withdraw`...)

---

## 🎯 Learning Goals

- Model real-world entities with classes, properties and encapsulation
- Keep business rules inside the class that owns the data
- Handle `null` safely with nullable reference types
- Build interactive, menu-driven console applications
- Spot and fix common logic bugs (inverted conditions, duplicated calls, unvalidated input)
