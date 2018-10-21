using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_lesson_series.Lesson_Two._Inheritance.Professions
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
