namespace simple_task_manager.Services
{
    public class TaskManager
    {
        private List<Task> tasks = new List<Task>(); 
        private const string filePath = "Data/tasks.csv";

        public async System.Threading.Tasks.Task LoadTasksAsync() 
        {
            try
            {
                if (File.Exists(filePath))
                {
                    var lines = await File.ReadAllLinesAsync(filePath);
                    foreach (var line in lines)
                    {
                        var data = line.Split(',');
                        var newTask = new Task(data[0], data[1], Enum.Parse<TaskCategory>(data[2]))
                        {
                            IsCompleted = bool.Parse(data[3])
                        };
                        tasks.Add(newTask);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading tasks: {ex.Message}");
            }
        }

        public async System.Threading.Tasks.Task SaveTasksAsync() 
        {
            try
            {
                var lines = tasks.Select(t => $"{t.Name},{t.Description},{t.Category},{t.IsCompleted}");
                await File.WriteAllLinesAsync(filePath, lines);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving tasks: {ex.Message}");
            }
        }

        public void AddTask(string name, string description, TaskCategory category)
        {
            var task = new Task(name, description, category);
            tasks.Add(task);
            Console.WriteLine("Task added successfully!");
        }

        public void ViewTasks()
        {
            if (!tasks.Any())
            {
                Console.WriteLine("No tasks available.");
                return;
            }
            foreach (var task in tasks)
            {
                Console.WriteLine($"{task.Name} - {task.Description} [{task.Category}] - Completed: {task.IsCompleted}");
            }
        }

        public void ViewTasksByCategory(TaskCategory category)
        {
            var filteredTasks = tasks.Where(t => t.Category == category).ToList();
            if (!filteredTasks.Any())
            {
                Console.WriteLine($"No tasks found in {category} category.");
                return;
            }
            filteredTasks.ForEach(t => Console.WriteLine($"{t.Name} - {t.Description} - Completed: {t.IsCompleted}"));
        }
    }
}
