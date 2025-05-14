using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4.Entities
{
    public abstract class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
           
        public int WorkingHours { get; set; }
        public int MoneyPerHour { get; set; }

        public Employee(string firstName, string lastName, int age, int workingHours, int moneyPerHour)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.WorkingHours = workingHours;
            this.MoneyPerHour = moneyPerHour;
        }

        public abstract float CalculateSalary();
        public abstract void DisplayInfo();

    }
}
