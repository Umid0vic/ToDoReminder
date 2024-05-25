using ToDoReminder.Models;
using Task = ToDoReminder.Models.Task;

namespace ToDoReminder;
public partial class MainForm : Form
{
    /// <summary>
    /// Manages the tasks.
    /// </summary>
    private TaskManager taskManager;

    /// <summary>
    /// The name of the file to save/load tasks.
    /// </summary>
    private string fileName;

    public MainForm()
    {
        InitializeComponent();
        InitializeGUI();
    }

    /// <summary>
    /// Initializes the GUI components and task manager.
    /// </summary>
    private void InitializeGUI()
    {
        this.Text = "ToDo Reminder by Osman";
        taskManager = new TaskManager();
        fileName = Path.Combine(Application.StartupPath, "reminders.txt");

        cmbPriority.Items.Clear();
        cmbPriority.Items.AddRange(Enum.GetNames(typeof(PriorityType)));
        cmbPriority.SelectedIndex = (int)PriorityType.Normal;

        listViewTasks.Items.Clear();
        listViewTasks.View = View.Details;
        listViewTasks.FullRowSelect = true;
        listViewTasks.GridLines = true;
        listViewTasks.SelectedIndexChanged += ListViewTasks_SelectedIndexChanged;

        txtDescription.Text = string.Empty;

        // Set the DateTimePicker format
        dateTimePicker.Format = DateTimePickerFormat.Custom;
        dateTimePicker.CustomFormat = "yyyy-MM-dd HH:mm";

        toolTipDateTimePicker.ShowAlways = true;
        toolTipDateTimePicker.SetToolTip(dateTimePicker, "Click to open calendar for date, write in time here.");
        toolTipDateTimePicker.SetToolTip(cmbPriority, "Select the priority");

        btnAdd.Click += BtnAdd_Click;
        btnChange.Click += BtnChange_Click;
        btnDelete.Click += BtnDelete_Click;
        menuFileNew.Click += MenuFileNew_Click;
        menuFileOpenDataFile.Click += MenuFileOpenDataFile_Click;
        menuFileSave.Click += MenuFileSave_Click;
        menuFileExit.Click += MenuFileExit_Click;
        menuHelpAbout.Click += MenuHelpAbout_Click;

        btnChange.Enabled = false;
        btnDelete.Enabled = false;
    }

    private void BtnAdd_Click(object sender, EventArgs e)
    {
        if (ValidateInput())
        {
            Task task = new Task
            {
                Date = dateTimePicker.Value,
                Description = txtDescription.Text,
                Priority = (PriorityType)cmbPriority.SelectedIndex
            };

            taskManager.AddTask(task);
            AddTaskToListView(task);
            ClearInput();
        }
    }

    private void BtnChange_Click(object sender, EventArgs e)
    {
        if (listViewTasks.SelectedItems.Count == 0)
        {
            MessageBox.Show("Please select a task to change.");
            return;
        }

        if (ValidateInput())
        {
            int index = listViewTasks.SelectedItems[0].Index;
            Task task = new Task
            {
                Date = dateTimePicker.Value,
                Description = txtDescription.Text,
                Priority = (PriorityType)cmbPriority.SelectedIndex
            };

            taskManager.ChangeTask(index, task);
            UpdateTaskInListView(index, task);
            ClearInput();

            MessageBox.Show("Task has been changed successfully.", "Task Changed");
        }
    }

    private void BtnDelete_Click(object sender, EventArgs e)
    {
        if (listViewTasks.SelectedItems.Count == 0)
        {
            MessageBox.Show("Please select a task to delete.");
            return;
        }

        var result = MessageBox.Show("Are you sure you want to delete this task?", "Confirm Delete", MessageBoxButtons.YesNo);
        if (result == DialogResult.Yes)
        {
            int index = listViewTasks.SelectedItems[0].Index;
            taskManager.DeleteTask(index);
            listViewTasks.Items.RemoveAt(index);
            ClearInput();

            MessageBox.Show("Task has been deleted successfully.", "Task Deleted");

            // Disable buttons
            btnChange.Enabled = false;
            btnDelete.Enabled = false;
        }
    }

