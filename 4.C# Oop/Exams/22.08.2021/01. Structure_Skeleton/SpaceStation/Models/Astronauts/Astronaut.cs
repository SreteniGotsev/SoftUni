using SpaceStation.Models.Bags.Contracts;
using SpaceStation.Models.Bags;
using SpaceStation.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Text;
using SpaceStation.Models.Astronauts.Contracts;

namespace SpaceStation.Models.Astronauts
{
    public abstract class Astronaut : IAstronaut
    {
        private Backpack bag;
        public Astronaut(string name, double oxygen)
        {
            this.Name = name;
            this.Oxygen = oxygen;
            this.bag = new Backpack();
        }

        private string name;
        private double oxygen;
        public string Name
        {
            get => this.name;

            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException(ExceptionMessages.InvalidAstronautName);
                }

                name = value;
            }
        }

        public double Oxygen
        {
            get => this.oxygen;

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidOxygen);
                }

                oxygen = value;
            }
        }

        public bool CanBreath => oxygen >= 0 ? true : false;


        public IBag Bag { get => this.bag; }

        public virtual void Breath()
        {
            if (this.CanBreath)
            {
                if (this.GetType().Name == "Biologist" )
                {

                    this.oxygen -= 5;
                }
                else
                {
                    this.oxygen -= 10;

                }

                if (this.oxygen < 0)
                {
                    this.oxygen = 0;
                }
            }
        }
    }
}
