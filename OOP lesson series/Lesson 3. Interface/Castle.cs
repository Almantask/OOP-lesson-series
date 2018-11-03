using System;
using System.Collections.Generic;

namespace OOP_lesson_series.Lesson_3._Interface
{
    public class Castle: HitPoints, IDamageable
    {
        public List<Tower> Towers { get; }
        public List<Guard> Guards { get; }
        public Gate Gate { set; get; }
        public Wall Wall { set; get; }
        private List<IDamageable> Destructables { set; get; }

        public Castle()
        {
            Towers = new List<Tower>();
            Guards = new List<Guard>();
            Destructables = new List<IDamageable>();
        }

        public Castle(List<Tower> towers, List<Guard> guards)
        {
            Towers = towers;
            Guards = guards;
        }

        public Castle Build()
        {
            Wall = new Wall();
            Gate = new Gate();
            Destructables.Add(Wall);
            Destructables.Add(Gate);
            return this;
        }

        public Castle AddTower()
        {
            var tower = new Tower();
            Destructables.Add(tower);
            Towers.Add(tower);
            return this;
        }

        public Castle AddGuard()
        {
            var guard = new Guard();
            Destructables.Add(guard);
            Guards.Add(guard);
            return this;
        }

        // AOE
        public void Damage(float amount)
        {
            if (Hp > 0)
            {
                Console.WriteLine("An aoe attack: " + amount);
                foreach (var damageAbleElement in Destructables)
                {
                    damageAbleElement.Damage(amount);
                }
            }
        }

        public void Destroy()
        {
            Console.WriteLine("Castle destroyed");
            Hp = 0;
            foreach (var damageAbleElement in Destructables)
            {
                damageAbleElement.Destroy();
            }
        }

        private bool IsAnyTowerAlive()
        {
            var isAnyTowerAlive = true;
            foreach (var tower in Towers)
            {
                if (tower.Hp <= 0)
                {
                    isAnyTowerAlive = false;
                    break;
                }
            }

            return isAnyTowerAlive;
        }
    }
}

/*
⠄⠄⠄⢰⣧⣼⣯⠄⣸⣠⣶⣶⣦⣾⠄⠄⠄⠄⡀⠄⢀⣿⣿⠄⠄⠄⢸⡇⠄⠄
⠄⠄⠄⣾⣿⠿⠿⠶⠿⢿⣿⣿⣿⣿⣦⣤⣄⢀⡅⢠⣾⣛⡉⠄⠄⠄⠸⢀⣿⠄
⠄⠄⢀⡋⣡⣴⣶⣶⡀⠄⠄⠙⢿⣿⣿⣿⣿⣿⣴⣿⣿⣿⢃⣤⣄⣀⣥⣿⣿⠄
⠄⠄⢸⣇⠻⣿⣿⣿⣧⣀⢀⣠⡌⢻⣿⣿⣿⣿⣿⣿⣿⣿⣿⠿⠿⠿⣿⣿⣿⠄
⠄⢀⢸⣿⣷⣤⣤⣤⣬⣙⣛⢿⣿⣿⣿⣿⣿⣿⡿⣿⣿⡍⠄⠄⢀⣤⣄⠉⠋⣰
⠄⣼⣖⣿⣿⣿⣿⣿⣿⣿⣿⣿⢿⣿⣿⣿⣿⣿⢇⣿⣿⡷⠶⠶⢿⣿⣿⠇⢀⣤
⠘⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣽⣿⣿⣿⡇⣿⣿⣿⣿⣿⣿⣷⣶⣥⣴⣿⡗
⢀⠈⢿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡟⠄
⢸⣿⣦⣌⣛⣻⣿⣿⣧⠙⠛⠛⡭⠅⠒⠦⠭⣭⡻⣿⣿⣿⣿⣿⣿⣿⣿⡿⠃⠄
⠘⣿⣿⣿⣿⣿⣿⣿⣿⡆⠄⠄⠄⠄⠄⠄⠄⠄⠹⠈⢋⣽⣿⣿⣿⣿⣵⣾⠃⠄
⠄⠘⣿⣿⣿⣿⣿⣿⣿⣿⠄⣴⣿⣶⣄⠄⣴⣶⠄⢀⣾⣿⣿⣿⣿⣿⣿⠃⠄⠄
⠄⠄⠈⠻⣿⣿⣿⣿⣿⣿⡄⢻⣿⣿⣿⠄⣿⣿⡀⣾⣿⣿⣿⣿⣛⠛⠁⠄⠄⠄
⠄⠄⠄⠄⠈⠛⢿⣿⣿⣿⠁⠞⢿⣿⣿⡄⢿⣿⡇⣸⣿⣿⠿⠛⠁⠄⠄⠄⠄⠄
⠄⠄⠄⠄⠄⠄⠄⠉⠻⣿⣿⣾⣦⡙⠻⣷⣾⣿⠃⠿⠋⠁⠄⠄⠄⠄⠄⢀⣠⣴
⣿⣿⣿⣶⣶⣮⣥⣒⠲⢮⣝⡿⣿⣿⡆⣿⡿⠃⠄⠄⠄⠄⠄⠄⠄⣠⣴⣿⣿⣿
*/
