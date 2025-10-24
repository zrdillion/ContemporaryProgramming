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
    public class Star : StellarBody
    {
        //  color variable
        private string color, type;

        // temp in Kelvin
        private double temperature;

        // luminosity variable
        private double luminosity;

        // counter for all stars created
        public static int StarCount { get; private set; }

        // default constructor
        public Star()
        {
            StarCount++;
        }

        // parameterized contructor
        public Star(int xValue, int yValue, int zValue, double radiusValue, 
                    double tempValue, double lumValue)
            : base(xValue, yValue, zValue, radiusValue)
        {
            // initializing properties
            temperature = tempValue;
            luminosity = lumValue;
            if (Temperature > 30000)
            {
                color = "Blue";
                type = "O-type";
            }
            else if (Temperature > 10000)
            {
                color = "Blue-White";
                type = "B-type";
            }
            else if (Temperature > 7500)
            {
                color = "White";
                type = "A-type";
            }
            else if (Temperature > 6000)
            {
                color = "Yellow-White";
                type = "F-type";
            }
            else if (Temperature > 5200)
            {
                color = "Yellow";
                type = "G-type - like our Sun";
            }
            else if (Temperature > 3700)
            {
                color = "Orange";
                type = "K-type";
            }
            else
            {
                color = "Red";
                type = "M-type";
            }
            StarCount++;
        }

        // property for Color with validation
        public string Color
        {
            // getter and setter
            get { return color; }
            set
            {
                // validation to ensure color is not null or empty
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Color cannot be empty or null!");
                color = value;
            }
        }

        // property for Temperature with validation
        public double Temperature
        {
            // getter and setter
            get { return temperature; }
            set
            {
                // validation to ensure temperature is positive
                if (value <= 0)
                    throw new ArgumentOutOfRangeException("Temperature", "Temperature must be greater than zero!");
                temperature = value;
            }
        }

        // property for Luminosity with validation
        public double Luminosity
        {
            // getter and setter
            get { return luminosity; }
            set
            {
                // validation to ensure luminosity is positive
                if (value <= 0)
                    throw new ArgumentOutOfRangeException("Luminosity", "Luminosity must be greater than zero!");
                luminosity = value;
            }
        }

        // Property for star type
        public string Type
        { get { return type; }
            set
            {
                type = value;
            }
        }

        // overriding Name property to say Star
        public override string Name => "Star";

        // Overriding ComputeProperty to find energy output
        public override double ComputeProperty()
        {
            // energy output = luminosity * temperature * radius
            return Luminosity * Temperature * Radius;
        }


        // this is for the star class only
        public string EmitLight()
        {
            // this doesnt really do anything importnt just some flavor text
            // describing the star's light emission
            return $"The {Color} star shines with {Temperature}" +
                $"K temperature and {Luminosity} luminosity!";
        }


        // we override ToString for a comprehensiv  display
        public override string ToString()
        {
            // returning all relevant star information
            return $"Star | Location: {GetLocation()} \n| Radius: {Radius} \n| Color: {Color} | " +
                   $"Temperature: {Temperature}K \n| Luminosity: {Luminosity} | " +
                   $"Type: {Type} \n| Energy: {ComputeProperty():E2}";
        }
    }
}