using System;

namespace OOP_lesson_series.Lesson_2._Inheritance.Professions
{
    class Leutenant:MilitaryCommander
    {

        public Leutenant(string name, DateTime birthDateTime, decimal salary) : base(name, birthDateTime, salary)
        {
            Rank = MilitaryRank.Leutenant;
        }

        public Leutenant(Soldier soldier) : base(soldier)
        {
            Rank = MilitaryRank.Leutenant;
        }

        public override Soldier Promote()
        {
            return new General(this);
        }

        public override Soldier Demote()
        {
            return new Recruit(this);
        }
    }
}
