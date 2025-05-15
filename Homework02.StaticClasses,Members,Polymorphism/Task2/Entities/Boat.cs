using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Entities
{
    public class Boat : Vehicle
    {
        public override void Display()
        {
            Console.WriteLine("Im a boat and i do not have wheels :(");
        }
    }
}
