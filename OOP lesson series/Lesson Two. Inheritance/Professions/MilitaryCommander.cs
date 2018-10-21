using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_lesson_series.Lesson_Two._Inheritance.Professions
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
