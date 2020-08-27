using System;
using System.Collections.Generic;
using System.Text;

namespace Planets
{
    class SolarSystem : Planets
    {
        private List<Planets> planetsInSolarSystem = new List<Planets>();
        private List<Planets> meanTemperature = new List<Planets>();
        private List<Planets> planetDiameter = new List<Planets>();

        public List<Planets> PlanetsInSolarSystem { get { return planetsInSolarSystem; } }
        public List<Planets> MeanTemperature { get { return meanTemperature; } }
        public List<Planets> PlanetDiameter { get { return planetDiameter; } }

        //adds a planet to the solar system
        public void AddPlanetToSolarSystem(Planets newPlanets)
        {
            planetsInSolarSystem.Add(newPlanets);
        }

        //inserts a planet to the solarsystem
        public void InsertPlanetToSolarSystem(int index, Planets insertedPlanet)
        {
            planetsInSolarSystem.Insert(index, insertedPlanet);
        }

        //removes a planet from the solar system
        public void RemovePlanetFromSolarSystem(Planets removedPlanet)
        {
            planetsInSolarSystem.Remove(removedPlanet);
        }

        //Puts every planet that is under 0 degrees in a list
        public void MeanTemperaturePlanets()
        {
            foreach (Planets planets in planetsInSolarSystem)
            {
                if (planets.MeanTemperaturePlanet < 0)
                {
                    meanTemperature.Add(planets);
                }
            }
        }

        //Puts every planet that is between 10000 and 50000 in diameter in a list
        public void DiameterForPlanets()
        {
            foreach (Planets planets in planetsInSolarSystem)
            {
                if (planets.DiaPlanet >= 10000 && planets.DiaPlanet <= 50000)
                {
                    planetDiameter.Add(planets);
                }
            }
        }

    }
}
