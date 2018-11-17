using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OOP_lesson_series.Lesson_6_Events
{
    class PoorCommand
    {
        protected void Execute()
        {
            Console.WriteLine("Poor command is starting");

            Thread.Sleep(1000);
            Console.WriteLine("Executing command 3");

            Console.WriteLine("Poor command is ending " + 25 + "%");

        }
    }
}
