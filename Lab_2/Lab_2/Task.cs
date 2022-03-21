using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2
{
    enum TaskStatus
    {
        Waiting,
        Progress,
        Done,
        Rejected
    }
    class Task
    {
        private string name;
        private TaskStatus status;

        public string Name { get => this.name; }
        public TaskStatus Status { get => this.status; }

        public Task(string name,TaskStatus status)
        {
            this.name = name;
            this.status = status;
        }
        public override string ToString()
        {
            return this.name + " [" + this.status.ToString() + "]";
        }
        public bool Equals(Task other)
        {
            return this.name == other.name && this.status == other.status;
        }

    }
}
