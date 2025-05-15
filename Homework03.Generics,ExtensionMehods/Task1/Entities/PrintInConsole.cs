using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Entities
{
    public class PrintInConsole
    {
        public void Print<T>(T something1)
        {
            Console.WriteLine(something1);
        }

        public void PrintCollection<T>(List<T> something2)
        {
            foreach(T item in something2)
            {
                Console.WriteLine(item);
            }
        }
    }
}
