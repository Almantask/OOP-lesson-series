using System;

namespace OOP_lesson_series.Lesson_2._Inheritance.Professions
{
    class Teacher: Profession
    {
        public Teacher(string name, DateTime birthDateTime, decimal salary) : base(name, birthDateTime, salary)
        {
        }
    }
}
