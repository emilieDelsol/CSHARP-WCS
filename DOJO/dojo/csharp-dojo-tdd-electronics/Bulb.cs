using System;
using System.Collections.Generic;
using System.Text;

namespace DojoElectronicsTDD
{
	public class Bulb : Resistor
	{
		public Double MinimumPower { get; set; }
		public bool IsOn 
		{ 
			get 
			{ 
				if(Previous.Amperage*Previous.Voltage>=MinimumPower)
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
