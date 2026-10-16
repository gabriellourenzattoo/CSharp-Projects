<p align="center">
  <img src="https://capsule-render.vercel.app/api?type=waving&color=0:0D1B2A,35:512BD4,100:9B4F96&height=220&section=header&text=C%23%20Projects&fontSize=50&fontColor=ffffff&animation=fadeIn&fontAlignY=35&desc=Learning%20C%23%20%E2%80%94%20Learning%20by%20Building&descAlignY=60&descSize=16" width="100%" />
</p>

<p align="left">
  <img src="https://img.shields.io/badge/C%23-239120?style=flat-square&logo=csharp&logoColor=white" />
  <img src="https://img.shields.io/badge/.NET-512BD4?style=flat-square&logo=dotnet&logoColor=white" />
  <img src="https://img.shields.io/badge/Type-CLI-blueviolet?style=flat-square" />
  <img src="https://img.shields.io/badge/Status-In%20Progress-yellow?style=flat-square" />
</p>

A collection of **C#** projects built as part of a hands-on learning journey — starting with small, focused console applications and gradually increasing in complexity and scope.

---

## 🎯 Objective

The goal of this repository is to **learn C# and the .NET ecosystem through practice**, rather than theory alone. Each project here is a step forward — a new concept applied, a new problem solved, and a new layer of complexity added compared to the last.

This is a living repository: it grows as my understanding of C# and software design grows with it.

---

## 🛠️ Technologies

- **C#** — core language for all projects
- **.NET 8 SDK** — runtime and build tooling
- **CLI (Command Line Interface)** — current projects run and are interacted with via terminal
- No external dependencies at this stage — pure C#, base class library only

---

## 📚 Concepts Being Studied

- Variables and data types
- Console input and output (`Console.ReadLine`, `Console.WriteLine`)
- Control flow (`if`/`else`, `while`, `do...while`, `foreach`)
- `switch` statements
- Collections (`List<T>`)
- String manipulation and interpolation
- Null handling (`??` operator and nullable reference types)
- Input parsing and validation
- Methods and code organization
- Classes, objects and properties
- Encapsulation (private fields, `private set`)
- Business rules inside classes
- C# best practices and naming conventions

---

## 📁 Projects

| Project | Description | Status |
|---|---|---|
| [**01 — To-Do List**](./01-todo-list) | A terminal-based (CLI) task manager, built to practice loops, `switch` menus, collections, and console input handling. | ✅ Available |
| [**02 — Bancary System**](./02-Bancary-System) | A terminal-based banking system, built to practice classes, encapsulation, nullable types, and business rules. | ✅ Available |

### 🔹 To-Do List

A command-line to-do list where users can view, add, and remove tasks through an interactive menu. Tasks are stored in a `List<string>` and the program keeps running until the user chooses to exit. This is the first project of the repository and the foundation for the C# concepts explored here.

➡️ [View project](./01-todo-list)

### 🔹 Bancary System

A command-line banking simulator where users can register an account, log in, and manage their money through interactive menus: deposit, withdraw, send a PIX transfer, change their info, enable or disable the account, and view the account details. Accounts are stored in a `List<Account>`, and the `Account` class enforces the business rules (balance, limits, active status). This is the first project of the repository built around classes and objects.

➡️ [View project](./02-Bancary-System)

---

## 📈 Study Progress

| Concept | Status |
|---|---|
| Variables and data types | ✅ In use |
| Console I/O | ✅ In use |
| Control flow | ✅ In use |
| `switch` statements | ✅ In use |
| Collections (`List<T>`) | ✅ In use |
| String interpolation | ✅ In use |
| Methods | ✅ In use |
| Classes and objects | ✅ In use |
| Encapsulation | ✅ In use |
| Nullable reference types | 🟡 In progress |
| Input validation | 🟡 In progress |
| File persistence | ⬜ Planned |

---

## 🗂️ Repository Structure

```
CSharp-Projects/
├── 01-todo-list/
│   ├── Program.cs
│   ├── TodoList.csproj
│   └── README.md
├── 02-visual-bank/
│   ├── Program.cs
│   ├── Account.cs
│   ├── BancarySystem.csproj
│   └── README.md
└── README.md
```

Each project lives in its own numbered folder, with its own `README.md` explaining what it does, the concepts it covers, and how to run it.

---

## 🧭 Roadmap / Next Projects

- [x] **01 — To-Do List**: CLI task manager
- [x] **02 — Visual Bank**: CLI banking system
- [ ] Next projects coming soon

> New projects are added incrementally as new C# concepts are studied and applied.

---

## ▶️ How to Run the Projects

Each project is self-contained inside its own folder. To run one:

```bash
# Clone the repository
git clone https://github.com/gabriellourenzattoo/CSharp-Projects

# Navigate into the desired project
cd CSharp-Projects/01-todo-list    # or 02-visual-bank

# Run it with the .NET CLI
dotnet run
```

> Requires the [.NET 8 SDK](https://dotnet.microsoft.com/download) or newer. No external libraries needed.

---
