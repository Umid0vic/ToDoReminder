// Osman Said 25/05/2024

using Task = ToDoReminder.Models.Task;

/// <summary>
/// Manages a list of tasks.
/// </summary>
public class TaskManager
{
    /// <summary>
    /// The list of tasks.
    /// </summary>
    private List<Task> taskList;

    /// <summary>
    /// Initializes a new instance of the <see cref="TaskManager"/> class.
    /// </summary>
    public TaskManager()
    {
        taskList = new List<Task>();
    }

    /// <summary>
    /// Adds a task to the list.
    /// </summary>
    /// <param name="task">The task to add.</param>
    public void AddTask(Task task)
    {
        taskList.Add(task);
    }

    /// <summary>
    /// Changes a task in the list.
    /// </summary>
    /// <param name="index">The index of the task to change.</param>
    /// <param name="task">The new task data.</param>
    public void ChangeTask(int index, Task task)
    {
        taskList[index] = task;
    }

    /// <summary>
    /// Deletes a task from the list.
    /// </summary>
    /// <param name="index">The index of the task to delete.</param>
    public void DeleteTask(int index)
    {
        taskList.RemoveAt(index);
    }

    /// <summary>
    /// Gets the list of tasks as strings.
    /// </summary>
    /// <returns>A list of task descriptions.</returns>
    public List<string> GetTasksAsString()
    {
        return taskList.Select(t => t.ToString()).ToList();
    }

    /// <summary>
    /// Gets the list of tasks.
    /// </summary>
    /// <returns>A list of tasks.</returns>
    public List<Task> GetTasks()
    {
        return taskList;
    }

    /// <summary>
    /// Writes the task list to a file.
    /// </summary>
    /// <param name="fileName">The name of the file.</param>
    /// <returns><c>true</c> if the operation was successful; otherwise, <c>false</c>.</returns>
    public bool WriteDataToFile(string fileName)
    {
        FileManager fileManager = new FileManager();
        return fileManager.SaveTaskListToFile(taskList, fileName);
    }

    /// <summary>
    /// Reads the task list from a file.
    /// </summary>
    /// <param name="fileName">The name of the file.</param>
    /// <returns><c>true</c> if the operation was successful; otherwise, <c>false</c>.</returns>
    public bool ReadDataFromFile(string fileName)
    {
        FileManager fileManager = new FileManager();
        return fileManager.ReadTaskListFromFile(taskList, fileName);
    }
}