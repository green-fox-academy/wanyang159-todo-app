using System;
using System.Collections.Generic;
using System.Text;

namespace Todo_app
{
    class Task
    {
        public string Description { get; private set; }

        public bool Isdone { get; set; }

        public Task(string description)
        {
            Description = description;
            Isdone = false;
        }


    }
}
