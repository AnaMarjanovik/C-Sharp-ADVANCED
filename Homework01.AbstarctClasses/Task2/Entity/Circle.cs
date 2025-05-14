using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Entity
{
    public class Circle : IShapeCircle
    {
        public double r;

        public Circle()
        {
            
        }

        public Circle(double r)
        {
            this.r = r;
        }


        public double GetAreaCircle(double r)
        {
            return r * r * 3.14;
        }




    }
}
