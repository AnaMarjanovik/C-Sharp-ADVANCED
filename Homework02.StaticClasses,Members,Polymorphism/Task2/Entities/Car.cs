using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Entities
{
    public class Car : Vehicle
    {
        public override void Display()
        {
            Console.WriteLine("Im a car and i drive on 4 wheels:)");
        }
    }
}
