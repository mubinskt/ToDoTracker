using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoTracker
{
    public partial class PropertyEditor : Form
    {
        private ToDoTask _task;
        
        public ToDoTask Task
        {
            get { return _task; }
        }

        public PropertyEditor(ToDoTask taskToEdit = null)
        {
            InitializeComponent();
            
            if (taskToEdit != null)
            {
                // Create a copy of the task for editing
                _task = new ToDoTask
                {
                    Task = taskToEdit.Task,
                    Description = taskToEdit.Description,
                    TaskPriority = taskToEdit.TaskPriority,
                    StartDateTime = taskToEdit.StartDateTime,
                    EndDateTime = taskToEdit.EndDateTime,
                    TaskState = taskToEdit.TaskState
                };
                Text = "Modify Task"; // Change form title for editing
            }
            else
            {
                _task = new ToDoTask();
                Text = "Add New Task";
            }
            
            // Set the PropertyGrid's selected object to the task
            propertyGrid.SelectedObject = _task;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            // The properties are already updated through the PropertyGrid
            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
