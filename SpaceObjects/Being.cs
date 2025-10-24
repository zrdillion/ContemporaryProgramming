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
    // Being inherits from SpaceObject which gives it position (x, y, z)
    public abstract class Being : SpaceObject
    {
        // declaring height and arms variable
        private int arms;

        private double height;

        // default constructor
        public Being() : base()
        {
        }

        // Parameterized contructor
        public Being(int xValue, int yValue, int zValue, double heightValue, int armsValue)
            : base(xValue, yValue, zValue)
        {
            Height = heightValue;
            Arms = armsValue;
        }

        // property for Arms with validation
        public int Arms
        {
            get { return arms; }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException
                   ("Arms", "Number of arms cannot be negative!");
                arms = value;
            }
        }

        // property for Height with validation
        public double Height
        {
            get { return height; }
            set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException
                     ("Height", "Height must be greater than zero!");
                height = value;
            }
        }

    }
}