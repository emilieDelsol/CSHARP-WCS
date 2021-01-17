using System;

namespace DojoElectronicsTDD
{
    public class Switch : IComponent
    {
        private bool _closed = true;
        public IComponent Previous { get; set; }

        public Double Voltage
        { 
            get
            {
                if (!_closed)
				{
                    return Previous.Voltage;

                }
                else
				{
                    return 0;
				}
            }
        }

        public Double Amperage
        { 
            get
            {
                if (!_closed)
                {
                    return Previous.Amperage;

                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>
        /// Toggle switch
        /// </summary>
        public void Toggle()
        {
            _closed = !_closed;
        }
        public bool PowerOn 
        { 
            get 
            {
                if(_closed)
				{
                    return true;
				}
                else
				{
                    return false;
				}
            } 
        }
    }
}
