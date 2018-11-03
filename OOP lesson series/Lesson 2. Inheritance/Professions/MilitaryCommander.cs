using System;
using System.Collections.Generic;

namespace OOP_lesson_series.Lesson_2._Inheritance.Professions
{
    class MilitaryCommander:Soldier
    {
        public List<Soldier> UnitsToCommand { set; get; }

        public MilitaryCommander(string name, DateTime birthDateTime, decimal salary) : base(name, birthDateTime, salary)
        {
        }

        public MilitaryCommander(Soldier soldier) : base(soldier)
        {
        }
    }
}
