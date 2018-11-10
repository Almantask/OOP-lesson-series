using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP_lesson_series.Lesson_2._Inheritance.Professions;

namespace OOP_lesson_series.Lesson_5_Generics
{
    public static class GenericExtension
    {
        public static string Print<T>(this IEnumerable<T> many)
        {
            var fullElements = "";
            foreach (var element in many)
            {
                fullElements += " " + element;
                Console.WriteLine(element);
            }
            return fullElements;
        }

        public static string PrintCollection<T>(this IEnumerable col)
        {
            var genericMany = col as IEnumerable<T>;
            return genericMany.Print();
        }
    }
}
