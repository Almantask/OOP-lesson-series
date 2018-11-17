using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OOP_lesson_series.Lesson_6_Events
{
    class Lesson6
    {
        //the same
        public delegate void DelegateAction1(int num);
        private DelegateAction1 Delegate1;
        // as this
        private Action<int> Action1;
        private Func<int, int> Function1;
        //private Predicate<>

        public void Run()
        {
            var command1 = new Command1("First command", 25);
            var command2 = new Command2("Second command",25);
            var command3 = new Command3("Third command", 25);
            var command4 = new Command4("Fourth command", 25);
           
            var commandRunner = new CommandRunner();
            var commands = new Command[] {command1, command2, command3, command4};
            foreach (var command in commands)
            {
                commandRunner.AddCommand(command);
            }

            commandRunner.Run();
        }

        private void UnhandledExceptionTest()
        {
            AppDomain.CurrentDomain.UnhandledException += CurrentDomainOnUnhandledException;

            //Action1 = DoSomethingAction;
            //Delegate1 = DoSomethingAction;
            //Function1 = DomsomethingFunction;

            //Action1?.Invoke(5);
            //Delegate1(5);
            //var result = Function1(5);

            throw new Exception("I HAVE THE POWER OF GOD AND ANIME ON MY SIDE!");
        }
                
        private void CurrentDomainOnUnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            var exception = ((Exception) e.ExceptionObject);
            Console.WriteLine(exception.Message);
            
        }

        private int DomsomethingFunction(int num)
        {
            return num;
        }

        private static void DoSomethingAction(int num)
        {
            Console.WriteLine("Action called. Params:" + num);
        }
    }
}

   
