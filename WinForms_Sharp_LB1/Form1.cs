using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace WinForms_Sharp_LB1
{
    public partial class taskManager : Form
    {
        List<(string task, int minutes)> arr;

        string[] log;
        int tempIndex;
        public taskManager()
        {
            arr = new List<(string task, int minutes)>();
            log = new string[0];
            tempIndex = 0;
            InitializeComponent();
        }

        private int countSpendTime()
        {
            int result = 0;

            for (int i = 0; i < arr.Count; i++)
            {
                result += arr[i].minutes;
            }

            return result;
        }

        private void taskManager_Load(object sender, EventArgs e)
        {
            taskInputTextBox.AddPlaceholder("Нова задача");
            timeTextBox.AddPlaceholder("Запланований час виконання");

            MaximizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedSingle;

            StreamReader f = new StreamReader("data");
            int count = 0;
            string temp_str = "";
            int temp_int;
            while (!f.EndOfStream)
            {
                if (count == 0)
                {
                    temp_str = f.ReadLine();
                    count++;
                }
                else
                {
                    Int32.TryParse(f.ReadLine(), out temp_int);
                    arr.Add((temp_str, temp_int));
                    count--;
                }
            }
            f.Close();

            addInfoToDataGridView();

            labelTime.Text = "На цей список завдань необхідно витратити час (в хв): " + countSpendTime().ToString();
        }


        private void AddLog<type>(ref type[] array, type newData)
        {
            int size = array.Length + 1;
            type[] newArray = new type[size];

            for (int i = 0; i < size; i++)
            {
                if (size - 1 != i)
                    newArray[i] = array[i];
                else
                    newArray[i] = newData;
            }
            array = newArray;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (buttonAdd.Text == "Add task")
            {
                int result;
                Int32.TryParse(timeTextBox.Text, out result);

                if (taskInputTextBox.Text == "Нова задача" || taskInputTextBox.Text == "")
                    MessageBox.Show("Введіть текст задачі!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (timeTextBox.Text == "Запланований час виконання" || timeTextBox.Text == "")
                    MessageBox.Show("Введіть приблизний час виконання!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (result <= 0)
                    MessageBox.Show("Неправильний формат часу!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    bool check = checkRepeat(taskInputTextBox.Text);
                    if (check)
                        MessageBox.Show("Така задача вже існує!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        arr.Add((taskInputTextBox.Text, result));

                        dataGridView1.Rows.Add(arr.Count, taskInputTextBox.Text, result);
                        string temp = "User add new task '" + taskInputTextBox.Text + "'";
                        AddLog(ref log, temp);

                        taskInputTextBox.AddPlaceholder("Нова задача");
                        timeTextBox.AddPlaceholder("Запланований час виконання");
                        labelTime.Text = "На цей список завдань необхідно витратити час (в хв): " + countSpendTime().ToString();
                    }
                }
            }
            else
            {
                if (taskInputTextBox.Text == "Нова задача")
                {
                    arr.RemoveAt(tempIndex);
                    addInfoToDataGridView();
                    labelTime.Text = "На цей список завдань необхідно витратити час (в хв): " + countSpendTime().ToString();
                }
                else
                {
                    bool check = checkRepeat(taskInputTextBox.Text);
                    if (check && taskInputTextBox.Text != arr[tempIndex].task)
                        MessageBox.Show("Така задача вже існує!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        int tempParse;
                        Int32.TryParse(timeTextBox.Text, out tempParse);
                        if (tempParse <= 0)
                            MessageBox.Show("Неправильний формат часу!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                        {
                            string temp = "User change task '" + arr[tempIndex].task + "' to '" + taskInputTextBox.Text + "'";
                            AddLog(ref log, temp);

                            arr[tempIndex] = (taskInputTextBox.Text, tempParse);
                            addInfoToDataGridView();
                            buttonAdd.Text = "Add task";
                            taskInputTextBox.AddPlaceholder("Нова задача");
                            timeTextBox.AddPlaceholder("Запланований час виконання");
                            tempIndex = 0;
                            labelTime.Text = "На цей список завдань необхідно витратити час (в хв): " + countSpendTime().ToString();
                        }
                    }
                }
            }
        }


        private void buttonRemoveAllTask_Click(object sender, EventArgs e)
        {
            DialogResult pressedButton = MessageBox.Show(
                "Ви точно бажаєте видалити всі задачі?",
                "Warning",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );
            if (pressedButton == DialogResult.Yes)
            {
                arr = new List<(string task, int minutes)>();
                dataGridView1.Rows.Clear();

                string temp = "User remove all tasks!";
                AddLog(ref log, temp);
                labelTime.Text = "На цей список завдань необхідно витратити час (в хв): " + countSpendTime().ToString();
            }
        }

        private void buttonOneRemoveTask_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
                MessageBox.Show("Оберіть будь-який пункт!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                DialogResult pressedButton = MessageBox.Show(
                    "Ви точно бажаєте видалити цю задачу?",
                    "Warning",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );
                if (pressedButton == DialogResult.Yes)
                {
                    string temp = "User remove task '" + arr[dataGridView1.CurrentRow.Index].task + "'";
                    AddLog(ref log, temp);
                    
                    arr.RemoveAt(dataGridView1.CurrentRow.Index);
                    addInfoToDataGridView();
                    labelTime.Text = "На цей список завдань необхідно витратити час (в хв): " + countSpendTime().ToString();
                }
            }
        }


        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
                MessageBox.Show("Оберіть необхідне завдання для зміни!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (arr.Count == 0)
                MessageBox.Show("Зараз немає жодного завдання!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (dataGridView1.CurrentRow.Index == arr.Count)
                MessageBox.Show("Не правильно обраний пункт!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                taskInputTextBox.ForeColor = Color.Black;
                taskInputTextBox.Text = arr[dataGridView1.CurrentRow.Index].task;
                timeTextBox.ForeColor = Color.Black;
                timeTextBox.Text = arr[dataGridView1.CurrentRow.Index].minutes.ToString();
                buttonAdd.Text = "Done";
                tempIndex = dataGridView1.CurrentRow.Index;
            }
        }


        private bool checkRepeat(string data)
        {
            bool result = false;

            for (int i = 0; i < arr.Count; i++)
            {
                if (arr[i].task == data)
                {
                    result = true;
                    break;
                }
            }

            return result;
        }


        private void addInfoToListBox<type>(ListBox list, ref type[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                list.Items.Add(array[i]);
            }
        }

        private void addInfoToDataGridView()
        {
            dataGridView1.Rows.Clear();
            for (int i = 0; i < arr.Count; i++)
            {
                dataGridView1.Rows.Add(i + 1, arr[i].task, arr[i].minutes);
            }
        }


        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AboutBox ab = new AboutBox();
            ab.Show();
        }

        private void deleteHistoryButton_Click(object sender, EventArgs e)
        {
            DialogResult pressedButton = MessageBox.Show(
                "Ви точно бажаєте видалити історію?", 
                "Warning", 
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Warning
            );
            if (pressedButton == DialogResult.Yes)
                log = new string[0];
        }

        private void ShowHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListBox historyListBox = new ListBox()
            {
                Width = 600,
                Height = 400,
                Location = new Point(100, 50)
            };

            Form HistoryDialog = new Form()
            {
                Width = 800,
                Height = 550,
                StartPosition = FormStartPosition.CenterScreen,
                MaximizeBox = false,
                MinimizeBox = false,
                FormBorderStyle = FormBorderStyle.FixedSingle,
                Text = "Історія роботи планувальника"
            };

            HistoryDialog.Show();
            addInfoToListBox(historyListBox, ref log);
            HistoryDialog.Controls.Add(historyListBox);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string tempSave = "";

            for (int i = 0; i < arr.Count; i++)
            {
                tempSave += arr[i].task + '\n' + arr[i].minutes;
                if (i != arr.Count - 1)
                    tempSave += "\n";
            }
            File.WriteAllText("data", tempSave);
            Application.Exit();
        }
    }
}
