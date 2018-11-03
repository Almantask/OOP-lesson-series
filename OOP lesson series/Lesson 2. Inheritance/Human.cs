using System;
using OOP_lesson_series.Lesson_1._Classes_and_scope;

namespace OOP_lesson_series.Lesson_2._Inheritance
{
    class Human
    {
        protected BankAccount BankAccount { set; get; }

        private DateTime _birthDateTime;

        public int Age
        {
            get { return CountAge(_birthDateTime); }
        }

        public string Name { set; get; }
        public Birthday BirthDay { set; get; }

        public Human(string name, DateTime birthDateTime)
        {
            Name = name;
            BirthDay = new Birthday(birthDateTime);
            _birthDateTime = birthDateTime;
        }

        private int CountAge(DateTime birthDateTime)
        {
            if(DateTime.Now < birthDateTime)
                throw new Exception("Cannot create people from future");
            var datesDiffer = DateTime.Now - birthDateTime;
            return (int)Math.Ceiling(datesDiffer.TotalDays / 365);
        }

        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age} years.\r\n" +
                   $"Birthday:{BirthDay.Month} {BirthDay.Day}";
        }

        public DateTime GetBirthDateTime()
        {
            return _birthDateTime;
        }
    }

    public class BankAccount : Account
    {
        public decimal Balance { set; get; }
        public BankAccount(string id, string password) : base(id, password)
        {
            Balance = 0;
        }
    }


    public class Account
    {
        private string _id;
        private int _passwordHash;

        public Account(string id, string password)
        {
            _id = id;
            _passwordHash = GetEncryptedHash(password);
        }

        public bool IsValid(string id, string password)
        {
            if (_id != id) return false;
            if (GetEncryptedHash(password) != _passwordHash) return false;
            return true;
        }

        private int GetEncryptedHash(string password)
        {
            return password.GetHashCode();
        }
    }
}
