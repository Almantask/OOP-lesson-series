using System;

namespace OOP_lesson_series.Lesson_2._Inheritance.Professions
{

    class Cleaner: Profession
    {
        public Cleaner(string name, DateTime birthDateTime, decimal salary) : base(name, birthDateTime, salary)
        {
            
        }

        public override void Work()
        {
            Console.WriteLine("Cleaning stuff");
        }
    }
}
