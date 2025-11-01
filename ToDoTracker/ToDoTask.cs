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
        string Task { get; set; }

        string Description { get; set; }

        TaskPriority TaskPriority { get; set; } = TaskPriority.Medium;

        DateTime StartDateTime { get; set; }

        DateTime EndDateTime { get; set; }

        TaskState taskState { get; set; } = TaskState.Created;

    }
}
