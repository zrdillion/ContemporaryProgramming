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
    public abstract class StellarBody : SpaceObject
    {
        // Declaring radius variable
        private double radius;

        // Default constructor
        public StellarBody()
        {
        }

        // Parameterized constructor
        public StellarBody(int xValue, int yValue, int zValue, double radiusValue)
            : base(xValue, yValue, zValue)
        {
            Radius = radiusValue;
        }

        // property for Radius
        public double Radius
        {
            get { return radius; }
            set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException("Radius", "Radius must be greater than zero!");
                radius = value;
            }
        }

        // common method for all stellar bodies
        // csn be modified
        public virtual double CalculateVolume()
        {
            // Volume of a sphere: (4/3) * π * r³
            return (4.0 / 3.0) * Math.PI * Math.Pow(Radius, 3);
        }

        // method for gravitational influence
        // can also be modified
        public virtual double CalculateGravity()
        {
            // a simplified gravity calculation based on radius
            return Radius * 0.1;
        }
    }
}