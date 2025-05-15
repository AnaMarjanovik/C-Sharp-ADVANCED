using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public User()
        {
            
        }

        public User(int id, string name, int age)
        {
            this.Id = id;
            this.Name = name;
            this.Age = age;
        }

        public void Display()
        {
            Console.WriteLine($"Id: {Id} | Name: {Name} | Age: {Age} ");
        }

    }
}
