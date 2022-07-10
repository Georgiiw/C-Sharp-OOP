    using System;

namespace AnimalFarm
{
    
    class StartUp
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            try
            {
                Console.WriteLine(new Chicken(name, age));
            }
            catch (ArgumentException e)
            {

                Console.WriteLine(e.Message);
            }
            
                
        }
    }
}
