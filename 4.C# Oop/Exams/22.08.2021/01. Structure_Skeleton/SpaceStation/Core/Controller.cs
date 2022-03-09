using SpaceStation.Core.Contracts;
using SpaceStation.Models.Astronauts;
using SpaceStation.Models.Planets;
using SpaceStation.Repositories;
using SpaceStation.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using SpaceStation.Models.Mission;
using SpaceStation.Models.Astronauts.Contracts;

namespace SpaceStation.Core
{
    public class Controller : IController
    {
        public Controller()
        {

        }

        AstronautRepository astronauts = new AstronautRepository();
        PlanetRepository planets = new PlanetRepository();

        public string AddAstronaut(string type, string astronautName)
        {
            if (type == "Geodesist")
            {
                astronauts.Add(new Geodesist(astronautName));

            }
            else if (type == "Biologist")
            {
                astronauts.Add(new Biologist(astronautName));
            }
            else if (type == "Meteorologist")
            {
                astronauts.Add(new Meteorologist(astronautName));
            }
            else if (true)
            {
                throw new InvalidOperationException(ExceptionMessages.InvalidAstronautType);
            }

            return $"Successfully added {type}: {astronautName}!";
        }

        public string AddPlanet(string planetName, params string[] items)
        {
            planets.Add(new Planet(planetName, items));

            return $"Successfully added Planet: {planetName}!";
        }

        public string ExplorePlanet(string planetName)
        {
            if (!astronauts.Models.Any(x=>x.Oxygen > 60))
            {
                throw new InvalidOperationException(ExceptionMessages.InvalidAstronautCount);
            }

            int countBeforew = astronauts.Models.Where(x => x.CanBreath == false).Count();

            List<IAstronaut> list = astronauts.Models.Where(x => x.Oxygen > 60).ToList();
           
            Mission mission = new Mission();
            mission.Explore(planets.Models.FirstOrDefault(x => x.Name == planetName), list );

            int countAfter = astronauts.Models.Where(x => x.CanBreath == false).Count();

            return $"Planet: { planetName} was explored!Exploration finished with {countAfter-countBeforew } dead astronauts!";

        }

        public string Report()
        {
            return "";
        }

        public string RetireAstronaut(string astronautName)
        {
            if (!astronauts.Models.Any(x => x.Name == astronautName))
            {
                throw new InvalidOperationException($"Astronaut {astronautName} doesn't exists!");
            }

            astronauts.Remove(astronauts.Models.FirstOrDefault(x => x.Name == astronautName));

            return $"Astronaut {astronautName} was retired!";
        }
    }
}
