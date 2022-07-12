using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    public class Human : ISpecies
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string ID { get; set; }
        public Human(string name, int age, string id)
        {
            this.Name = name;
            this.Age = age;
            this.ID = id;
        }
    }
}
