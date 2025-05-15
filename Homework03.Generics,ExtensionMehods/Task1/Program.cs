
using Task1.Entities;

PrintInConsole p = new PrintInConsole();
p.Print("Hello");
p.Print(2025);
p.Print(true);
p.Print(3.14);

List<string> students = new List<string> { "Simona", "Ana", "Sandra", "Angel" };
p.PrintCollection(students);

