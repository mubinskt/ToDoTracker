using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace ToDoTracker
{
    public class TaskManager
    {
        private BindingList<ToDoTask> toDoTasks = new BindingList<ToDoTask>();
        private readonly string saveFilePath;
        private readonly XmlSerializer serializer;

        public TaskManager()
        {
            // Store the tasks file in the user's AppData folder
            string appDataPath = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                "ToDoTracker");
            
            // Create the directory if it doesn't exist
            Directory.CreateDirectory(appDataPath);
            
            saveFilePath = Path.Combine(appDataPath, "tasks.xml");
            
            // Initialize XML serializer for List<ToDoTask>
            serializer = new XmlSerializer(typeof(List<ToDoTask>));
            
            LoadTasks();

            // Subscribe to changes to auto-save
            toDoTasks.ListChanged += (s, e) => SaveTasks();
        }

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

        public bool DeleteTask(ToDoTask task)
        {
            if (task == null) return false;
            return toDoTasks.Remove(task);
        }

        private void LoadTasks()
        {
            try
            {
                if (File.Exists(saveFilePath))
                {
                    using (FileStream fs = new FileStream(saveFilePath, FileMode.Open))
                    {
                        var tasks = (List<ToDoTask>)serializer.Deserialize(fs);
                        toDoTasks.Clear();
                        foreach (var task in tasks)
                        {
                            toDoTasks.Add(task);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading tasks: {ex.Message}", "Load Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveTasks()
        {
            try
            {
                using (FileStream fs = new FileStream(saveFilePath, FileMode.Create))
                {
                    serializer.Serialize(fs, toDoTasks.ToList());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving tasks: {ex.Message}", "Save Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}                    
