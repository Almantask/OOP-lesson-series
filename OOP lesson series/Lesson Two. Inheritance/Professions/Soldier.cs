using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_lesson_series.Lesson_Two._Inheritance.Professions
{
    class Soldier: Profession
    {
        public MilitaryRank Rank { set; get; } = MilitaryRank.Recruit;

        public Soldier Authority { set; get; }

        public Soldier(string name, DateTime birthDateTime, decimal salary) : base(name, birthDateTime, salary)
        {
        }

        public Soldier(Soldier soldier) : base(soldier.Name, soldier.GetBirthDateTime(), soldier.Salary)
        {
            Console.WriteLine($"Rank changed from {soldier.Rank} to {Rank}");
        }

        public override void Work()
        {
            Fight();
        }

        public void Fight()
        {
            // fighting logic..
        }

        public virtual Soldier Demote()
        {
            throw new NotImplementedException();
        }

        public virtual Soldier Promote()
        {
            throw new NotImplementedException();
        }
    }
}
