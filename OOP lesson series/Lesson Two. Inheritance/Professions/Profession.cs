using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_lesson_series.Lesson_Two._Inheritance
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
