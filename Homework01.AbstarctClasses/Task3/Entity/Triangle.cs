using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Task3.Entity
{
    public class Triangle : Shape
    {
        public int h;
        public int b;
        public int c;

        public Triangle(int strana, int h, int b, int c): base(strana)
        {
            this.h = h;
            this.b = b;
            this.c = c;
        }

        public override double CalculateArea()
        {
            return (strana * h) / 2;
        }

        public override double CalculatePerimeter()
        {
            return strana + b + c;
        }
    }
}
