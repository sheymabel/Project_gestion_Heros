using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heros.Entity
{
    public class Hero
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Superpower { get; set; }
        public int Age { get; set; }

        public Hero(string Id, string name, string superpower, int age)
        {
            this.Id = Id;
            Name = name;
            Superpower = superpower;
            Age = age;
        }
    }
}

