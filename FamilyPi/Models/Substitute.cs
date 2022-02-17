using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FamilyPi.Models
{
    public class Substitute
    {
        public string Name { get; set; }
        public string Substitutions { get; set; }
        public int Id { get; }

        private static int nextId = 1;

        public Substitute (string name, string substitutions)
        {
            Name = name;
            Substitutions = substitutions;
            Id = nextId;
            nextId++;
        }

        public override string ToString()
        {
            return Name;
        }

        public override bool Equals(object obj)
        {
            return obj is Tip @event &&
                Id == @event.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }
    }
}
