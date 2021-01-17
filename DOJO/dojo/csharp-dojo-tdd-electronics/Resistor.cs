using System;

namespace DojoElectronicsTDD
{
    public class Resistor : IComponent
    {
        public IComponent Previous { get; set; }

        public Double Amperage 
        { 
            get
            {
                return Previous.Voltage / Resistance;
            }
        }

        public Double Voltage
        { 
            get
            {
                return Resistance * Previous.Amperage;
            }
        }

        /// <summary>
        /// Resistance of the resistor (ohms)
        /// </summary>
        public Double Resistance { get; set; }
    }
}
