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
    public class SpaceShip : SpaceObject
    {
        // spaceShip properties
        private string shipType;

        private double payloadCapacity;
        private double currentPayload;
        private double fuelLevel;
        private double maxSpeed;
        private int crewCapacity;

        // counter for all spaceships created
        public static int SpaceShipCount { get; private set; }

        // default constructor
        public SpaceShip() : base()
        {
            SpaceShipCount++;
        }

        // parameterized constructor
        public SpaceShip(int xValue, int yValue, int zValue, string typeValue,
                        double payloadValue, double fuelValue, double speedValue, int crewValue)
            : base(xValue, yValue, zValue)
        {
            ShipType = typeValue;
            PayloadCapacity = payloadValue;
            FuelLevel = fuelValue;
            MaxSpeed = speedValue;
            CrewCapacity = crewValue;
            currentPayload = 0;
            SpaceShipCount++;
        }

        // property for ShipType with validation
        public string ShipType
        {
            get { return shipType; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Ship type cannot be empty!");
                shipType = value;
            }
        }

        // property for PayloadCapacity with validation
        public double PayloadCapacity
        {
            get { return payloadCapacity; }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("PayloadCapacity",
                        "Payload capacity cannot be negative!");
                payloadCapacity = value;
            }
        }

        // property for CurrentPayload with validation
        public double CurrentPayload
        {
            get { return currentPayload; }
            private set
            {
                if (value < 0 || value > PayloadCapacity)
                    throw new ArgumentOutOfRangeException("CurrentPayload", "Invalid payload amount!");
                currentPayload = value;
            }
        }

        // property for FuelLevel with validation
        public double FuelLevel
        {
            get { return fuelLevel; }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("FuelLevel",
                        "Fuel level cannot be negative!");
                fuelLevel = value;
            }
        }

        // property for MaxSpeed with validation
        public double MaxSpeed
        {
            get { return maxSpeed; }
            set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException("MaxSpeed",
                        "Max speed must be greater than zero!");
                maxSpeed = value;
            }
        }

        // property for CrewCapacity with validation
        public int CrewCapacity
        {
            get { return crewCapacity; }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("CrewCapacity",
                        "Crew capacity cannot be negative!");
                crewCapacity = value;
            }
        }


        // override abstract Name property
        public override string Name => "SpaceShip";

        // override ComputeProperty - calculates travel efficiency
        public override double ComputeProperty()
        {
            // efficiency based on speed, payload, and fuel efficiency
            return (MaxSpeed * PayloadCapacity) / (FuelLevel + 1);
        }

        // override ToString for comprehensive display
        public override string ToString()
        {
            return $"SpaceShip | Type: {ShipType} \n| Location: {GetLocation()} \n| " +
                   $"Payload: {CurrentPayload}/{PayloadCapacity} \n| Fuel: {FuelLevel:F1} | " +
                   $"Max Speed: {MaxSpeed} | Crew: {CrewCapacity} \n|  Efficiency: {ComputeProperty():F2}";
        }
    }
}