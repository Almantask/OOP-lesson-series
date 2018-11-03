using System;

namespace OOP_lesson_series.Lesson_2._Inheritance.Professions
{
    class Profession:Human
    {
        public decimal Salary { set; get; }

        public Profession(string name, DateTime birthDateTime, decimal salary) : base(name, birthDateTime)
        {
            Salary = salary;
        }

        public void GetPaidForMonthlyWork()
        {
            BankAccount.Balance += Salary;
        }

        public virtual void Work()
        {
            throw new NotImplementedException();
        }
    }
}
