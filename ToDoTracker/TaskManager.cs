using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoTracker
{
    class TaskManager
    {
        private List<ToDoTask> toDoTasks = new List<ToDoTask>();

        public List<ToDoTask> ToDoTasks
        {
            get { return toDoTasks; }
            set { toDoTasks = value; }
        }

        public bool AddTask()
        {

            return false;
        }

        public bool DeleteTask()
        {

            return false;
        }
    }
}
