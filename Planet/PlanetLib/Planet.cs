using System;
namespace PlanetLib
{
    public class Planet
    {
        public string Name;
        public string StarSystem;
        public double Mass;
        public double Diameter;
        public double DistanceFromSun;
        public bool HasLife;
        public int NumberOfMoons;
        public double OrbitalPeriod;

        public double Density
        {
            get { return GetDensity(); }
        }

        public double GetDensity()
        {
            double volume = (4.0 / 3.0) * Math.PI * Math.Pow(Diameter / 2, 3);
            double earthMassInKg = 5.972e24;
            double massInKg = Mass * earthMassInKg;
            double volumeInM3 = volume * 1e9;
            return massInKg / volumeInM3;
        }
    }
}