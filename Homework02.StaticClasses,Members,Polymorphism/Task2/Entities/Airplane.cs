using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Entities
{
    public class Airplane : Vehicle
    {
        public override void Display()
        {
            Console.WriteLine("Im a plane and i have a couple of wheels :)");
        }
    }
}
