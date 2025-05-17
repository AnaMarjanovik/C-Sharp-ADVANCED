using System;
using System.Collections.Generic;
using System.Linq;
using Task1;  


List<Car> cars = CarsData.Cars;


Console.WriteLine("=== Filter all cars that have origin from Europe and print them in console ===");
// SQL
List<Car> europeanCarsSql = (from car in cars
                             where car.Origin == "Europe"
                             select car).ToList();
// Lambda
List<Car> europeanCarsLambda = cars.Where(car => car.Origin == "Europe").ToList();

Console.WriteLine("========= SQL syntax =========");
foreach (Car car in europeanCarsSql)
    Console.WriteLine($"{car.Model} ({car.Origin})");

Console.WriteLine("========= Lambda syntax =========");
foreach (Car car in europeanCarsLambda)
    Console.WriteLine($"{car.Model} ({car.Origin})");




Console.WriteLine("\n=== Filter all cars that have more that 6 Cylinders not including 6 after " +
    "that Filter all cars that have exactly 4 Cylinders and have HorsePower more then 110.0. Join " +
    "them in one result and print them in console. ===");
// SQL
List<Car> moreThan6Sql = (from car in cars
                          where car.Cylinders > 6
                          select car).ToList();

List<Car> fourHighHPSql = (from car in cars
                           where car.Cylinders == 4 && car.HorsePower > 110.0
                           select car).ToList();

List<Car> combinedSql = moreThan6Sql.Concat(fourHighHPSql).ToList();
// Lambda
List<Car> combinedLambda = cars.Where(car => car.Cylinders > 6)
                               .Concat(cars.Where(car => car.Cylinders == 4 && car.HorsePower > 110.0)).ToList();


Console.WriteLine("========= SQL syntax =========");
foreach (Car car in combinedSql)
    Console.WriteLine($"{car.Model} — Cyl: {car.Cylinders}, HP: {car.HorsePower}");

Console.WriteLine("========= Lambda syntax =========");
foreach (Car car in combinedLambda)
    Console.WriteLine($"{car.Model} — Cyl: {car.Cylinders}, HP: {car.HorsePower}");




Console.WriteLine("\n=== Count all cars based on their Origin and print the result in console. " +
    "Example outpur \"US 10 models\\n Eu 15 Models\"; ===");

// SQL
List<string> countByOriginSql = (from car in cars
                                group car by car.Origin into originGroup
                                select $"{originGroup.Key} {originGroup.Count()} models").ToList();

Console.WriteLine("========= SQL syntax =========");
foreach (string line in countByOriginSql)
{
    Console.WriteLine(line);
}

// Lambda 
List<string> countByOriginLambda = cars.GroupBy(car => car.Origin)
                                       .Select(g => $"{g.Key} {g.Count()} models").ToList();

Console.WriteLine("========= Lambda syntax ========= ");
foreach (string line in countByOriginLambda)
{
    Console.WriteLine(line);
}




Console.WriteLine("\n=== Filter all cars that have more then 200 HorsePower and Find out how much is the " +
    "lowest, highes and average Miles per galon and print them in console; ===");

// SQL
List<Car> hp200Sql = (from car in cars
                      where car.HorsePower > 200
                      select car).ToList();

// Lambda
List<Car> hp200Lambda = cars.Where(car => car.HorsePower > 200).ToList();

if (hp200Sql.Any())
{
    Console.WriteLine("========= SQL syntax =========");
    Console.WriteLine($"Min MPG: {hp200Sql.Min(c => c.MilesPerGalon):F2}");
    Console.WriteLine($"Max MPG: {hp200Sql.Max(c => c.MilesPerGalon):F2}");
    Console.WriteLine($"Avg MPG: {hp200Sql.Average(c => c.MilesPerGalon):F2}");
}

if (hp200Lambda.Any())
{
    Console.WriteLine("========= Lambda syntax =========");
    Console.WriteLine($"Min MPG: {hp200Lambda.Min(c => c.MilesPerGalon):F2}");
    Console.WriteLine($"Max MPG: {hp200Lambda.Max(c => c.MilesPerGalon):F2}");
    Console.WriteLine($"Avg MPG: {hp200Lambda.Average(c => c.MilesPerGalon):F2}");
}




Console.WriteLine("\n=== Find the top 3 fastest accelerating cars:\r\nOrder cars by their AccelerationTime" +
    " in ascending order. Take the top 3 cars from the ordered list. Print the model of each of these top " +
    "3 cars. ===");

// SQL
List<Car> top3Sql = (from car in cars
                     orderby car.AccelerationTime
                     select car).Take(3).ToList();

// Lambda
List<Car> top3Lambda = cars.OrderBy(car => car.AccelerationTime).Take(3).ToList();

Console.WriteLine("========= SQL syntax =========");
foreach (Car car in top3Sql)
    Console.WriteLine(car.Model);

Console.WriteLine("========= Lambda syntax =========");
foreach (Car car in top3Lambda)
    Console.WriteLine(car.Model);




Console.WriteLine("\n=== Calculate the total weight of cars with more than 6 cylinders: " +
    "Filter cars that have more than 6 cylinders. Calculate the total weight of these cars. Print the total weight ===");

// SQL
double totalWeightSql = (from car in cars
                         where car.Cylinders > 6
                         select car.Weight).Sum();

// Lambda
double totalWeightLambda = cars.Where(car => car.Cylinders > 6).Sum(car => car.Weight);

Console.WriteLine($"========= SQL syntax Total Weight: {totalWeightSql:F2}");
Console.WriteLine($"========= Lambda  syntax Total Weight:   {totalWeightLambda:F2}");





Console.WriteLine("\n=== Find the average MilesPerGalon for cars with even number of cylinders: ===");
Console.WriteLine("\n=== Filter cars that have an even number of cylinders. Calculate the average MilesPerGalon for these cars. Print the average MilesPerGalon. ===");

// SQL
List<Car> evenSql = (from car in cars
                     where car.Cylinders % 2 == 0
                     select car).ToList();

// Lambda
List<Car> evenLambda = cars.Where(car => car.Cylinders % 2 == 0).ToList();

if (evenSql.Any())
    Console.WriteLine($"========= SQL syntax Avg MPG: {evenSql.Average(c => c.MilesPerGalon):F2}");
if (evenLambda.Any())
    Console.WriteLine($"========= Lambda syntax Avg MPG:   {evenLambda.Average(c => c.MilesPerGalon):F2}");
