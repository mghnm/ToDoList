using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    public class Task
    {
        private DateTime date;
        private string description;
        private Priority priority;

        public DateTime Date { get => date; set => date = value; }
        public string Description { get => description; set => description = value; }
        public Priority Priority { get => priority; set => priority = value; }


        public Task(DateTime date, Priority priority, string description) 
        {
            this.date = date;
            this.description = description;
            this.priority = priority;
        
        }

        //Clone fields to eliminate object reference passing
        public Task(Task task) 
        {
            this.date = task.date;
            this.description = task.description;
            this.priority = task.priority;
        }


        //Remove the underscore from the priority enum
        public string GetPriorityString() 
        {
            return this.priority.ToString().Replace("_", " ");
        }

        //Return only the time part of the datetime as a string
        public string GetTimeString() 
        {
            return this.date.ToString("HH:mm");
        }

        //Override ToString() for formatted date for the listbox
        public override string ToString()
        {
            return $"{date.ToShortDateString(),-25}" +
                   $"{GetTimeString(),-16}" +
                   $"{GetPriorityString(),-21}" +
                   $"{description}";


        }

    }
}
