using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.Entities;

namespace Task2.Helpers
{
    public static class MotorBikeExtension
    {
        public static void Wheelie(this MotorBike motorBike)
        {
            Console.WriteLine("Driving on one wheel");
        }
    }
}
