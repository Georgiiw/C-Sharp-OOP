using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Truck : Vehicle
    {
        public Truck(double fuelQuantity, double fuelConsumption)
        {
            this.fuelQuantity = fuelQuantity;
            this.fuelConsumption = fuelConsumption + 1.6;
        }
        public override string Drive(double distance)
        {
            if (distance * this.fuelConsumption <= this.fuelQuantity)
            {
                this.fuelQuantity -= distance * this.fuelConsumption;
                return $"Truck travelled {distance} km";
            }

            return "Truck needs refueling";

        }
        public override void Refuel(double quantity)
        {
            this.fuelQuantity += (quantity* 0.95);
            
        }
    }
}
