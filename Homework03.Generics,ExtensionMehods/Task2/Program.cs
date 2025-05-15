using Task2.Entities;
using Task2.Helpers;



Car car = new Car();
MotorBike motorBike = new MotorBike();
Boat boat = new Boat();
Airplane plane = new Airplane();

car.Display();
motorBike.Display();
boat.Display();
plane.Display();

car.Drive();
motorBike.Wheelie();
boat.Sail();
plane.Fly();
