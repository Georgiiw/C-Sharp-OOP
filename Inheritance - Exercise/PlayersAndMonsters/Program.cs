using System;

namespace PlayersAndMonsters
{
    public class StartUp
    {
        static void Main()
        {
            string name = Console.ReadLine();
            int level = int.Parse(Console.ReadLine());
            SoulMaster soulmaster = new SoulMaster(name, level);
            Console.WriteLine(soulmaster);
        }
    }
}
