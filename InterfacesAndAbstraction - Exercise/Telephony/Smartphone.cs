using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Telephony
{
    public class Smartphone : ICalling, IBrowsing
    {
        public string Number { get; set; }
        public string WebAddress { get; set; }
        public Smartphone(string number, string webAddress)
        {
            this.Number = number;
            this.WebAddress = webAddress;
        }

        public void Calling()
        {
            if (this.Number.Any(char.IsLetter))
            {
                Console.WriteLine("Invalid number!");
            }
            else if (this.Number.Length == 10)
            {
                Console.WriteLine($"Calling... {this.Number}");
                
            }
        }
        public void Browsing()
        {
            if (this.WebAddress.Any(char.IsDigit))
            {
                Console.WriteLine("Invalid URL!");
            }
            else
            {
                Console.WriteLine($"Browsing: {this.WebAddress}!");
            }
        }
    }
}
