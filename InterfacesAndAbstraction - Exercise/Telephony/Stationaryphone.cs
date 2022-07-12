using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Telephony
{
    public class Stationaryphone : ICalling
    {
        public string Number { get; set; }
        public Stationaryphone(string number)
        {
            this.Number = number;
            
        }
   

        public void Calling()
        {
            if (this.Number.ToString().Length == 7 && !this.Number.ToString().Any(char.IsLetter))
            {
                Console.WriteLine($"Dialing... {this.Number}");
            }
            else
            {
                Console.WriteLine("Invalid number!");
            }
        }
    }
}
