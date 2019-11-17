using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    class TaskManager
    {
        private List<Task> tasks;

        public int Count {get => this.tasks.Count;}

        public TaskManager() 
        {
            this.tasks = new List<Task>();
        }


        //Add a new task into the list
        public void Add(Task task) 
        {
            this.tasks.Add(task);
            this.tasks.Sort((x,y) => x.Date.CompareTo(y.Date));
        }
        //Edit a Task
        public bool Edit(Task taskinf, int index)
        {
            if (index >= 0 && index < this.Count)
            {

                this.tasks[index] = taskinf;

                this.tasks.Sort((x, y) => x.Date.CompareTo(y.Date));
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool Remove(int index)
        {
            if (index >= 0 && index < this.Count)
            {
                this.tasks.RemoveAt(index);

                this.tasks.Sort((x, y) => x.Date.CompareTo(y.Date));
                return true;
            }
            else
            {
                return false;
            }

        }

        //Get a formatted string array from the tasks
        public string[] LstToStrArr() 
        {
            string[] taskArr = new string[Count];
            for (int i = 0; i < Count; i++) 
            {
                taskArr[i] = this.tasks[i].ToString();
            }

            return taskArr;
        }
    }
}
