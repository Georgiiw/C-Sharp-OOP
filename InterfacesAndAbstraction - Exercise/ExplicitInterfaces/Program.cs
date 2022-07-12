using System;
using System.Collections.Generic;

namespace ExplicitInterfaces
{
    public class Program
    {
        static void Main()
        {
            List<Citizen> citizen = new List<Citizen>();
            while (true)
            {
                string[] cmd = Console.ReadLine().Split(" ");
                if (cmd[0] == "End")
                {
                    break;
                }
                string name = cmd[0];
                string country = cmd[1];
                int age = int.Parse(cmd[2]);
                Citizen newCitizen = new Citizen(name, country, age);
                citizen.Add(newCitizen);
            }
            foreach (var human in citizen)
            {
                IPerson person = human;
                person.GetName();
                IResident resident = human;
                resident.GetName();
            }
        }
    }
}
