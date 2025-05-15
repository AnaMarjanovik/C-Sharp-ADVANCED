using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.Entities;

namespace Task2.Helpers
{
    public static class CarExtension
    {
        public static void Drive(this Car car)
        {
            Console.WriteLine("Driving");
        }
    }
}
