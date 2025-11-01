using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ToDoTracker
{
    public enum TaskPriority
    {
        High,
        Medium,
        Low
    }

    public enum TaskState
    {
        Created,
        Pending,
        Completed
    }

    [Serializable]
    public class ToDoTask
    {
        public ToDoTask()
        {
            // Default constructor required for XML serialization
            StartDateTime = DateTime.Now;
            EndDateTime = DateTime.Now.AddDays(1);
            TaskPriority = TaskPriority.Medium;
            TaskState = TaskState.Created;
        }

        [Description("The title or name of the task")]
        [Category("Basic")]
        [XmlElement("Title")]
        public string Task { get; set; }

        [Description("Detailed description of what needs to be done")]
        [Category("Basic")]
        public string Description { get; set; }

        [Description("The priority level of this task")]
        [Category("Status")]
        public TaskPriority TaskPriority { get; set; } = TaskPriority.Medium;

        [Description("When the task should begin")]
        [Category("Scheduling")]
        public DateTime StartDateTime { get; set; } = DateTime.Now;

        [Description("When the task should be completed")]
        [Category("Scheduling")]
        public DateTime EndDateTime { get; set; } = DateTime.Now.AddDays(1);

        [Description("Current state of the task")]
        [Category("Status")]
        public TaskState TaskState { get; set; } = TaskState.Created;

    }
}
