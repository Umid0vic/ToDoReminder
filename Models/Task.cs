// Osman Said 23/05/2024

namespace ToDoReminder.Models;

public class Task
{
    private string description;
    private PriorityType priority;
    private DateTime date;

    // Default constructor
    public Task()
    {
        priority = PriorityType.Normal;
    }

    // Parameterized constructors
    public Task(DateTime taskDate) : this(taskDate, string.Empty, PriorityType.Normal)
    {
    }

    public Task(DateTime taskDate, string description, PriorityType priority)
    {
        this.date = taskDate;
        this.description = description;
        this.priority = priority;
    }

    public string Description
    {
        get { return description; }
        set { description = value; }
    }

    public PriorityType Priority
    {
        get { return priority; }
        set { priority = value; }
    }

    public DateTime Date
    {
        get { return date; }
        set { date = value; }
    }

    public string GetPriorityString()
    {
        return priority.ToString().Replace('_', ' ');
    }

    public string GetTimeString()
    {
        return date.ToString("HH:mm");
    }

    public override string ToString()
    {
        return $"{date.ToShortDateString()} {GetTimeString()} {GetPriorityString()} {description}";
    }
}