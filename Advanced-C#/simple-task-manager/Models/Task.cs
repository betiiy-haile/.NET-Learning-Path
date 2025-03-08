public class Task {
    public string Name { get; set; }
    public string Description { get; set; }
    public TaskCategory Category { get; set; }
    public bool IsCompleted { get; set; }

    public Task(string name, string description, TaskCategory category) {
        Name = name;
        Description = description;
        Category = category;
        IsCompleted = false;
    }
}