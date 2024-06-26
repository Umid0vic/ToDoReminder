﻿// Osman Said 25/05/2024

using ToDoReminder.Models;
using Task = ToDoReminder.Models.Task;

/// <summary>
/// Manages file operations for saving and reading tasks.
/// </summary>
public class FileManager
{
    /// <summary>
    /// The file version token.
    /// </summary>
    private const string fileVersionToken = "ToDoRem_21";

    /// <summary>
    /// The file version number.
    /// </summary>
    private const double fileVersionNr = 1.0;

    /// <summary>
    /// Saves the task list to a file.
    /// </summary>
    /// <param name="taskList">The list of tasks to save.</param>
    /// <param name="fileName">The name of the file.</param>
    /// <returns><c>true</c> if the operation was successful; otherwise, <c>false</c>.</returns>
    public bool SaveTaskListToFile(List<Task> taskList, string fileName)
    {
        bool ok = true;
        StreamWriter writer = null;
        try
        {
            writer = new StreamWriter(fileName);
            writer.WriteLine(fileVersionToken);
            writer.WriteLine(fileVersionNr);
            writer.WriteLine(taskList.Count);

            foreach (var task in taskList)
            {
                writer.WriteLine(task.Description);
                writer.WriteLine(task.Priority.ToString());
                writer.WriteLine(task.Date.Year);
                writer.WriteLine(task.Date.Month);
                writer.WriteLine(task.Date.Day);
                writer.WriteLine(task.Date.Hour);
                writer.WriteLine(task.Date.Minute);
                writer.WriteLine(task.Date.Second);
            }
        }
        catch
        {
            ok = false;
        }
        finally
        {
            if (writer != null)
                writer.Close();
        }

        return ok;
    }

    /// <summary>
    /// Reads the task list from a file.
    /// </summary>
    /// <param name="taskList">The list to populate with tasks.</param>
    /// <param name="fileName">The name of the file.</param>
    /// <returns><c>true</c> if the operation was successful; otherwise, <c>false</c>.</returns>
    public bool ReadTaskListFromFile(List<Task> taskList, string fileName)
    {
        bool ok = true;
        StreamReader reader = null;
        try
        {
            taskList.Clear();
            reader = new StreamReader(fileName);

            string versionToken = reader.ReadLine();
            double version = double.Parse(reader.ReadLine());

            if (versionToken != fileVersionToken || version != fileVersionNr)
            {
                ok = false;
            }
            else
            {
                int count = int.Parse(reader.ReadLine());
                for (int i = 0; i < count; i++)
                {
                    Task task = new Task();
                    task.Description = reader.ReadLine();
                    task.Priority = (PriorityType)Enum.Parse(typeof(PriorityType), reader.ReadLine());
                    int year = int.Parse(reader.ReadLine());
                    int month = int.Parse(reader.ReadLine());
                    int day = int.Parse(reader.ReadLine());
                    int hour = int.Parse(reader.ReadLine());
                    int minute = int.Parse(reader.ReadLine());
                    int second = int.Parse(reader.ReadLine());
                    task.Date = new DateTime(year, month, day, hour, minute, second);
                    taskList.Add(task);
                }
            }
        }
        catch
        {
            ok = false;
        }
        finally
        {
            if (reader != null)
                reader.Close();
        }

        return ok;
    }
}