
namespace WinForms_Sharp_LB1
{
    partial class taskManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(taskManager));
            this.buttonAdd = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteHistoryButton = new System.Windows.Forms.ToolStripMenuItem();
            this.taskInputTextBox = new System.Windows.Forms.TextBox();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.buttonOneRemoveTask = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonRemoveAllTask = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Task = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeTextBox = new System.Windows.Forms.TextBox();
            this.labelTime = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdd.Location = new System.Drawing.Point(694, 64);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 24);
            this.buttonAdd.TabIndex = 3;
            this.buttonAdd.Text = "Add task";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem1,
            this.HistoryToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(811, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(48, 20);
            this.fileToolStripMenuItem1.Text = "Файл";
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(154, 22);
            this.aboutToolStripMenuItem1.Text = "Про програму";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.exitToolStripMenuItem.Text = "Вихід";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // HistoryToolStripMenuItem
            // 
            this.HistoryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowHistoryToolStripMenuItem,
            this.deleteHistoryButton});
            this.HistoryToolStripMenuItem.Name = "HistoryToolStripMenuItem";
            this.HistoryToolStripMenuItem.Size = new System.Drawing.Size(143, 20);
            this.HistoryToolStripMenuItem.Text = "Історія планувальника";
            // 
            // ShowHistoryToolStripMenuItem
            // 
            this.ShowHistoryToolStripMenuItem.Name = "ShowHistoryToolStripMenuItem";
            this.ShowHistoryToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.ShowHistoryToolStripMenuItem.Text = "Показати історію";
            this.ShowHistoryToolStripMenuItem.Click += new System.EventHandler(this.ShowHistoryToolStripMenuItem_Click);
            // 
            // deleteHistoryButton
            // 
            this.deleteHistoryButton.Name = "deleteHistoryButton";
            this.deleteHistoryButton.Size = new System.Drawing.Size(169, 22);
            this.deleteHistoryButton.Text = "Видалити";
            this.deleteHistoryButton.Click += new System.EventHandler(this.deleteHistoryButton_Click);
            // 
            // taskInputTextBox
            // 
            this.taskInputTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.taskInputTextBox.Location = new System.Drawing.Point(66, 65);
            this.taskInputTextBox.Name = "taskInputTextBox";
            this.taskInputTextBox.Size = new System.Drawing.Size(414, 23);
            this.taskInputTextBox.TabIndex = 1;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // buttonOneRemoveTask
            // 
            this.buttonOneRemoveTask.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOneRemoveTask.Location = new System.Drawing.Point(660, 222);
            this.buttonOneRemoveTask.Name = "buttonOneRemoveTask";
            this.buttonOneRemoveTask.Size = new System.Drawing.Size(75, 41);
            this.buttonOneRemoveTask.TabIndex = 5;
            this.buttonOneRemoveTask.Text = "Remove one task";
            this.buttonOneRemoveTask.UseVisualStyleBackColor = true;
            this.buttonOneRemoveTask.Click += new System.EventHandler(this.buttonOneRemoveTask_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEdit.Location = new System.Drawing.Point(660, 175);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 41);
            this.buttonEdit.TabIndex = 4;
            this.buttonEdit.Text = "Edit task";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonRemoveAllTask
            // 
            this.buttonRemoveAllTask.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRemoveAllTask.Location = new System.Drawing.Point(660, 269);
            this.buttonRemoveAllTask.Name = "buttonRemoveAllTask";
            this.buttonRemoveAllTask.Size = new System.Drawing.Size(75, 41);
            this.buttonRemoveAllTask.TabIndex = 6;
            this.buttonRemoveAllTask.Text = "Remove all task";
            this.buttonRemoveAllTask.UseVisualStyleBackColor = true;
            this.buttonRemoveAllTask.Click += new System.EventHandler(this.buttonRemoveAllTask_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Task,
            this.Time});
            this.dataGridView1.Location = new System.Drawing.Point(66, 94);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(503, 320);
            this.dataGridView1.TabIndex = 7;
            // 
            // Id
            // 
            this.Id.HeaderText = "id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 35;
            // 
            // Task
            // 
            this.Task.HeaderText = "Завдання";
            this.Task.Name = "Task";
            this.Task.Width = 255;
            // 
            // Time
            // 
            this.Time.HeaderText = "Запланований час (в хв)";
            this.Time.Name = "Time";
            this.Time.Width = 170;
            // 
            // timeTextBox
            // 
            this.timeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.timeTextBox.Location = new System.Drawing.Point(486, 65);
            this.timeTextBox.Name = "timeTextBox";
            this.timeTextBox.Size = new System.Drawing.Size(202, 23);
            this.timeTextBox.TabIndex = 2;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(12, 437);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(38, 15);
            this.labelTime.TabIndex = 14;
            this.labelTime.Text = "label1";
            // 
            // taskManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(811, 461);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.timeTextBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonRemoveAllTask);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonOneRemoveTask);
            this.Controls.Add(this.taskInputTextBox);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.buttonAdd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "taskManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Task Manager";
            this.Load += new System.EventHandler(this.taskManager_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TextBox taskInputTextBox;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button buttonOneRemoveTask;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.ToolStripMenuItem HistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ShowHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteHistoryButton;
        private System.Windows.Forms.Button buttonRemoveAllTask;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox timeTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Task;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.Label labelTime;
    }
}

