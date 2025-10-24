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
    public class Earthling : Being
    {
        private double walkingSpeed;

        //  Earthling property: walking speed

        // counter for number of Earthlings
        public static int EarthlingCount { get; private set; }

        // default constructor
        public Earthling()
        {
            WalkingSpeed = 5.0;
            EarthlingCount++;
        }

        // parameterized constructor
        public Earthling(int xValue, int yValue, int zValue, double heightValue, int armsValue, double walkingSpeedValue)
            : base(xValue, yValue, zValue, heightValue, armsValue)
        {
            WalkingSpeed = walkingSpeedValue;
            EarthlingCount++;
        }

        // overriding Name property to say Earthling
        public override string Name => "Earthling";

        // Property for walking speed variable
        public double WalkingSpeed
        {
            get { return walkingSpeed; }
            set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException("WalkingSpeed", "Walking speed must be greater than zero!");
                walkingSpeed = value;
            }
        }


        // override ComputeProperty: defines earthling stamina as (height * arms * walkingSpeed / 10)
        public override double ComputeProperty()
        {
            return (Height * Arms * WalkingSpeed) / 10.0;
        }

        // Override ToString
        public override string ToString()
        {
            return $"Earthling | Location: {GetLocation()} | Height: {Height}' \n | Arms: {Arms} | " +
                   $"Walking Speed: {WalkingSpeed} | Stamina: {ComputeProperty():F2}";
        }
    }
}