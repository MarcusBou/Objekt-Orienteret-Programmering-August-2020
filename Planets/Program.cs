using System;
using System.Runtime.InteropServices;

namespace Planets
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creates all the planets as their own object
            Planets mercury =  new Planets("Mercury", 0.330, 4879, 5427, 3.7, 1407.6, 4222.6, 57.9, 88.0, 47.4, 167, 0, "no");
            Planets venus = new Planets("Venus", 4.87, 12104, 5243, 8.9, -5832.5, 2802.0, 108.2, 224.7, 35.0, 464, 0, "no");
            Planets earth = new Planets("Earth", 5.97, 12756, 5514, 9.8, 23.9, 24.0, 149.6, 365.2, 29.8, 15, 1, "no");
            Planets mars = new Planets("Mars", 0.642, 6792, 3933, 3.7, 24.6, 24.7, 227.9, 687.0, 24.1, -65, 2, "no");
            Planets jupiter = new Planets("Jupiter", 1898, 142984, 1326, 23.1, 9.9, 9.9, 778.6, 4331, 13.1, -110, 67, "yes");
            Planets saturn = new Planets("Saturn", 568, 120536, 687, 9.0, 10.7, 10.70, 1433.5, 10747, 9.7, -140, 62, "yes");
            Planets uranus = new Planets("Uranus", 86.8, 51118, 1271, 8.7, -17.2, 17.2, 2872.5, 30589,6.8, -195, 27, "yes");
            Planets neptune = new Planets ("Neptune", 102, 49528, 1638, 11.0, 16.1, 16.1, 4495.1, 59.8, 5.4, -200, 14,"yes");
            Planets pluto = new Planets ("Pluto", 0.0146, 2370, 2095, 0.7, -153.3, 153.3, 5906.4, 90.56, 4.7, -225, 5, "no");
            SolarSystem solarSystem = new SolarSystem();

            //adds all the Planets to the solarSystemList.
            solarSystem.AddPlanetToSolarSystem(mercury);
            solarSystem.AddPlanetToSolarSystem(earth);
            solarSystem.AddPlanetToSolarSystem(mars);
            solarSystem.AddPlanetToSolarSystem(jupiter);
            solarSystem.AddPlanetToSolarSystem(saturn);
            solarSystem.AddPlanetToSolarSystem(uranus);
            solarSystem.AddPlanetToSolarSystem(neptune);
            solarSystem.AddPlanetToSolarSystem(pluto);
            //prints out all the planets in the solar system list
            foreach (Planets planet in solarSystem.PlanetsInSolarSystem)
            {
                Console.WriteLine("=======================");
                Console.WriteLine(planet);
                Console.WriteLine("=======================");
            }
            Console.ReadKey();
            //adds venus too its place in the solar system
            solarSystem.InsertPlanetToSolarSystem(1, venus);
            //prints all the planets with venus inserted
            foreach (Planets planet in solarSystem.PlanetsInSolarSystem)
            {
                Console.WriteLine("=======================");
                Console.WriteLine(planet);
                Console.WriteLine("=======================");
            }
            Console.ReadKey();
            //Removed pluto, since it isnt a real planet
            solarSystem.RemovePlanetFromSolarSystem(pluto);
            //prints all the planets without pluto
            foreach (Planets planet in solarSystem.PlanetsInSolarSystem)
            {
                Console.WriteLine("=======================");
                Console.WriteLine(planet);
                Console.WriteLine("=======================");
            }
            Console.ReadKey();
            //adds back pluto
            solarSystem.AddPlanetToSolarSystem(pluto);

            //show the amount of planets in the solar system
            Console.WriteLine(solarSystem.PlanetsInSolarSystem.Count);
            Console.ReadKey();

            //Write out all planets with a temperature under 0 degrees
            Console.WriteLine("<planets with a temperature under 0 degrees>");
            solarSystem.MeanTemperaturePlanets();
            foreach (Planets planets in solarSystem.MeanTemperature)
            {
                Console.WriteLine("====================");
                Console.WriteLine(planets);
                Console.WriteLine("====================");
            }
            Console.ReadKey();

            //write out all planets with an diameter between 10000 and 50000
            Console.WriteLine("<planets with an diameter between 10000 and 50000>");
            solarSystem.DiameterForPlanets();
            foreach (Planets planets in solarSystem.PlanetDiameter)
            {
                Console.WriteLine("====================");
                Console.WriteLine(planets);
                Console.WriteLine("====================");
            }
            Console.ReadKey();

            //deletes everything from the list
            solarSystem.PlanetsInSolarSystem.Clear();
            solarSystem.MeanTemperature.Clear();
            solarSystem.PlanetDiameter.Clear();
        }
    }
}
