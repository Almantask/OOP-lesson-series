using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OOP_lesson_series.Lesson_6_Events
{
    class CommandRunner
    {
        public int Progress { set; get; }
        private List<Command> _steps;

        public CommandRunner()
        {
            _steps = new List<Command>();
        }

        public void Run()
        {
            foreach (var command in _steps)
            {
                command.Run();
            }
        }

        public void Something()
        {
        }

        public void AddCommand(Command command)
        {
            _steps.Add(command);
            command.OnCommandStart += OnCommandStart;
            command.OnCommandEnd += OnCommandEnd;
        }

        public void RemoveCommand(Command command)
        {
            _steps.Remove(command);
            command.OnCommandStart -= OnCommandStart;
            command.OnCommandEnd -= OnCommandEnd;
        }

        private void OnCommandStart(object sender, ReportEventStartArgs e)
        {
            Console.WriteLine($"Starting {e.Name}");
        }

        private void OnCommandEnd(object sender, ReportEventEndArgs e)
        {
            Progress += e.Contribution;
            Console.WriteLine($"Done {e.Name}. {Progress}%");
        }
    }
}
