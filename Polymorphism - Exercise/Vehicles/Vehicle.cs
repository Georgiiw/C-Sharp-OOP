using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public abstract class Vehicle
    {
        public double fuelQuantity { get; set; }
        public double fuelConsumption { get; set; }    
        public virtual string Drive(double distance)
        {
            return "Drive";
        }
        public virtual void Refuel(double quantity)
        {
           
        }
        

    }
}
