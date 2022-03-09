﻿using SpaceStation.Models.Astronauts.Contracts;
using SpaceStation.Models.Mission.Contracts;
using SpaceStation.Models.Planets.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpaceStation.Models.Mission
{
    public class Mission : IMission
    {
        public void Explore(IPlanet planet, ICollection<IAstronaut> astronauts)
        {
            while (astronauts.Any(x=>x.CanBreath))
            {

                var astronaut = astronauts.FirstOrDefault(x => x.CanBreath);

                while (astronaut.CanBreath)
                {
                    var item = planet.Items.First();
                    astronaut.Bag.Items.Add(item);
                    planet.Items.Remove(item);
                    astronaut.Breath();
                }
            }
        }
    }
}
