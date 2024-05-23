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
}