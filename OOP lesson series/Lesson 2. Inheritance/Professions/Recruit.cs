using System;

namespace OOP_lesson_series.Lesson_2._Inheritance.Professions
{
    class Recruit: Soldier
    {


        public Recruit(string name, DateTime birthDateTime, decimal salary) : base(name, birthDateTime, salary)
        {
        }

        public Recruit(Soldier soldier) : base(soldier)
        {
        }

        public override Soldier Demote()
        {
            return this;
        }

        public override Soldier Promote()
        {
            return new Leutenant(this);
        }
    }
}
