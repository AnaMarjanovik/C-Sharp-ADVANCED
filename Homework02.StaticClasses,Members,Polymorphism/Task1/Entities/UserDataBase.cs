using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Entities
{
    public static class UserDataBase
    {
        public static List<User> Users = new List<User>
        {
            new User(1, "Ana", 23),
            new User(2, "Marija", 26),
            new User(3, "Simona", 24),
            new User(4, "Sandra", 27),
            new User(5, "Angel", 27)
        };

        public static User SearchById(int id)
        {
            foreach(User user in Users)
            {
                if(user.Id == id)
                {
                    return user;
                }
            }
            return null;   
        }

        public static List<User> SearchByName(string name)
        {
            List<User> result = new List<User>();
            foreach (User user in Users)
            {
                if (user.Name.ToLower() == name.ToLower())
                {
                    result.Add(user);
                }
            }
            return result;
        }


        public static List<User> SearchByAge(int age)
        {
            List<User> result = new List<User>();
            foreach (User user in Users)
            {
                if (user.Age == age)
                {
                    result.Add(user);
                }
            }
            return result;
        }

    }
}
