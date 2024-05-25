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
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(MenuMain);
            MainMenuStrip = MenuMain;
            Name = "MainForm";
            Text = "ToDo Reminder by Osman";
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
    }
}
