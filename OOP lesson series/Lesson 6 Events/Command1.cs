using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OOP_lesson_series.Lesson_6_Events
{
    class Command1:Command
    {
        public Command1(string name, int contribution) : base(name, contribution)
        {
        }

        protected override void Execute()
        {
            Thread.Sleep(1000);
            Console.WriteLine("Executing command 1");
        }
    }

    class Command2 : Command
    {
        public Command2(string name, int contribution) : base(name, contribution)
        {
        }

        protected override void Execute()
        {
            Thread.Sleep(1000);
            Console.WriteLine("Executing command 2");
        }
    }

    class Command3 : Command
    {
        public Command3(string name, int contribution) : base(name, contribution)
        {
        }

        protected override void Execute()
        {
            Thread.Sleep(1000);
            Console.WriteLine("Executing command 3");
        }
    }

    class Command4 : Command
    {
        public Command4(string name, int contribution) : base(name, contribution)
        {
        }

        protected override void Execute()
        {
            Thread.Sleep(1000);
            Console.WriteLine("Executing command 4");
        }
    }
}
