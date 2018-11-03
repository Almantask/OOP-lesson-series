using System;

namespace OOP_lesson_series.Lesson_2._Inheritance.Professions
{
    class Nun: Profession
    {
        public Nun(string name, DateTime birthDateTime) : base(name, birthDateTime, 0)
        {
        }

        public override void Work()
        {
            Console.WriteLine("Praying");
        }
    }
}
