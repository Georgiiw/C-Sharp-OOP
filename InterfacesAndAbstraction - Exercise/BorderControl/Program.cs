using System;
using System.Collections.Generic;

namespace BorderControl
{
    public class Program
    {
        static void Main()
        {
            List<ISpecies> ids = new List<ISpecies>();
            while (true)
            {
                string[] cmd = Console.ReadLine().Split(" ");
                if (cmd[0] == "End")
                    break;

                if (cmd.Length == 2)
                {
                    string robotModel = cmd[0];
                    string robotID = cmd[1];
                    ISpecies robot = new Robot(robotModel, robotID);
                    ids.Add(robot);
                }
                else if (cmd.Length == 3)
                {
                    string name = cmd[0];
                    int age = int.Parse(cmd[1]);
                    string id = cmd[2];
                    ISpecies human = new Human(name, age, id);
                    ids.Add(human);
                }

            }
            string fakeIds = Console.ReadLine();
            foreach (var id in ids)
            {
                if (id.ID.EndsWith(fakeIds))
                {
                    Console.WriteLine(id.ID);
                }
            }
        }
    }
}
