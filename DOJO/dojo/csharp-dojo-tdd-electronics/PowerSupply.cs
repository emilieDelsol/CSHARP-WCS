using System;
using System.Collections.Generic;
using System.Text;

namespace DojoElectronicsTDD
{
    public class PowerSupply : IComponent
    {
        public IComponent Previous { get; set; }
        /// <summary>
        /// Current delivered by the supply (amps)
        /// </summary>
        public Double Amperage { get => _current; }
        private readonly Double _current;
        /// <summary>
        /// Voltage delivered by the supply (volts)
        /// </summary>
        public Double Voltage { get => _voltage; }
        private readonly Double _voltage;
        
        public PowerSupply(Double amperage, Double voltage)
        {
            _current = amperage;
            _voltage = voltage;
        }
	}
}
