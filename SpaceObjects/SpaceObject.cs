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
    public abstract class SpaceObject
    {
        // Declaring position variables
        private int x, y, z;

        public static int ObjectCount { get; private set; }

        // Default constructor
        public SpaceObject()
        {
            ObjectCount++;
        }

        // Parameterized constructor
        public SpaceObject(int xValue, int yValue, int zValue)
        {
            ObjectCount++;
            X = xValue;
            Y = yValue;
            Z = zValue;
        }

        // Property for X value
        public int X
        {
            get
            {
                return x;
            }
            set
            {
                //added validation to ensure X is not negative
                if (value < 0)
                    throw new ArgumentOutOfRangeException("X", "Coordinate cannot be negative!");
                x = value;
            }
        }

        // Property for Y value
        public int Y
        {
            get
            {
                return y;
            }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("Y", "Coordinate cannot be negative!");
                y = value;
            }
        }

        // Property for Z value
        public int Z
        {
            get
            {
                return z;
            }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("Z", "Coordinate cannot be negative!");
                z = value;
            }
        }

        // read Only Name property
        // abstract so derived classes must implement it

        public abstract string Name
        {
            get;
        }

        // abstract method also
        public abstract double ComputeProperty();

        // virtual method for GetLocation, can be overridden
        public virtual string GetLocation()
        {
            return $"({X}, {Y}, {Z})";
        }

        // Override the ToString method to make info readable
        public override string ToString()
        {
            return $"{Name} located at {GetLocation()}";
        }
    }
}