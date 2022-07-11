using Cars.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cars
{
    public class Seat : ICar
    {
        public string Model { get; set; }

        public string Color { get; set; }
        public Seat(string color, string model)
        {
            Color = color;
            Model = model;
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
            return $"{Color} Seat {Model}\n{Start()}\n{Stop()}";
        }
    }
}
