using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FamilyPi.Models
{
    public class Tip
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public Tip (string name, string description)
        {
            Name = name;
            Description = description;
        }

        public override string ToString()
        {
            return Name;
        }



       
    }
}
