using ToDoReminder.Models;
using Task = ToDoReminder.Models.Task;

namespace ToDoReminder;

public class TaskManager
{
    private List<Task> taskList;

    public TaskManager()
    {
        taskList = new List<Task>();
    }

    public void AddTask(Task task)
    {
        taskList.Add(task);
    }

    public void ChangeTask(int index, Task task)
    {
        taskList[index] = task;
    }

    public void DeleteTask(int index)
    {
        taskList.RemoveAt(index);
    }

    public List<string> GetTasksAsString()
    {
        return taskList.Select(t => t.ToString()).ToList();
    }

    // File operations
    public bool WriteDataToFile(string fileName)
    {
        FileManager fileManager = new FileManager();
        return fileManager.SaveTaskListToFile(taskList, fileName);
    }

    public bool ReadDataFromFile(string fileName)
    {
        FileManager fileManager = new FileManager();
        return fileManager.ReadTaskListFromFile(taskList, fileName);
    }
}