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
    public class Martian : Being
    {
        // ability to teleport
        private double teleportRange;

        // keeps count of all the martians created
        public static int MartianCount { get; private set; }

        // default constructor
        public Martian() : base()
        {
            MartianCount++;
        }

        // parameterized constructor
        public Martian(int xValue, int yValue, int zValue, double heightValue, int armsValue,
                        double teleportRangeValue)
            : base(xValue, yValue, zValue, heightValue, armsValue)
        {
            teleportRange = teleportRangeValue;
            MartianCount++;
        }

        // Property for teleport range with validation
        public double TeleportRange
        {
            get { return teleportRange; }
            set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException("TeleportRange", "Teleport range cannot be negative!");
                teleportRange = value;
            }
        }

        // Overriding name property to say Martian
        public override string Name => "Martian";

        public override double ComputeProperty()
        {
            // calculates teleport efficiency:
            // height * arms / teleportRange
            return (Height * Arms) / TeleportRange;
        }


        // Overriden ToString method for comprehensive display
        public override string ToString()
        {
            return $"Martian | Location: {GetLocation()} | Height: {Height}' \n | Arms: {Arms} | " +
                   $"Teleport Range: {TeleportRange} \n | Efficiency: {ComputeProperty():F2}";
        }
    }
}