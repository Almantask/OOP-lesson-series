using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_lesson_series.Lesson_4._Abstract_Class
{
    public class JavaProgrammerRoutine : ProgrammerRoutine
    {
        public JavaProgrammerRoutine(DateTime dayStart, int hoursToSleep) : base(dayStart, hoursToSleep)
        {
        }

        protected override void Code()
        {
            SipCoffe();
            Googling("Java");
            SipCoffe();
            DoJava();
        }

        private void DoJava()
        {
            Report("Writing java code");
        }

        private void SipCoffe()
        {
            Report("Sipping coffe");
        }
    }
}
