using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_lesson_series.Lesson_Two._Inheritance
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
