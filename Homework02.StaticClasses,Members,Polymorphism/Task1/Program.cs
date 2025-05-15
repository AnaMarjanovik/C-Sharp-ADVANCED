

using Task1.Entities;

User userById = UserDataBase.SearchById(1);
if(userById != null)
{
    Console.WriteLine($"User found by ID ");
    userById.Display();
}
else
{
    Console.WriteLine("No user found with ID 1.");
}


Console.WriteLine("\n User found by name 'Ana':");
List<User> userByName = UserDataBase.SearchByName("Ana");
if (userByName.Count == 0)
{
    Console.WriteLine("No users found with that name.");
}
else
{
    foreach(User user in userByName)
    {
        user.Display();
    }
}


Console.WriteLine("\n Users found by age 25: ");
List<User> userByAge = UserDataBase.SearchByAge(25);
if(userByAge.Count == 0)
{
    Console.WriteLine("No users found with that age.");
}
else
{
    foreach(User user in userByAge)
    {
        user.Display();
    }
}
