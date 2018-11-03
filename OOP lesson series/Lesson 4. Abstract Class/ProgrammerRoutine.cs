using System;
using System.Diagnostics;
using System.Net.Mime;

namespace OOP_lesson_series.Lesson_4._Abstract_Class
{
    public abstract class ProgrammerRoutine
    {
        public DateTime WakeupTime { set; get; }
        private readonly TimeSpan _sleepTime;
        private readonly TimeSpan _activeTime;

        protected ProgrammerRoutine(DateTime dateStart, int hoursToSleep)
        {
            WakeupTime = dateStart;
            _sleepTime = new TimeSpan(hoursToSleep, 0, 0);
            _activeTime = new TimeSpan(24-hoursToSleep, 0, 0);
            WakeupTime += _sleepTime + _activeTime;
        }

        public void Simulate()
        {
            Start();
            WakeUp();
            Shower();
            Eat("Banana");
            GoTo("Work");
            Code();
            Eat("4 Sausages");
            Code();
            GoTo("Home");
            Eat("Apple");
            Sleep();
            End();
        }

        private void Start()
        {
            Report("Started routine of :" + GetType().ToString());
        }

        private void WakeUp()
        {
            Report("Waking up at " + WakeupTime);
        }

        private void Shower()
        {
            Report("Showering");
        }

        private void Eat(string food)
        {
            Report("Eating " + food);
        }

        private void GoTo(string place)
        {
            Report("Showering");
        }

        protected abstract void Code();

        private void Sleep()
        {
            WakeupTime += _activeTime;
            Report("Going to sleep at " + WakeupTime);
            WakeupTime += _sleepTime;
        }

        private void End()
        {
            Report("Ending routine of :" + GetType().ToString());
        }

        protected void Googling(string text)
        {
            Console.WriteLine("Googling " + text);
            NavigateToGoogle();
            var info = Search(text);
            Process(info);
        }

        private void NavigateToGoogle()
        {
        }

        private string Search(string text)
        {
            return "";
        }

        private void Process(string text)
        {
        }

        protected void Report(string activity)
        {
            Console.WriteLine(activity);
        }
    }
}
