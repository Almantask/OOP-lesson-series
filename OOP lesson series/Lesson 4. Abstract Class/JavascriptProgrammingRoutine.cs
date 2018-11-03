using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OOP_lesson_series.Lesson_4._Abstract_Class
{
    public class JavascriptProgrammingRoutine : ProgrammerRoutine
    {
        public JavascriptProgrammingRoutine(DateTime dayStart, int hoursToSleep) : base(dayStart, hoursToSleep)
        {
        }

        protected override void Code()
        {
            ResolveDependensies();
            CreateDependencies();
            UseDependencies();
        }

        private void ResolveDependensies()
        {
            Report("Resolving dependencies");
        }

        private void CreateDependencies()
        {
            Report("Creating dependencies");
        }

        private void UseDependencies()
        {
            Report("Using dependencies");
        }
    }
}
