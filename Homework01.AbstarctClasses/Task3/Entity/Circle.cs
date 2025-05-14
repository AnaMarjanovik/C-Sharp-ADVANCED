using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Task3.Entity
{
    public class Circle : Shape
    {
       
        public Circle(double strana) : base(strana)
        {
            
        }

        public override double CalculatePerimeter()
        {
            return 2 * strana * 3.14;
        }

        public override double CalculateArea()
        {
            return strana * strana * 3.14;
        }
    }
}
