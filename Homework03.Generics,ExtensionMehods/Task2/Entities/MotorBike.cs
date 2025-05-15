using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Entities
{
    public class MotorBike : Vehicle
    {
        public override void Display()
        {
            Console.WriteLine("Im a motorbike and i drive on 2 wheels :)");
        }
    }
}