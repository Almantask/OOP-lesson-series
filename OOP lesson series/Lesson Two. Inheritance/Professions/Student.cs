using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_lesson_series.Lesson_Two._Inheritance
{
    class Student: Profession

    {
        public Student(string name, DateTime birthDateTime) : base(name, birthDateTime, 0)
        {
        }

    }
}
