using System;
using System.Collections.Generic;
using System.Text;

namespace DojoElectronicsTDD
{
    public interface IComponent
    {
        /// <summary>
        /// Previous component
        /// </summary>
        public IComponent Previous { get; set; }
        /// <summary>
        /// Ending current (amps)
        /// </summary>
        public Double Amperage { get; }
        /// <summary>
        /// Ending voltage (volts)
        /// </summary>
        public Double Voltage { get; }
    }
}
