using System;

namespace OOP_lesson_series.Lesson_6_Events
{
    public class ReportEventStartArgs : EventArgs
    {
        public string Name { set; get; }

        public ReportEventStartArgs(string name)
        {
            Name = name;
        }
    }
}