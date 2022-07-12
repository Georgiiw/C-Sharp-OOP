using System;

namespace Telephony
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split(" ");
            string[] webAddresses = Console.ReadLine().Split(" ");
            foreach (var number in numbers)
            {
                ICalling calling = new Stationaryphone(number);
                ICalling smartPhone = new Smartphone(number, number);
                if (number.Length == 7)
                {
                    calling.Calling();
                }
                else if (number.Length == 10)
                {
                    smartPhone.Calling();
                }              

            }
            foreach (var address in webAddresses)
            {
                IBrowsing smartPhone = new Smartphone(address, address);
                smartPhone.Browsing();


                
            }
        }
    }
}
