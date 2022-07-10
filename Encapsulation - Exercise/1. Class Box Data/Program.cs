using System;
using System.Text;

namespace ClassBoxData
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            try
            {
                Console.WriteLine(new Box(length, width, height));
            }
            catch (ArgumentException e)
            {

                Console.WriteLine(e.Message);
            }
           
        }
    }
}
