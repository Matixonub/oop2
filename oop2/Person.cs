using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop2
{
    internal class Person
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public DateTime BirthDate { get; private set; }

        public Person(string firstName, string lastName, DateTime birthDate)
        {
            ValidateName(firstName, nameof(firstName));
            ValidateName(lastName, nameof(lastName));
            ValidateBirthDate(birthDate);

            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
        }
        public Person(string firstName, string lastName, int year, int month, int day)
            : this(firstName, lastName, new DateTime(year, month, day))
        {
        }

        public int GetAge()
        {
            var today = DateTime.Today;
            int age = today.Year - BirthDate.Year;

            if (BirthDate > today.AddYears(-age))
            {
                age--;
            }

            return age;
        }

        public int DaysUntilBirthday()
        {
            var today = DateTime.Today;
            var nextBirthday = new DateTime(today.Year, BirthDate.Month, BirthDate.Day);

            if (nextBirthday < today)
            {
                nextBirthday = nextBirthday.AddYears(1);
            }

            return (nextBirthday - today).Days;
        }

        public string GetPersonInfo()
        {
            return $"{FirstName} {LastName}, amzius: {GetAge()} metai";
        }

        private void ValidateName(string name, string parameterName)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException($"{parameterName} negali buti tuscias, sudarytas tik is tarpu arba null.");
            }
        }

        private void ValidateBirthDate(DateTime birthDate)
        {
            if (birthDate > DateTime.Today)
            {
                throw new ArgumentException("Gimimo data negali buti ateities data.");
            }
        }

    }
}
