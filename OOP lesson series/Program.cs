/* _____________________________________Storm312_____________________________________________
 *
 * ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
 * ~~~~~~~~ William M-W ~~~~~~~~
 * ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
 * 
 */

// Including scope of a namespace

using System;
using System.Runtime.CompilerServices;
using OOP_lesson_series.Lesson_One._Classes_and_scope;

// Main program namespace
namespace OOP_lesson_series
{
    // Holder of starting point of a program
    class Program
    {
        // Starting point of a program
        static void Main(string[] args)
        {
            Baby baby1 = null;
            Baby baby2 = null;
            Baby baby3 = null;
            Baby baby4 = null;
            Baby baby5 = null;

            baby1 = new Baby();
            baby2 = new Baby("Michael");
            baby3 = TryCreateBaby("Ronny", new DateTime(2018, 5, 4));
            baby4 = TryCreateBaby("Questionable", new DateTime(2019, 12, 12));
            baby5 = TryCreateBaby("Questionable", new DateTime(2006, 12, 12));


            Baby[] babies = { baby1, baby2, baby3, baby4 };
            foreach (Baby baby in babies)
            {
                if(baby != null)
                    Console.WriteLine(baby);
            }
        }

        private static Baby TryCreateBaby(string name, DateTime date)
        {
            Baby baby = null;
            try
            {
                baby = new Baby(name, date);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Invalid baby:{e.Message}");
            }

            return baby;
        }
    }
}
