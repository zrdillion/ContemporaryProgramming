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
    public class Probe : SpaceObject, IInstrument
    {
        // probe properties
        private string missionObjective;
        private int samplesCollected;
        private double batteryLevel;
        private bool isActive;

        // counter for all probes created
        public static int ProbeCount { get; private set; }

        // default constructor
        public Probe() : base()
        {
            // starts with full battery and active status
            batteryLevel = 100.0;
            isActive = true;
            ProbeCount++;
        }

        // parameterized constructor
        public Probe(int xValue, int yValue, int zValue, string objective)
           : base(xValue, yValue, zValue)
        {
            // initializing properties
            missionObjective = objective;
            samplesCollected = 0;
            batteryLevel = 100.0;
            isActive = true;
            ProbeCount++;
        }

        // property for MissionObjective
        public string MissionObjective
        {
            get { return missionObjective; }
            set
            {
                // validation to ensure objective is not empty
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Mission objective cannot be empty!");
                missionObjective = value;
            }
        }

        // property for SamplesCollected with validation
        public int SamplesCollected
        {
            get { return samplesCollected; }
            private set
            {
                // validation to ensure samples collected is not negative
                if (value < 0)
                    throw new ArgumentOutOfRangeException("SamplesCollected", "Cannot have negative samples!");
                samplesCollected = value;
            }
        }

        // property for BatteryLevel with validation
        public double BatteryLevel
        {
            get { return batteryLevel; }
        }

        // IInstrument Interface Implementation
        // Interface property:  InstrumentName
        public string InstrumentName => "Planetary Explorer";

        // Interface property: IsActive
        public bool IsActive
        {
            // getter and setter
            get { return isActive; }
            set
            {
                // setting active status
                isActive = value;
                // small battery drain when deactivating
                if (!isActive)
                {
                    batteryLevel = batteryLevel - 2.0;
                }
            }
        }

        // Interface method:  CollectData
        public string CollectData()
        {
            // validation checks
            if (!IsActive)
                return "Cannot collect data - instrument is inactive!";

            // check battery level
            if (batteryLevel < 5)
                return "Cannot collect data - low battery!";

            // consume battery and collect samples
            batteryLevel -= 3.0;
            SamplesCollected++;

            // return data collection message
            return $"Collected sample #{SamplesCollected}. Analyzing space data...";
        }

        // Interface method:     GetBatteryLevel
        public double GetBatteryLevel()
        {
            // simply returns current battery level
            return batteryLevel;
        }

        // Interface met:  RechargeBattery
        public void RechargeBattery(double amount)
        {
            // validation for recharge amount
            if (amount < 0)
                throw new ArgumentOutOfRangeException("amount", "Cannot recharge negative amount!");

            // increase battery level  but makes sure it doesnt go over 100
            batteryLevel = Math.Min(100.0, batteryLevel + amount);
        }

        // SpaceObject Abstract Method Implementations
        // override abstract Name property
        public override string Name => "Space Probe";

        // override ComputeProperty: define scientific value
        public override double ComputeProperty()
        {
            // Scientific value based on samples and battery efficiency
            // once again the numbers mean nothing 
            return SamplesCollected * 10 * (batteryLevel / 100.0);
        }
        
        // override ToString for comprehensive display
        public override string ToString()
        {
            string activeStatus = IsActive ? "Active" : "Inactive";
            return $"Probe | Location: {GetLocation()} \n| Mission: {MissionObjective} | " +
                   $"Samples: {SamplesCollected} \n| Battery: {batteryLevel:F1}% | " +
                   $"Status: {activeStatus} \n| Scientific Value: {ComputeProperty():F2}";
        }

    }
}