    private void MenuFileNew_Click(object sender, EventArgs e)
    {
        InitializeGUI();
    }

    private void MenuFileOpenDataFile_Click(object sender, EventArgs e)
    {
        using (OpenFileDialog openFileDialog = new OpenFileDialog())
        {
            openFileDialog.InitialDirectory = Application.StartupPath;
            openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileName = openFileDialog.FileName;
                if (taskManager.ReadDataFromFile(fileName))
                {
                    UpdateGUI();
                }
                else
                {
                    MessageBox.Show("Something went wrong when opening the file.");
                }
            }
        }
    }

    private void MenuFileSave_Click(object sender, EventArgs e)
    {
        if (taskManager.GetTasks().Count == 0)
        {
            MessageBox.Show("No tasks to save. Please add tasks before saving.", "Save Error");
            return;
        }

        using (SaveFileDialog saveFileDialog = new SaveFileDialog())
        {
            saveFileDialog.InitialDirectory = Application.StartupPath;
            saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileName = saveFileDialog.FileName;
                if (taskManager.WriteDataToFile(fileName))
                {
                    MessageBox.Show($"Data saved to file: {Environment.NewLine}{fileName}");
                }
                else
                {
                    MessageBox.Show("Something went wrong while saving data to file.");
                }
            }
        }
    }

    private void MenuFileExit_Click(object sender, EventArgs e)
    {
        var result = MessageBox.Show("Are you sure you want to exit?", "Think twice", MessageBoxButtons.OKCancel);
        if (result == DialogResult.OK)
        {
            Application.Exit();
        }
    }

    private void MenuHelpAbout_Click(object sender, EventArgs e)
    {
        MessageBox.Show("ToDo Reminder Application\nVersion 1.0\n© 2024 Osman", "About");
    }

    private void AddTaskToListView(Task task)
    {
        ListViewItem item = new ListViewItem(task.Date.ToString("yyyy-MM-dd"));
        item.SubItems.Add(task.Date.ToString("HH:mm"));
        item.SubItems.Add(task.Priority.ToString().Replace('_', ' '));
        item.SubItems.Add(task.Description);
        listViewTasks.Items.Add(item);
    }

    /// <summary>
    /// Updates a task in the ListView control.
    /// </summary>
    /// <param name="index">The index of the task to update.</param>
    /// <param name="task">The new task data.</param>
    private void UpdateTaskInListView(int index, Task task)
    {
        ListViewItem item = listViewTasks.Items[index];
        item.SubItems[0].Text = task.Date.ToString("yyyy-MM-dd");
        item.SubItems[1].Text = task.Date.ToString("HH:mm");
        item.SubItems[2].Text = task.Priority.ToString().Replace('_', ' ');
        item.SubItems[3].Text = task.Description;
    }

    private void UpdateGUI()
    {
        listViewTasks.Items.Clear();
        foreach (var task in taskManager.GetTasks())
        {
            AddTaskToListView(task);
        }
    }

    /// <summary>
    /// Handles the ListView SelectedIndexChanged event.
    /// </summary>
    private void ListViewTasks_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (listViewTasks.SelectedItems.Count > 0)
        {
            int index = listViewTasks.SelectedItems[0].Index;
            Task task = taskManager.GetTasks()[index];
            dateTimePicker.Value = task.Date;
            txtDescription.Text = task.Description;
            cmbPriority.SelectedIndex = (int)task.Priority;

            // Enable buttons
            btnChange.Enabled = true;
            btnDelete.Enabled = true;
        }
        else
        {
            // Disable buttons if no item is selected
            btnChange.Enabled = false;
            btnDelete.Enabled = false;
        }
    }

    private void ClearInput()
    {
        dateTimePicker.Value = DateTime.Now;
        txtDescription.Text = string.Empty;
        cmbPriority.SelectedIndex = (int)PriorityType.Normal;

        // Disable buttons
        btnChange.Enabled = false;
        btnDelete.Enabled = false;
    }


    private bool ValidateInput()
    {
        if (string.IsNullOrWhiteSpace(txtDescription.Text))
        {
            MessageBox.Show("Description cannot be empty.");
            return false;
        }
        return true;
    }
}