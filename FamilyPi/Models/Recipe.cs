using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FamilyPi.Models
{
    public class Recipe
    {
        public string Name { get; set; }
        public string Ingredient { get; set; }
        public string Directions { get; set; }
        public int Id { get; }

        private static int nextId = 1;

        public Recipe (string name, string ingredient, string directions)
        {
            Name = name;
            Ingredient = ingredient;
            Directions = directions;
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
