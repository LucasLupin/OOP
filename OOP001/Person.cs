using System;
namespace OOP001
{
    public class Person
    {
        public string? Name { get; set; }

        // public int Age { get; set; }

        public DateTime DoB { get; set; }

        public string? Email { get; set; }

        public int AgeCalculator()
        {
            DateTime today = DateTime.Today;
            int age = today.Year - DoB.Year;
            DateTime check = new DateTime(today.Year, DoB.Month, DoB.Day);

            if (today < check) age--;
            return age;
        }
    }
}

