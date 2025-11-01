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
    public partial class Form1 : Form
    {
        private TaskManager taskManager;

        public Form1()
        {
            InitializeComponent();

            // Initialize TaskManager
            taskManager = new TaskManager();

            // Create a sample task
            ToDoTask task1 = new ToDoTask();
            task1.Task = "Get the Assignment out";
            taskManager.ToDoTasks.Add(task1);

            // Set up the binding source directly
            dataGridViewTasks.DataSource = taskManager.ToDoTasks;
        }

        private void AddTask(ToDoTask task)
        {
            //var tasks = (List<ToDoTask>)taskBindingSource.DataSource ?? new List<ToDoTask>();
            //tasks.Add(task);
            //taskBindingSource.DataSource = tasks;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void buttonAddTask_Click(object sender, EventArgs e)
        {
            using (PropertyEditor editor = new PropertyEditor())
            {
                if (editor.ShowDialog() == DialogResult.OK)
                {
                    taskManager.ToDoTasks.Add(editor.Task);
                }
            }
        }

        private void buttonDeleteTask_Click(object sender, EventArgs e)
        {
            // Check if a task is selected
            if (dataGridViewTasks.CurrentRow != null)
            {
                ToDoTask selectedTask = (ToDoTask)dataGridViewTasks.CurrentRow.DataBoundItem;

                // Show confirmation dialog
                string message = $"Are you sure you want to delete the task:\n\"{selectedTask.Task}\"?";
                var result = MessageBox.Show(message, "Confirm Delete",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                // Delete if user confirms
                if (result == DialogResult.Yes)
                {
                    taskManager.ToDoTasks.Remove(selectedTask);
                }
            }
            else
            {
                MessageBox.Show("Please select a task to delete.", "No Task Selected",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

    }
}

