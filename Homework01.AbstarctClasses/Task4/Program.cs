

using Task4.Entities;

Manager manager = new Manager("Ana", "Marjanovik", 23, 54, 25, 100);
Programer programer = new Programer("Sandra", "Simjanovska", 27, 40, 35, 85);

Console.WriteLine("======== Manager ========");
Console.WriteLine(manager.CalculateSalary());
manager.DisplayInfo();



Console.WriteLine("======== Programer ========");
Console.WriteLine(programer.CalculateSalary());
programer.DisplayInfo();
