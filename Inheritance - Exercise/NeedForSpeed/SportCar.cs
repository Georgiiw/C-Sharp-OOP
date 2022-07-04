﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    public class SportCar : Car
    {
        public SportCar(int horsePower, double fuel)
        : base(horsePower, fuel)
        {

        }
        public override void Drive(double kilometers)
        {
            this.FuelConsumption = 10;
            this.Fuel -= kilometers * this.FuelConsumption;
        }
    }
}
