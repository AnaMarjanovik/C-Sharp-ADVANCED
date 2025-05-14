using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.Entity
{
    public abstract class Shape
    {
        public double strana;

        public Shape(double strana)
        {
            this.strana = strana;
        }

        public abstract double CalculateArea();


        public abstract double CalculatePerimeter();
       
    }
}
