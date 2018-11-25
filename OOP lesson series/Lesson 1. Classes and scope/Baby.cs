 
//{
//    // Scope one code
//}
//{
//    // Scope 2 cannot see scope 1, but it can scope 3
//   {
//      Scope 3
//   }
//}
// Lets us use a different namespace

using System;

// Virtual folder in which our class resides. Big scope
namespace OOP_lesson_series.Lesson_1._Classes_and_scope
{
    // Access modifiers:
    // Private- can only be used inside of a class
    // Protected- (for now not important)- just like private, but gets inherited
    // Public- can be accessed outside of the class

    // Class-blueprint of for making objects
    // Medium scope
    public class Baby
    {
        private int BABY_MAX_MONTHS = 36;
        // Property: setter and/or getter of a class variable
        public string Name
        {
            
            // Very small scope
            set { _name = value; }
            get { return _name; }
        }
        // Field - class variable
        string _name;

        // Auto property
        public int Months { set; get; }
        public Birthday Birthday { set; get; }
        
        // can you please explane why you used an Overide in the ToString methode!!
        // 
        // so it's alredyy'created somewhere and can't be change it unlesse using the override keyword!!
        // XD LOOOOL
        // come on storm , count to 5 XD
        // 1
        // 2
        // 3
        // 4
        // 5
        // done
        public Baby()
        {
            _name = "John";
            Months = 0;
            Birthday = new Birthday(DateTime.Now);
        }

        public Baby(string name, DateTime birthdate)
        {
            _name = name;
            Months = CountBabyMonths(birthdate);
            Birthday = new Birthday(birthdate);
        }

        public Baby(string name)
        {
            _name = name;
            Months = 0;
            Birthday = new Birthday(DateTime.Now);
        }

        private int CountBabyMonths(DateTime birthdate)
        {
            if (birthdate > DateTime.Now)
                throw new FutureBabyException("No future babies allowed");
            TimeSpan birthdateDifference = DateTime.Now - birthdate;
            var monthsDifference = (int)Math.Floor(birthdateDifference.TotalDays / 30);
            if (monthsDifference > BABY_MAX_MONTHS)
                throw new BabyTooOldException($"This baby is too old:{monthsDifference} " +
                                    $"months old is more than {36} months limit for a baby");
            return monthsDifference;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Age: {Months} months.\r\n" +
                   $"Birthday:{Birthday.Month} {Birthday.Day}";
        }
    }
}
