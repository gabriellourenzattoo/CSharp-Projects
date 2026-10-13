using System;
using System.Runtime.CompilerServices;


class Program
{
    static void Main(string[] args)
    {
        List<string> tasks = [];

        while (true) {
            Console.WriteLine("------------------------");
            Console.WriteLine("|      To-Do-List      |");
            Console.WriteLine("------------------------");
            Console.WriteLine("| [1]. View Task       |");        
            Console.WriteLine("| [2]. Add Task        |");
            Console.WriteLine("| [3]. Remove Task     |");
            Console.WriteLine("| [4]. Exit            |");
            Console.WriteLine("------------------------");
            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine() ?? "0");
            switch (choice)
            {
                case 1:
                    Console.WriteLine("------------------------");
                    Console.WriteLine("|      View Task...    |");
                    Console.WriteLine("------------------------");
                    if (tasks.Count > 0)
                    {
                        foreach (string task in tasks){

                            Console.WriteLine($"| {task.PadRight(21, ' ')}|");
                        }
                    }
                     else
                    {
                        Console.WriteLine("No tasks found!");
                    }
                    break;
                case 2:
                    Console.WriteLine("------------------------");
                    Console.WriteLine("|       Add Task...    |");
                    Console.WriteLine("------------------------");         
                    Console.Write("| Enter name for your task: ");
                    string taskNameAdd = Console.ReadLine() ?? "0";        
                    foreach (string task in tasks)
                    {
                        if (task == taskNameAdd)
                        {
                            Console.WriteLine("| Task already exists.");
                            break;
                        }
                    }
                    tasks.Add(taskNameAdd);
                    Console.WriteLine("| Task add suscessfully|");
                    break;
                case 3:
                    Console.WriteLine("------------------------");
                    Console.WriteLine("|    Remove Task...    |");
                    Console.WriteLine("------------------------");         
                    Console.Write("| Enter name for your task: ");
                    string taskNameRemove = Console.ReadLine() ?? "0";
                    bool encountre = false;
                    foreach (string task in tasks)
                    {
                        if (task == taskNameRemove)
                        {
                            encountre = true;
                        }
                    }        
                    if (!encountre)
                    {
                        Console.WriteLine("| Task not found. ");
                    }
                    else
                    {
                        tasks.Remove(taskNameRemove);
                        Console.WriteLine("| Task successfully removed.");
                    }
                    break;
                case 4:
                    Console.WriteLine("------------------------");
                    Console.WriteLine("|         Exit         |");
                    Console.WriteLine("------------------------");         
                    Console.WriteLine("Exiting...");
                    return;
            }   
        }
    }
}

