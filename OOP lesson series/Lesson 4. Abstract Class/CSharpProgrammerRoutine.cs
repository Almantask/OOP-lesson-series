using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_lesson_series.Lesson_4._Abstract_Class
{
    public class CSharpProgrammerRoutine : ProgrammerRoutine
    {
        public CSharpProgrammerRoutine(DateTime dayStart, int hoursToSleep) : base(dayStart, hoursToSleep)
        {
        }

        protected override void Code()
        {
            Googling("C#");
            Abstracting();
            Googling("C#");
            Implementating();
            Googling("C#");
            Testing();
        }

        private void Testing()
        {
            Report("Testing");
        }

        private void Implementating()
        {
            Report("Implementating");
        }

        private void Abstracting()
        {
            Report("Abstracting");
        }
    }
}
