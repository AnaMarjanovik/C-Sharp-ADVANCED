using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Entity
{
    public class Rectangle : IShapeRectangle
    {
        public double a;
        public double b;

        public Rectangle()
        {

        }

        public Rectangle(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public double GetAreaRectangle(double a,double b)
        {

            return a * b;

        }

       
    }
}
