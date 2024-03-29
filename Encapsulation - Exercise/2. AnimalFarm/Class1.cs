﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalFarm
{
    public class Chicken
    {
        private const int MinAge = 0;
        private const int MaxAge = 15;

        protected string name;
        internal int age;
        public string Name
        {
            get { return name; }
            set
            {
                if (value == null || value == "" || value == " ")
                {
                    throw new ArgumentException("Name cannot be empty.");
                }
                this.name = value;
            }
        }
        public int Age
        {
            get { return age; }
            set             
            {
                if (value < MinAge || value > MaxAge)
                {
                    throw new ArgumentException("Age should be between 0 and 15.");
                }
                this.age = value;
            }
        }
        public Chicken(string name, int age)
        {
            Name = name;
            Age = age;
        }

       

        public double ProductPerDay()
        {
            
                return this.CalculateProductPerDay();
            
        }

        private double CalculateProductPerDay()
        {
            switch (this.Age)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                    return 1.5;
                case 4:
                case 5:
                case 6:
                case 7:
                    return 2;
                case 8:
                case 9:
                case 10:
                case 11:
                    return 1;
                default:
                    return 0.75;
            }
        }
        public override string ToString()
        {
            return $"Chicken {this.Name} (age {this.Age}) can produce {ProductPerDay()} eggs per day.".ToString();
        }
    }
}
