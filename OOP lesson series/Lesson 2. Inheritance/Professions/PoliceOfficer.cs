using System;

namespace OOP_lesson_series.Lesson_2._Inheritance.Professions
{
    class PoliceOfficer: Profession
    {
        public PoliceOfficer(string name, DateTime birthDateTime, decimal salary) : base(name, birthDateTime, salary)
        {
        }
    }
}
