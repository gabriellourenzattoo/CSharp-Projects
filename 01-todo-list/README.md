<p align="center">
  <img src="https://capsule-render.vercel.app/api?type=waving&color=0:0D1B2A,35:512BD4,100:9B4F96&height=200&section=header&text=To-Do%20List&fontSize=55&fontColor=ffffff&animation=fadeIn&fontAlignY=35&desc=A%20CLI%20Task%20Manager%20in%20C%23&descAlignY=60&descSize=16" width="100%" />
</p>

<p align="left">
  <img src="https://img.shields.io/badge/C%23-239120?style=flat-square&logo=csharp&logoColor=white" />
  <img src="https://img.shields.io/badge/.NET-512BD4?style=flat-square&logo=dotnet&logoColor=white" />
  <img src="https://img.shields.io/badge/Interface-CLI-informational?style=flat-square" />
  <img src="https://img.shields.io/badge/Status-Active-brightgreen?style=flat-square" />
</p>

A terminal-based **task manager** built in C#, developed as a hands-on exercise in the language fundamentals. It stores tasks in memory and lets the user view, add, and remove them through an interactive menu — all through a simple command-line interface.

---

## 🔎 Overview

`To-Do List` is the first project of the [C# Projects](../) repository. It's intentionally scoped to be small enough to fully understand, while still touching the core mechanics of the language: control flow, collections, console input and output, and string handling.

The program revolves around a single main loop:

- **Menu** — displays the options and reads the user's choice
- **`List<string>`** — holds the tasks while the program is running
- **`switch`** — routes each choice to its action (view, add, remove, exit)

---

## ✨ Features

- 📋 View all tasks
- ➕ Add a new task
- ❌ Remove a task by name
- 🔁 Menu that keeps running until the user exits
- 🖥️ Formatted, table-style terminal output

---

## 🧠 C# Concepts Applied

- Variables and data types
- `List<T>` collection
- `while` loop
- `foreach` loop
- `switch` statement
- `if` / `else` conditionals
- `Console.ReadLine()` and `Console.WriteLine()`
- String interpolation and `PadRight`
- Null-coalescing operator (`??`)
- `int.Parse` for converting input

---

## 🛠️ Technologies

- **C# / .NET 8** — no external dependencies, base class library only
- **CLI** — runs and is fully operated through the terminal

---

## 🗂️ Project Structure

```
01-todo-list/
├── Program.cs
├── TodoList.csproj
└── README.md
```

All logic currently lives in a single `Program.cs` file, containing the menu loop and the logic for each option.

---

## ▶️ How to Run

```bash
# From the repository root
cd 01-todo-list

# Run with the .NET CLI
dotnet run
```

> Requires the [.NET 8 SDK](https://dotnet.microsoft.com/download) or newer. No external libraries needed.

---

## 💻 Example Usage

```
------------------------
|      To-Do-List      |
------------------------
| [1]. View Task       |
| [2]. Add Task        |
| [3]. Remove Task     |
| [4]. Exit            |
------------------------
Enter your choice: 2
------------------------
|       Add Task...    |
------------------------
| Enter name for your task: Study C#
| Task added successfully

Enter your choice: 1
------------------------
|      View Task...    |
------------------------
| Study C#             |

Enter your choice: 3
------------------------
|    Remove Task...    |
------------------------
| Enter name for your task: Study C#
| Task successfully removed.

Enter your choice: 4
------------------------
|         Exit         |
------------------------
Exiting...
```

> This is a representative example of the current CLI flow — exact menu wording and prompts may vary slightly depending on the version of `Program.cs`.

---

## 🚧 Future Improvements

- [ ] Prevent duplicate tasks from being added
- [ ] Input validation with `int.TryParse` and handling of invalid menu options
- [ ] Mark tasks as completed
- [ ] Data persistence (saving tasks between sessions, e.g. to a file)
- [ ] Refactor each menu option into its own method
- [ ] Introduce classes (e.g. a `TaskItem` class and a `TaskManager` class)

---

## 🎯 Learning Goals

This project exists to practice **the fundamentals of C#** — reading input, controlling program flow, and managing data with collections — building a solid base before moving on to classes and object-oriented design in the next projects.
