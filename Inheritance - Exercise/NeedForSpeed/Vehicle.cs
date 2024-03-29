﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    public class Vehicle
    {
        public int HorsePower { get; set; }
        public double Fuel { get; set; }
        public double FuelConsumption { get; set; }
        public double DefaultFuelConsumption { get; set; }

        public Vehicle(int horsePower, double fuel)
        {
            HorsePower = horsePower;
            Fuel = fuel;
        }
        
        public virtual void Drive(double kilometers)
        {
            this.DefaultFuelConsumption = 1.25;
            this.Fuel -= kilometers *this.DefaultFuelConsumption;
        }
    }
}
