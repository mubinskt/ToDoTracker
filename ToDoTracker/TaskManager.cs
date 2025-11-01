using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoTracker
{
    class TaskManager
    {
        private BindingList<ToDoTask> toDoTasks = new BindingList<ToDoTask>();

        public BindingList<ToDoTask> ToDoTasks
        {
            get { return toDoTasks; }
            set { toDoTasks = value; }
        }


        public bool AddTask(ToDoTask task)
        {
            if (task == null) return false;
            toDoTasks.Add(task);
            return true;
        }

        public bool DeleteTask()
        {

            return false;
        }

        private void LoadTasks()
        {

        }
    }
}                    
