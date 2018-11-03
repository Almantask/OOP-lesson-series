using System;

namespace OOP_lesson_series.Lesson_2._Inheritance.Professions
{
    class Student: Profession

    {
        public Student(string name, DateTime birthDateTime) : base(name, birthDateTime, 0)
        {
        }

    }
}
