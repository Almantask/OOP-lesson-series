using System;
using OOP_lesson_series.Lesson_2._Inheritance.Professions;

namespace OOP_lesson_series.Lesson_5_Generics
{
    public static class Lesson5
    {
        public static void Run()
        {
            GenericCollectionPrintTest();
            Console.ReadLine();
        }

        private static void GenericMethodExample()
        {
            var output = GenericTest.ReturnGenericParam(5);
            GenericTest.PrintToConsole(output);
            var output1 = GenericTest.ReturnGenericParam("Hello");
            GenericTest.PrintToConsole(output1);
            var output2 = GenericTest.ReturnGenericParam(111.55f);
            GenericTest.PrintToConsole(output2);
            var output3 = GenericTest.ReturnGenericParam(true);
            GenericTest.PrintToConsole(output3);
            var cleaner = new Cleaner("Dirk", DateTime.Now, 600);
            var output4 = GenericTest.ReturnGenericParam(cleaner);
            GenericTest.PrintToConsole(output4);
            Console.ReadLine();
        }

        private static void SimulateSuccess()
        {
            SimulateReuqestSuccess(5);
            SimulateReuqestSuccess("Hello");
            SimulateReuqestSuccess(111.55f);
            SimulateReuqestSuccess(true);
            var cleaner = new Cleaner("Dirk", DateTime.Now, 600);
            SimulateReuqestSuccess(cleaner);
        }

        private static void SimulateReuqestSuccess<T>(T input)
        {
            var successfulResponse = new DataResponse<T>(input);
            GenericTest.PrintToConsole(successfulResponse);
        }

        private static void SimulateFails()
        {
            SimulateReuqestFail(5);
            SimulateReuqestFail("Hello");
            SimulateReuqestFail(111.55f);
            SimulateReuqestFail(true);
            var cleaner = new Cleaner("Dirk", DateTime.Now, 600);
            SimulateReuqestFail(cleaner);
        }

        private static void SimulateReuqestFail<T>(T input)
        {
            try
            {
                //  Do something
                throw new Exception("Failed to do something");
            }
            catch(Exception ex)
            {
                var successfulResponse = new DataResponse<T>(input, ex.ToString());
                GenericTest.PrintToConsole(successfulResponse);
            }
        }

        private static void GenericCollectionPrintTest()
        {
            var cleaner = new Cleaner("Tom", new DateTime(1994, 11, 20), 600);
            var firefighter = new Firefighter("Jack", new DateTime(1987, 5, 5), 1000);
            var leutenant = new Leutenant("Igor", new DateTime(1947, 5, 5), 2000);
            var general = new General("Daniel", new DateTime(1958, 6, 2), 3060);
            Profession[] profesions = {cleaner, firefighter, leutenant, general};
            profesions.Print();
        }
    }
}

