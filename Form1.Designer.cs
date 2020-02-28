﻿namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DateLabel = new System.Windows.Forms.Label();
            this.DayLabel = new System.Windows.Forms.Label();
            this.YesterdaysScheduleButton = new System.Windows.Forms.Button();
            this.TodaysScheduleButton = new System.Windows.Forms.Button();
            this.AddTaskButton = new System.Windows.Forms.Button();
            this.TaskListArea = new System.Windows.Forms.RichTextBox();
            this.SerialLabel = new System.Windows.Forms.Label();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.TaskLabel = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Location = new System.Drawing.Point(91, 63);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(45, 17);
            this.DateLabel.TabIndex = 0;
            this.DateLabel.Text = "DATE";
            // 
            // DayLabel
            // 
            this.DayLabel.AutoSize = true;
            this.DayLabel.Location = new System.Drawing.Point(324, 63);
            this.DayLabel.Name = "DayLabel";
            this.DayLabel.Size = new System.Drawing.Size(36, 17);
            this.DayLabel.TabIndex = 1;
            this.DayLabel.Text = "DAY";
            // 
            // YesterdaysScheduleButton
            // 
            this.YesterdaysScheduleButton.Location = new System.Drawing.Point(773, 194);
            this.YesterdaysScheduleButton.Name = "YesterdaysScheduleButton";
            this.YesterdaysScheduleButton.Size = new System.Drawing.Size(197, 42);
            this.YesterdaysScheduleButton.TabIndex = 3;
            this.YesterdaysScheduleButton.Text = "DISPLAY YESTERDAY\'S SCHEDULE";
            this.YesterdaysScheduleButton.UseVisualStyleBackColor = true;
            this.YesterdaysScheduleButton.Click += new System.EventHandler(this.YesterdaysScheduleButton_Click);
            // 
            // TodaysScheduleButton
            // 
            this.TodaysScheduleButton.Location = new System.Drawing.Point(773, 124);
            this.TodaysScheduleButton.Name = "TodaysScheduleButton";
            this.TodaysScheduleButton.Size = new System.Drawing.Size(197, 42);
            this.TodaysScheduleButton.TabIndex = 4;
            this.TodaysScheduleButton.Text = "DISPLAY TODAY\'S SCHEDULE";
            this.TodaysScheduleButton.UseVisualStyleBackColor = true;
            this.TodaysScheduleButton.Click += new System.EventHandler(this.TodaysScheduleButton_Click);
            // 
            // AddTaskButton
            // 
            this.AddTaskButton.Location = new System.Drawing.Point(773, 263);
            this.AddTaskButton.Name = "AddTaskButton";
            this.AddTaskButton.Size = new System.Drawing.Size(197, 42);
            this.AddTaskButton.TabIndex = 5;
            this.AddTaskButton.Text = "ADD TASK";
            this.AddTaskButton.UseVisualStyleBackColor = true;
            this.AddTaskButton.Click += new System.EventHandler(this.AddTaskButton_Click);
            // 
            // TaskListArea
            // 
            this.TaskListArea.Location = new System.Drawing.Point(94, 115);
            this.TaskListArea.Name = "TaskListArea";
            this.TaskListArea.Size = new System.Drawing.Size(650, 393);
            this.TaskListArea.TabIndex = 7;
            this.TaskListArea.Text = "";
            // 
            // SerialLabel
            // 
            this.SerialLabel.AutoSize = true;
            this.SerialLabel.Location = new System.Drawing.Point(91, 95);
            this.SerialLabel.Name = "SerialLabel";
            this.SerialLabel.Size = new System.Drawing.Size(54, 17);
            this.SerialLabel.TabIndex = 9;
            this.SerialLabel.Text = "SL NO.";
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Location = new System.Drawing.Point(170, 95);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(40, 17);
            this.TimeLabel.TabIndex = 10;
            this.TimeLabel.Text = "TIME";
            // 
            // TaskLabel
            // 
            this.TaskLabel.AutoSize = true;
            this.TaskLabel.Location = new System.Drawing.Point(324, 95);
            this.TaskLabel.Name = "TaskLabel";
            this.TaskLabel.Size = new System.Drawing.Size(44, 17);
            this.TaskLabel.TabIndex = 11;
            this.TaskLabel.Text = "TASK";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(94, 13);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 13;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 608);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.TaskLabel);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.SerialLabel);
            this.Controls.Add(this.TaskListArea);
            this.Controls.Add(this.AddTaskButton);
            this.Controls.Add(this.TodaysScheduleButton);
            this.Controls.Add(this.YesterdaysScheduleButton);
            this.Controls.Add(this.DayLabel);
            this.Controls.Add(this.DateLabel);
            this.Name = "Form1";
            this.Text = "DISPLAY TODAYS SHCEDULE";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Label DayLabel;
        private System.Windows.Forms.Button YesterdaysScheduleButton;
        private System.Windows.Forms.Button TodaysScheduleButton;
        private System.Windows.Forms.Button AddTaskButton;
        private System.Windows.Forms.RichTextBox TaskListArea;
        private System.Windows.Forms.Label SerialLabel;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Label TaskLabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

