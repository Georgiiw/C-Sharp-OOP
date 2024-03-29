﻿using Cars.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cars
{
    public class Tesla : ICar, IElectricCar
    {
        public int Battery { get; set; }

        public string Model { get; set; }

        public string Color { get; set; }
        public Tesla(string model, string color, int baterry)
        {
            Model = model;
            Color = color;
            Battery = baterry;
        }
        public string Start()
        {
            return "Engine start";
        }
        public string Stop()
        {
            return "Breaaak!";
        }
        public override string ToString()
        {
            return $"{Color} Tesla {Model} with {Battery} Batteries\n{Start()}\n{Stop()}";
        }
    }
}
