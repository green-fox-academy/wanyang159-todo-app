using System;
using System.Collections.Generic;
using System.Text;

namespace Todo_app
{
    class Tasks
    {
        public List<Task> Listoftasks { get; set; }

        public Tasks()
        {
            Listoftasks=new List<Task>();
        }

        public void Add(Task t)
        {
            Listoftasks.Add(t);
        }

        public void List()
        {
            if (Listoftasks.Count == 0)
            {
                Console.WriteLine("No todos for today! :)");
                return;
            }

            for (int i = 0; i < Listoftasks.Count; i++)
            {
                Console.WriteLine($"{i+1} - {Listoftasks[i].Description}");
            }
        }

        public void Remove(int number)
        {
            Listoftasks.RemoveAt(number-1);
        }

        public void Check(int number)
        {
            Listoftasks[number - 1].Isdone = true;
        }
    }
}
