using simple_task_manager.Services;

namespace SimpleTaskManager
{
    class Program
    {
        public static async void Main(string[] args)
        {
            TaskManager taskManager = new TaskManager();
            await taskManager.LoadTasksAsync(); 

            while (true)
            {
                Console.WriteLine("\n1. Add Task\n2. View Tasks\n3. View Tasks by Category\n4. Exit");
                Console.Write("Choose an option: ");
                string choice = Console.ReadLine()?.Trim() ?? "";

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter Task Name: ");
                        string name = Console.ReadLine()?.Trim() ?? "";

                        Console.Write("Enter Description: ");
                        string desc = Console.ReadLine()?.Trim() ?? "";

                        Console.Write("Enter Category (Personal, Work, Errands): ");
                        string categoryInput = Console.ReadLine()?.Trim() ?? "";
                        if (Enum.TryParse(categoryInput, true, out TaskCategory category))
                        {
                            taskManager.AddTask(name, desc, category);
                            await taskManager.SaveTasksAsync(); 
                        }
                        else
                        {
                            Console.WriteLine("Invalid category. Please enter Personal, Work, or Errands.");
                        }
                        break;

                    case "2":
                        taskManager.ViewTasks();
                        break;

                    case "3":
                        Console.Write("Enter Category to Filter (Personal, Work, Errands): ");
                        string filterCategoryInput = Console.ReadLine()?.Trim() ?? "";
                        if (Enum.TryParse(filterCategoryInput, true, out TaskCategory filterCategory))
                        {
                            taskManager.ViewTasksByCategory(filterCategory);
                        }
                        else
                        {
                            Console.WriteLine("Invalid category.");
                        }
                        break;

                    case "4":
                        Console.WriteLine("Saving tasks before exit...");
                        await taskManager.SaveTasksAsync(); // ✅ Ensure method returns Task
                        Console.WriteLine("Exiting program.");
                        break;

                    default:
                        Console.WriteLine("Invalid choice, try again.");
                        break;
                }
            }
        }
    }
}
