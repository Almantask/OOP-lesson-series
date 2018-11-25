using System;
using System.Collections;
using System.Collections.Generic;
using OOP_lesson_series.Lesson_1._Classes_and_scope;

namespace LessonTests
{
    public class BabyDataFutureBabiesTest: IEnumerable<object[]>
    {
        private readonly Random _random;
        private readonly int _maxInput = 100;

        public BabyDataFutureBabiesTest()
        {
            _random = new Random();
        }
        public IEnumerator<object[]> GetEnumerator()
        {
            for(var count = 0; count < _maxInput; count++)
                yield return RandomValidInput();
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        private object[] RandomValidInput()
        {
            var now = DateTime.Now;
            var future = now.AddDays(_random.Next(0, 1000));
            return new object[]{future.Year, future.Month, future.Day};
        }
    }
}