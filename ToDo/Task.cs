using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo
{
    class Task
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Deadline { get; set; }
        public bool IsDone { get; set; }

        public Task(String name, String description, DateTime deadline, bool isDone = false)
        {
            Name = name;
            Description = description;
            Deadline = deadline;
            IsDone = isDone;
        }
        public Task(string line)
        {
            string[] tab = line.Split(';');
            Name = tab[0];
            Description = tab[1];
            Deadline = DateTime.Parse(tab[2]);
            if(tab[3] == "0")
            {
                IsDone = false;
            }
            else
            {
                IsDone = true;
            }
        }
        public Task() { }
        public override string ToString()
        {
            return $"{Name};{Description};{Deadline};{IsDone}";
        }
    }
}
