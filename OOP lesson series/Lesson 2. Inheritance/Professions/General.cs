using System;

namespace OOP_lesson_series.Lesson_2._Inheritance.Professions
{
    class General: MilitaryCommander
    {
        
        public General(string name, DateTime birthDateTime, decimal salary) : base(name, birthDateTime, salary)
        {
            Rank = MilitaryRank.General;
        }

        public General(Soldier soldier) : base(soldier)
        {
            Rank = MilitaryRank.General;
        }

        public override Soldier Promote()
        {
            return this;
        }
    }
}
