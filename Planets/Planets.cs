using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.Serialization;
using System.Text;

namespace Planets
{
    class Planets
    {
        /// <summary>
        /// Creates a planet Via constructor, with all the right parameters such as names and mass
        /// And store them as an object of their own.
        /// </summary>
        private string namePlanet, ringSystemPlanet;
        private double massPlanet, diaPlanet, densityPlanet, gravityPlanet, rotationPlanet, dayLengthPlanet, distanceFromSunPlanet, orbitalPeriodPlanet, orbitalVelocityPlanet, meanTemperaturePlanet;
        private int numberOfMoonsPlanet;

        public string NamePlanet { get { return namePlanet; } set { namePlanet = value; } }
        public double MassPlanet { get { return massPlanet; } set { massPlanet = value; } }
        public double DiaPlanet { get { return diaPlanet; } set { diaPlanet = value; } }
        public double DensityPlanet { get { return densityPlanet; } set { densityPlanet = value; } }
        public double GravityPlanet { get { return gravityPlanet; } set { gravityPlanet = value; } }
        public double RotationPlanet { get { return rotationPlanet; } set { rotationPlanet = value; } }
        public double DayLengthPlanet { get { return dayLengthPlanet; } set { dayLengthPlanet = value; } }
        public double DistanceFromSunPlanet { get { return distanceFromSunPlanet; } set { distanceFromSunPlanet = value; } }
        public double OrbitalPeriodPlanet { get { return orbitalPeriodPlanet; } set { orbitalPeriodPlanet = value; } }
        public double OrbitalVelocityPlanet { get { return orbitalVelocityPlanet; } set { orbitalVelocityPlanet = value; } }
        public double MeanTemperaturePlanet { get { return meanTemperaturePlanet; } set { meanTemperaturePlanet = value; } }
        public int NumberOfMoonsPlanet { get { return numberOfMoonsPlanet; } set { numberOfMoonsPlanet = value; } }
        public string RingSystemPlanet { get { return ringSystemPlanet; } set { ringSystemPlanet = value; } }

        public Planets() { }

        public Planets(string name , double mass, double dia, double density, double gravity, double rotation, double dayLength, double distanceFromSun, double orbitalPeriod, double orbitalVelocity, double meanTemperature, int numberOfMoons, string ringsystem)
        {
            namePlanet = name;
            massPlanet = mass;
            diaPlanet = dia;
            densityPlanet = density;
            gravityPlanet = gravity;
            rotationPlanet = rotation;
            dayLengthPlanet = dayLength;
            distanceFromSunPlanet = distanceFromSun;
            orbitalPeriodPlanet = orbitalPeriod;
            orbitalVelocityPlanet = orbitalVelocity;
            meanTemperaturePlanet = meanTemperature;
            numberOfMoonsPlanet = numberOfMoons;
            ringSystemPlanet = ringsystem;
        }

        public override string ToString()
        {
            return "|Name: " + namePlanet +
                    "\n|Mass(1024): " + massPlanet +
                    "\n|Diameter(km): " + diaPlanet +
                    "\n|Density(kg/m3): " + densityPlanet +
                    "\n|Gravity(m/s2)" + gravityPlanet +
                    "\n|Rotation Period(hours): " + rotationPlanet +
                    "\n|Length of day(hours)" + dayLengthPlanet +
                    "\n|Distance From Sun(106 km): " + distanceFromSunPlanet +
                    "\n|Orbital Period(Days): " + orbitalPeriodPlanet +
                    "\n|Orbital Velocity(Km/s): " + orbitalVelocityPlanet +
                    "\n|Mean Tempertarure(C): " + meanTemperaturePlanet +
                    "\n|Number of moons: " +  numberOfMoonsPlanet +
                    "\n|Ringsystem: " + ringSystemPlanet;
        }

    }
}
