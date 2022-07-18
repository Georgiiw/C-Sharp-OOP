using System;

namespace Vehicles
{
    public class Program
    {
        static void Main()
        {
            string[] carInfo = Console.ReadLine().Split(" ");
            double fuelQuantityCar = double.Parse(carInfo[1]);
            double fuelConsumptionCar = double.Parse(carInfo[2]);
            string[] truckInfo = Console.ReadLine().Split(" ");
            double fuelQuantityTruck = double.Parse(truckInfo[1]);
            double fuelConsumptionTruck = double.Parse(truckInfo[2]);

            Vehicle car = new Car(fuelQuantityCar, fuelConsumptionCar);
            Vehicle truck = new Truck(fuelQuantityTruck, fuelConsumptionTruck);

            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                string[] cmd = Console.ReadLine().Split();
                if (cmd[0] == "Drive")
                {
                    if (cmd[1] == "Car")
                    {
                        Console.WriteLine(car.Drive(double.Parse(cmd[2])));
                    }
                    else if (cmd[1] == "Truck")
                    {
                        Console.WriteLine(truck.Drive(double.Parse(cmd[2])));
                        
                    }
                }
                else if (cmd[0] == "Refuel")
                {
                    if (cmd[1] == "Car")
                    {
                        car.Refuel(double.Parse(cmd[2]));
                    }
                    else if (cmd[1] == "Truck")
                    {
                        truck.Refuel(double.Parse(cmd[2]));
                    }
                }
            }
            Console.WriteLine($"Car: {car.fuelQuantity:f2}");
            Console.WriteLine($"Truck: {truck.fuelQuantity:f2}");
            
        }
    }
}
