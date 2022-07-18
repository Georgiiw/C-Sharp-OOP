using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Car : Vehicle
    {
        public Car(double fuelQuantity, double fuelConsumption)
        {
            this.fuelQuantity = fuelQuantity;
            this.fuelConsumption = fuelConsumption + 0.9;
        }      
        public override string Drive(double distance)
        {
            if (distance * this.fuelConsumption <= this.fuelQuantity)
            {
                this.fuelQuantity -= distance * this.fuelConsumption;
                return $"Car travelled {distance} km";
            }

            return "Car needs refueling";

        }
        public override void Refuel(double quantity)
        {
            this.fuelQuantity += quantity;

        }
    }
}
