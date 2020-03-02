﻿using System;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private DateTime FormDate;
        public Form1()
        {
            InitializeComponent();
            FormDate = DateTime.Now;
        }
        private void TodaysScheduleButton_Click(object sender, EventArgs e)
        {
            using (Task task = new Task(DateTime.Now))
            {
                dateTimePicker1.Value = task.Date;
                FormDate = dateTimePicker1.Value;
                displayTaskInTextArea(task.Date);
            }
        }
        private void YesterdaysScheduleButton_Click(object sender, EventArgs e)
        {
            using (Task task = new Task(DateTime.Now.AddDays(-1)))
            {
                dateTimePicker1.Value = task.Date;
                FormDate = dateTimePicker1.Value;
                displayTaskInTextArea(task.Date);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            displayTaskInTextArea(DateTime.Now);
        }
        private void AddTaskButton_Click(object sender, EventArgs e)
        {
            if (FormDate.Date < DateTime.Now.Date)
            {
                MessageBox.Show("Cannot add task to this date!!");
            }
            else
            {
                Form2 AddTaskEventHandler = new Form2();
                AddTaskEventHandler.ShowDialog();
                using (Task task = new Task(FormDate))
                {
                    if(!task.AddTask(AddTaskEventHandler.EnteredTask,AddTaskEventHandler.SelectedTime))
                        MessageBox.Show("You already have a schedule at " + AddTaskEventHandler.SelectedTime);
                }
                displayTaskInTextArea(FormDate);
            }
        }
        private void displayTaskInTextArea(DateTime date)
        {
            TaskListArea.Clear();
            if (ENV.IsTaskFileExist(date))
            {
                DateLabel.Text = date.ToShortDateString();
                DayLabel.Text = date.DayOfWeek.ToString();
                using (Task task = new Task(date))
                {
                    if (task.Tasks.Count() == 0)
                    {
                        TaskListArea.AppendText("Hurray, You don't have any task!!");
                    }
                    int i = 0;
                    foreach (SingleTask eachtask in task.Tasks)
                    {
                        TaskListArea.AppendText(++i + eachtask.TimeCreated.ToString().Substring(0, 8).PadLeft(9 + 15) + eachtask.Task.PadLeft(eachtask.Task.Length + 25) + "\n");
                    }
                }
            }
            else
            {
                TaskListArea.AppendText("Hurray, You don't have any task!!");
            }
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            FormDate = dateTimePicker1.Value;
            displayTaskInTextArea(FormDate);
        }

        private void DeleteTaskButton_Click(object sender, EventArgs e)
        {
            if (ENV.IsTaskFileExist(FormDate))
            {
                using (Task task = new Task(FormDate))
                {
                    if(task.Tasks.Count > 0)
                    {
                        DeleteForm DeleteTaskEvent = new DeleteForm();
                        DeleteTaskEvent.ShowDialog();
                        int index = DeleteTaskEvent.IndexofTask;
                        if(index > 0 && index <= task.Tasks.Count)
                        {
                            task.deleteTask(index);
                            displayTaskInTextArea(FormDate);
                        }
                        else
                        {
                            MessageBox.Show("invalid index!! try again");
                        }
                    }
                    else
                    {
                        MessageBox.Show("No Taks To delete!!");
                    }
                }
            }
            else
            {
                MessageBox.Show("No Taks To delete!!");
            }
        }
        
    }
}