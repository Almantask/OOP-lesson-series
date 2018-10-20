using System;

namespace OOP_lesson_series.Lesson_One._Classes_and_scope
{
    public class Birthday
    {
        public int Day { set; get; }
        public Months Month { set; get; }
        public Birthday(DateTime datetime)
        {
            Day = datetime.Day;
            Month = (Months)datetime.Month;
        }
    }
}