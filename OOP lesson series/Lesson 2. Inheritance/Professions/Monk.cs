using System;

namespace OOP_lesson_series.Lesson_2._Inheritance.Professions
{
    class Monk: Profession
    {
        public Monk(string name, DateTime birthDateTime, decimal salary) : base(name, birthDateTime, salary)
        {
        }

        public override void Work()
        {
            Console.WriteLine("Praying");
        }
    }
}
