using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.Entities;

namespace Task2.Helpers
{
    public static class AirplaneExtension
    {
        public static void Fly(this Airplane airplane)
        {
            Console.WriteLine("Flying");
        }
    }
}
