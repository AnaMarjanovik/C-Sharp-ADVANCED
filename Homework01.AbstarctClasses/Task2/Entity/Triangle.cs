using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Task2.Entity
{
    public class Triangle : IShapeTriangle
    {
        public double a;
        public double h;

        public Triangle()
        {
            
        }

        public Triangle(double a, double h)
        {
            this.a = a;
            this.h = h;          
        }

        public double GetAreaTriangle(double a,double h)
        {
            return a * h / 2;
        }
    }
}
