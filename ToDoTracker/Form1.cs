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
        public Form1()
        {
            InitializeComponent();

            TaskManager taskManager = new TaskManager();

            ToDoTask task1 = new ToDoTask();
            task1.Task = "Get the Assignment out";

            taskManager.ToDoTasks.Add(new ToDoTask());

            bindingSource1.DataSource = taskManager.ToDoTasks;

            BindingList<ToDoTask>  tasks = new BindingList<ToDoTask>();
            dataGridView1.DataSource = tasks;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
