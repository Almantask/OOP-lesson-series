using System;

namespace OOP_lesson_series.Lesson_6_Events
{
    public abstract class Command
    {
        public EventHandler<ReportEventStartArgs> OnCommandStart;
        public EventHandler<ReportEventEndArgs> OnCommandEnd;

        public string Name { set; get; }
        public int Contribution { set; get; }

        protected Command(string name, int contribution)
        {
            Name = name;
            Contribution = contribution;
        }

        public void Run()
        {
            var startArgs = new ReportEventStartArgs(Name);
            OnCommandStart?.Invoke(this, startArgs);
            Execute();
            var endArgs = new ReportEventEndArgs(Name, Contribution);
            OnCommandEnd?.Invoke(this, endArgs);
        }

        protected abstract void Execute();
    }
}