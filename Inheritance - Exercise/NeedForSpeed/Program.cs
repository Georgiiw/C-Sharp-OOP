using System;

namespace NeedForSpeed
{
    public class StartUp
    {
        static void Main()
        {
            int horsePower = int.Parse(Console.ReadLine());
            double fuel = double.Parse(Console.ReadLine());
            double kilometres = double.Parse(Console.ReadLine());
            SportCar sportCar = new SportCar(horsePower, fuel);
            sportCar.Drive(kilometres);
            Console.WriteLine($"Kilometres driven: {kilometres}, Fuel consumed: {sportCar.Fuel}");

        }
    }
}
