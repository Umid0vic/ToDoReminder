namespace ToDoReminder
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            MenuMain = new MenuStrip();
            menuFile = new ToolStripMenuItem();
            menuFileNew = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            menuFileOpenDataFile = new ToolStripMenuItem();
            menuFileSave = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            menuFileExit = new ToolStripMenuItem();
            menuHelp = new ToolStripMenuItem();
            menuHelpAbout = new ToolStripMenuItem();
            labelDateTime = new Label();
            dateTimePicker = new DateTimePicker();
            lblPriority = new Label();
            cmbPriority = new ComboBox();
            lblToDo = new Label();
            txtDescription = new TextBox();
            btnAdd = new Button();
            listViewTasks = new ListView();
            columnDate = new ColumnHeader();
            columnTime = new ColumnHeader();
            columnPriority = new ColumnHeader();
            ColumnDescription = new ColumnHeader();
            btnDelete = new Button();
            btnChange = new Button();
            toolTipDateTimePicker = new ToolTip(components);
            MenuMain.SuspendLayout();
            SuspendLayout();
            // 
            // MenuMain
            // 
            MenuMain.Items.AddRange(new ToolStripItem[] { menuFile, menuHelp });
            MenuMain.Location = new Point(0, 0);
            MenuMain.Name = "MenuMain";
            MenuMain.Size = new Size(800, 24);
            MenuMain.TabIndex = 0;
            MenuMain.Text = "Menu Main";
            // 
            // menuFile
            // 
            menuFile.DropDownItems.AddRange(new ToolStripItem[] { menuFileNew, toolStripSeparator1, menuFileOpenDataFile, menuFileSave, toolStripSeparator2, menuFileExit });
            menuFile.Name = "menuFile";
            menuFile.Size = new Size(37, 20);
            menuFile.Text = "File";
            // 
            // menuFileNew
            // 
            menuFileNew.Name = "menuFileNew";
            menuFileNew.Size = new Size(148, 22);
            menuFileNew.Text = "New";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(145, 6);
            // 
            // menuFileOpenDataFile
            // 
            menuFileOpenDataFile.Name = "menuFileOpenDataFile";
            menuFileOpenDataFile.Size = new Size(148, 22);
            menuFileOpenDataFile.Text = "Open data file";
            // 
            // menuFileSave
            // 
            menuFileSave.Name = "menuFileSave";
            menuFileSave.Size = new Size(148, 22);
            menuFileSave.Text = "Save data file";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(145, 6);
            // 
            // menuFileExit
            // 
            menuFileExit.Name = "menuFileExit";
            menuFileExit.Size = new Size(148, 22);
            menuFileExit.Text = "Exit";
            // 
            // menuHelp
            // 
            menuHelp.DropDownItems.AddRange(new ToolStripItem[] { menuHelpAbout });
            menuHelp.Name = "menuHelp";
            menuHelp.Size = new Size(44, 20);
            menuHelp.Text = "Help";
            // 
            // menuHelpAbout
            // 
            menuHelpAbout.Name = "menuHelpAbout";
            menuHelpAbout.Size = new Size(107, 22);
            menuHelpAbout.Text = "About";
            // 
            // labelDateTime
            // 
            labelDateTime.AutoSize = true;
            labelDateTime.Location = new Point(10, 30);
            labelDateTime.Name = "labelDateTime";
            labelDateTime.Size = new Size(83, 15);
            labelDateTime.TabIndex = 1;
            labelDateTime.Text = "Date and Time";
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(99, 24);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(200, 23);
            dateTimePicker.TabIndex = 2;
            // 
            // lblPriority
            // 
            lblPriority.AutoSize = true;
            lblPriority.Location = new Point(343, 30);
            lblPriority.Name = "lblPriority";
            lblPriority.Size = new Size(45, 15);
            lblPriority.TabIndex = 3;
            lblPriority.Text = "Priority";
            // 
            // cmbPriority
            // 
            cmbPriority.FormattingEnabled = true;
            cmbPriority.Location = new Point(394, 24);
            cmbPriority.Name = "cmbPriority";
            cmbPriority.Size = new Size(121, 23);
            cmbPriority.TabIndex = 4;
            // 
            // lblToDo
            // 
            lblToDo.AutoSize = true;
            lblToDo.Location = new Point(10, 67);
            lblToDo.Name = "lblToDo";
            lblToDo.Size = new Size(36, 15);
            lblToDo.TabIndex = 5;
            lblToDo.Text = "To do";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(99, 63);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(593, 23);
            txtDescription.TabIndex = 6;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.LightGreen;
            btnAdd.ForeColor = Color.Black;
            btnAdd.Location = new Point(698, 58);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(90, 32);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // listViewTasks
            // 
            listViewTasks.Columns.AddRange(new ColumnHeader[] { columnDate, columnTime, columnPriority, ColumnDescription });
            listViewTasks.Location = new Point(12, 102);
            listViewTasks.Name = "listViewTasks";
            listViewTasks.Size = new Size(776, 282);
            listViewTasks.TabIndex = 8;
            listViewTasks.UseCompatibleStateImageBehavior = false;
            // 
            // columnDate
            // 
            columnDate.Text = "Date";
            columnDate.Width = 100;
            // 
            // columnTime
            // 
            columnTime.Text = "Hour";
            // 
            // columnPriority
            // 
            columnPriority.Text = "Priority";
            columnPriority.Width = 120;
            // 
            // ColumnDescription
            // 
            ColumnDescription.Text = "Description";
            ColumnDescription.Width = 496;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.LightCoral;
            btnDelete.ForeColor = Color.Black;
            btnDelete.Location = new Point(394, 390);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(99, 31);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnChange
            // 
            btnChange.BackColor = Color.LightGoldenrodYellow;
            btnChange.ForeColor = Color.Black;
            btnChange.Location = new Point(244, 390);
            btnChange.Name = "btnChange";
            btnChange.Size = new Size(102, 31);
            btnChange.TabIndex = 10;
            btnChange.Text = "Change";
            btnChange.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnChange);
            Controls.Add(btnDelete);
            Controls.Add(listViewTasks);
            Controls.Add(btnAdd);
            Controls.Add(txtDescription);
            Controls.Add(lblToDo);
            Controls.Add(cmbPriority);
            Controls.Add(lblPriority);
            Controls.Add(dateTimePicker);
            Controls.Add(labelDateTime);
            Controls.Add(MenuMain);
            MainMenuStrip = MenuMain;
            Name = "MainForm";
            Text = "s";
            MenuMain.ResumeLayout(false);
            MenuMain.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip MenuMain;
        private ToolStripMenuItem menuFile;
        private ToolStripMenuItem menuFileNew;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem menuFileOpenDataFile;
        private ToolStripMenuItem menuFileSave;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem menuFileExit;
        private ToolStripMenuItem menuHelp;
        private ToolStripMenuItem menuHelpAbout;
        private Label labelDateTime;
        private DateTimePicker dateTimePicker;
        private Label lblPriority;
        private ComboBox cmbPriority;
        private Label lblToDo;
        private TextBox txtDescription;
        private Button btnAdd;
        private ListView listViewTasks;
        private ColumnHeader columnDate;
        private ColumnHeader columnTime;
        private ColumnHeader columnPriority;
        private ColumnHeader ColumnDescription;
        private Button btnDelete;
        private Button btnChange;
        private ToolTip toolTipDateTimePicker;
    }
}
