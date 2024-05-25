// Osman Said 23/05/2024

namespace ToDoReminder.Models;

/// <summary>
/// Represents a task with a description, date, and priority.
/// </summary>
public class Task
{
    /// <summary>
    /// The description of the task.
    /// </summary>
    private string description;

    /// <summary>
    /// The priority of the task.
    /// </summary>
    private PriorityType priority;

    /// <summary>
    /// The date of the task.
    /// </summary>
    private DateTime date;

    /// <summary>
    /// Initializes a new instance of the <see cref="Task"/> class.
    /// </summary>
    public Task()
    {
        priority = PriorityType.Normal;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="Task"/> class with the specified date.
    /// </summary>
    /// <param name="taskDate">The date of the task.</param>
    public Task(DateTime taskDate) : this(taskDate, string.Empty, PriorityType.Normal)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="Task"/> class with the specified date, description, and priority.
    /// </summary>
    /// <param name="taskDate">The date of the task.</param>
    /// <param name="description">The description of the task.</param>
    /// <param name="priority">The priority of the task.</param>
    public Task(DateTime taskDate, string description, PriorityType priority)
    {
        this.date = taskDate;
        this.description = description;
        this.priority = priority;
    }

    /// <summary>
    /// Gets or sets the description of the task.
    /// </summary>
    public string Description
    {
        get { return description; }
        set { description = value; }
    }

    /// <summary>
    /// Gets or sets the priority of the task.
    /// </summary>
    public PriorityType Priority
    {
        get { return priority; }
        set { priority = value; }
    }

    /// <summary>
    /// Gets or sets the date of the task.
    /// </summary>
    public DateTime Date
    {
        get { return date; }
        set { date = value; }
    }

    /// <summary>
    /// Gets the priority as a formatted string.
    /// </summary>
    /// <returns>The priority as a string.</returns>
    public string GetPriorityString()
    {
        return priority.ToString().Replace('_', ' ');
    }

    /// <summary>
    /// Gets the time part of the date as a string.
    /// </summary>
    /// <returns>The time part of the date.</returns>
    public string GetTimeString()
    {
        return date.ToString("HH:mm");
    }

    /// <summary>
    /// Returns a string that represents the current task.
    /// </summary>
    /// <returns>A string that represents the current task.</returns>
    public override string ToString()
    {
        return $"{date.ToShortDateString()} {GetTimeString()} {GetPriorityString()} {description}";
    }
}