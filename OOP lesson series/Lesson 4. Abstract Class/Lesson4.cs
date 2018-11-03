using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_lesson_series.Lesson_4._Abstract_Class
{
    public static class Lesson4
    {
        public static void Run()
        {
            var wakeUpTime = new DateTime(2018, 11, 3, 8, 0, 0);
            var javaRoutine = new JavaProgrammerRoutine(wakeUpTime, 6);
            var csharpRoutine = new CSharpProgrammerRoutine(wakeUpTime, 12);
            var javascriptRoutine = new JavascriptProgrammingRoutine(wakeUpTime, 8);

            ProgrammerRoutine[] routines = { javascriptRoutine, csharpRoutine, javaRoutine};
            ADayAtWork(routines);
            Console.ReadLine();
        }

        private static void ADayAtWork(ProgrammerRoutine[] routines)
        {
            foreach (var routine in routines)
            {
                routine.Simulate();
            }
        }
    }
}
