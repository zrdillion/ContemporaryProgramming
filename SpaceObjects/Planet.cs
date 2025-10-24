// Zach Dillion
// James Odjewuyi
// Program 5
// Space Objects
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceObjects
{
    public class Planet : StellarBody
    {
        // Planet properties
        private bool hasWater;

        private int moonCount;
        private bool hasAtmosphere;

        // counter for all planet instances created
        public static int PlanetCount { get; private set; }

        // default constructor
        public Planet() : base()
        {
            PlanetCount++;
        }

        // parameterized constructor
        public Planet(int xValue, int yValue, int zValue, double radiusValue,
                   bool water, int moons, bool atmosphere)
            : base(xValue, yValue, zValue, radiusValue)
        {
            HasWater = water;
            MoonCount = moons;
            HasAtmosphere = atmosphere;
            PlanetCount++;
        }

        // property for HasWater
        public bool HasWater
        {
            get { return hasWater; }
            set { hasWater = value; }
        }

        // property for MoonCount with validation
        public int MoonCount
        {
            get { return moonCount; }
            set
            {
                // validation to ensure moon count is not negative
                if (value < 0)
                    throw new ArgumentOutOfRangeException("MoonCount", "Moon count cannot be negative!");
                moonCount = value;
            }
        }

        // property for HasAtmosphere
        public bool HasAtmosphere
        {
            // getter and setter
            get { return hasAtmosphere; }
            set { hasAtmosphere = value; }
        }

        // override abstract Name property
        public override string Name => "Planet";

        //  override ComputeProperty  calculates habitability score
        public override double ComputeProperty()
        {
            // base score from size
            double score = Radius * 2;

            // bonus points for life supporting features
            if (HasWater) score += 30;
            if (HasAtmosphere) score += 25;
            if (MoonCount > 0) score += MoonCount * 5;

            return score;
        }

        // exploration readiness
        public string Explore()
        {
            // simple check for exploration readiness
            string waterStatus = HasWater ? "has signs of water" : "is dry";
            string atmosphereStatus = HasAtmosphere ? "has an atmosphere" : "has no atmosphere";
            return $"The planet {waterStatus}, {atmosphereStatus}, and has {MoonCount} moon(s). Ready for exploration!";
        }

        // check if habitable
        public bool IsPotentiallyHabitable()
        {
            //  must have water and atmosphere
            return HasWater && HasAtmosphere;
        }

        // override ToString for comprehensive display
        public override string ToString()
        {
            string waterStatus = HasWater ? "Yes" : "No";
            string atmosphereStatus = HasAtmosphere ? "Yes" : "No";
            string habitable = IsPotentiallyHabitable() ? "Potentially Habitable" : "Not Habitable";
            // formatted output
            return $"Planet | Location: {GetLocation()} \n| Radius: {Radius} | " +
                   $"Water: {waterStatus} \n| Atmosphere: {atmosphereStatus} | " +
                   $"Moons: {MoonCount} \n| {habitable} | \nHabitability Score: {ComputeProperty():F1}";
        }
    }
}