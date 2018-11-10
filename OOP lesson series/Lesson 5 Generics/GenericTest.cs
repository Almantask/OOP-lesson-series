using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP_lesson_series.Lesson_2._Inheritance.Professions;

namespace OOP_lesson_series.Lesson_5_Generics
{
    public static class GenericTest
    {
        public static T ReturnGenericParam<T>(T input)
        {
            return input;
        }

        public static void PrintToConsole(object input)
        {
            Console.WriteLine(input);
        }
    }
}
