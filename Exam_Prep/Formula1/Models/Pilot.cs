using Formula1.Models.Contracts;
using Formula1.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Formula1.Models
{
    public class Pilot : IPilot
    {
        private string fullName;
        private bool canRace = false;
        private int numberOfWins;
        private IFormulaOneCar car;
        public Pilot(string fullName)
        {
            this.FullName = fullName;
        }
        public string FullName
        {
            get { return fullName; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 5)
                {
                    throw new ArgumentException(String.Format(ExceptionMessages.InvalidPilot, value));
                }
                fullName = value;
            }
        }     

        public int NumberOfWins
        {
            get {  return this.numberOfWins; }
            private set { this.numberOfWins = value; }
        }

        public bool CanRace
        {
            get { return this.canRace; }
            private set
            {
               
                this.canRace = value;
            }
        }

        public IFormulaOneCar Car
        { 
            get { return this.car; }
            private set
            {
                if (value == null)
                {
                    throw new NullReferenceException("Pilot car can not be null.");
                }
                this.car = value;
            }
        }

        public void AddCar(IFormulaOneCar car)
        {
            this.Car = car;
            this.CanRace = true;
        }

        public void WinRace()
        {
            this.NumberOfWins++;
        }
        public override string ToString()
        {
            return $"Pilot {this.FullName} has {this.NumberOfWins} wins.";
        }
    }
}
