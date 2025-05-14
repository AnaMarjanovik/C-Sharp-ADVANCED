using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4.Entities
{
    public class Manager : Employee
    {
        public int ManagerBonus { get; set; }
        public Manager(string FirstName, string LastName, int Age, int WorkingHours, int MoneyPerHour, int managerBonus) : base(FirstName, LastName, Age, WorkingHours, MoneyPerHour)
        {
            this.ManagerBonus = managerBonus;
        }

        public override float CalculateSalary()
        {
            return WorkingHours * MoneyPerHour + ManagerBonus;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Name: {FirstName} {LastName}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Working hours: {WorkingHours}");
            Console.WriteLine($"Money per hour: {MoneyPerHour}");
            Console.WriteLine($"Manager bonus: {ManagerBonus}");
        }

    }
}
