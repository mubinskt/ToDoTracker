using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoTracker
{
    enum TaskPriority
    {
        High,
        Medium,
        Low
    }

    enum TaskState
    {
        Created,
        Pending,
        Completed
    }

    class ToDoTask
    {
        public string Task { get; set; }

        public string Description { get; set; }

        public TaskPriority TaskPriority { get; set; } = TaskPriority.Medium;

        public DateTime StartDateTime { get; set; }

        public DateTime EndDateTime { get; set; }

        public TaskState taskState { get; set; } = TaskState.Created;

    }
}
