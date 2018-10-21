using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using OOP_lesson_series.Lesson_Two._Inheritance.Professions;

namespace OOP_lesson_series.Lesson_Two._Inheritance
{
    class Lesson2
    {
        public void Run()
        {
            SoldierExperiment();
        }

        public void HumanExperiment()
        {
            var human1 = new Human("Hons", new DateTime(1994, 9, 4));
            var female1 = new Female("Jaina", new DateTime(2004, 3, 14));
            var male1 = new Male("Rick", new DateTime(2000, 4, 17));

            Human[] humans = { human1, female1, male1 };
            foreach (var human in humans)
            {
                Console.WriteLine(human);
            }
        }

        public void SoldierExperiment()
        {
            var soldier1 = new Recruit("Michael", new DateTime(1994, 3, 17), 450);
            var soldier2 = new Leutenant("Michael", new DateTime(1994, 3, 17), 450);
            var soldier3 = new General("Michael", new DateTime(1994, 3, 17), 450);
            var soldier4 = new Recruit("Michael", new DateTime(1994, 3, 17), 450);
            var soldier5 = new Recruit("Michael", new DateTime(1994, 3, 17), 450);

            Soldier[] soldiers = {soldier1, soldier2, soldier3, soldier3, soldier4, soldier5};

            foreach (var soldier in soldiers)
            {
                soldier.Promote();
            }
        }

        
    }
}
