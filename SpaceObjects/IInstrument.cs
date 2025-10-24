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
    // Interface for scientific instruments on probes 
    public interface IInstrument
    {
        string InstrumentName { get; }
        bool IsActive { get; set; }
        string CollectData();
        double GetBatteryLevel();
        void RechargeBattery(double amount);
    }
}
