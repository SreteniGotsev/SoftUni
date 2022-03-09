using SpaceStation.Models.Planets.Contracts;
using SpaceStation.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceStation.Models.Planets
{
    public class Planet : IPlanet
    {
        public Planet(string name, params string[] items)
        {
            this.Name = name;
            this.items = new List<string>(items);
        }

        private List<string> items;
        private string name;

        public ICollection<string> Items {get => this.items; }

        public string Name
        {
            get => this.name;
            private set
            {
                if (value == null || value == " ")
                {
                    throw new ArgumentNullException(ExceptionMessages.InvalidPlanetName);
                }
            }
        }
    }
}
