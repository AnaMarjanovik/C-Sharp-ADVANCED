using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4.Entities
{
    public class Programer : Employee
    {
        public int ProgramerBonus { get; set; }
        public Programer(string FirstName, string LastName, int Age, int WorkingHours, int MoneyPerHour, int programerBonus) : base(FirstName, LastName, Age, WorkingHours, MoneyPerHour)
        {
            this.ProgramerBonus = programerBonus;
        }

        public override float CalculateSalary()
        {
            return WorkingHours * MoneyPerHour + ProgramerBonus;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Name: {FirstName} {LastName}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Working hours: {WorkingHours}");
            Console.WriteLine($"Money per hour: {MoneyPerHour}");
            Console.WriteLine($"Programer bonus: {ProgramerBonus}");
        }
    }
}
