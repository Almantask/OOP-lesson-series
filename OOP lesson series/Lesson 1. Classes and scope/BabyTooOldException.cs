using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_lesson_series.Lesson_1._Classes_and_scope
{
    public class BabyTooOldException :Exception
    {
        public BabyTooOldException(string message) : base(message)
        {

        }
    }
}
