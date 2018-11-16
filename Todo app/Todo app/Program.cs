using System;
using System.Data;

namespace Todo_app
{
    class Program
    {
        static Tasks todaylist=new Tasks();
        static void Main(string[] args)
        {
            Parse(args);
            /*Tasks todaytodo = new Tasks();
            todaytodo.Add(new Task("Walk the dog"));
            todaytodo.Add(new Task("Buy milk"));
            todaytodo.Add(new Task("Do homework"));
            todaytodo.Listtasks();*/
           
            Console.WriteLine("Hello World!");
        }

        static void Parse(string[] args)
        {
            string cmd = args[0].Substring(1);
            if (cmd == "l")
            {
                ListTasks();
            }
            else if (cmd == "a")
            {
                if (args.Length < 2)
                {
                    throw new Exception("Unable to add: no task provided");
                }
                
                 AddTask(args[1]);               
            }
            else if (cmd == "r")
            {
                if (args.Length < 2)
                {
                    throw new Exception("Unable to remove: no index provided");
                }
                int n;
                if (int.TryParse(args[1], out n))
                {
                    RemoveTask(n);
                }
                else
                {
                    throw new Exception("Unable to check: index is not a number");
                }
            }
            else if (cmd == "c")
            {
                if (args.Length < 2)
                {
                    throw new Exception("Unable to remove: no index provided");
                }
                int n;
                if (int.TryParse(args[1], out n))
                {
                    RemoveTask(n);
                }
                else
                {
                    throw new Exception("Unable to check: index is not a number");
                }

            }
            Console.WriteLine(cmd);                    
            
            
            
        }
        static void Printusage()
        {
            Console.WriteLine("Command Line Todo application");
            Console.WriteLine("=============================");
            Console.WriteLine();
            Console.WriteLine("Command line arguments:");
            Console.WriteLine(" -l   Lists all the tasks");
            Console.WriteLine(" -a   Adds a new task");
            Console.WriteLine(" -r   Removes a task");
            Console.WriteLine(" -c   Completes a task");
        }

        static void ListTasks()
        {
            todaylist.List();
        }
        static void AddTask(string des)
        {
            
            todaylist.Add(new Task(des));
        }

        static void RemoveTask(int index)
        {
            if (index <= 0 || index > todaylist.Listoftasks.Count)
            {
                throw new Exception("Unable to check: index is out of bound");
            }
            todaylist.Remove(index-1);
        }

        static void CheckTask(int index)
        {
            if (index <= 0 || index > todaylist.Listoftasks.Count)
            {
                throw new Exception("Unable to check: index is out of bound");
            }
            todaylist.Check(index - 1);
        }
    }
}
