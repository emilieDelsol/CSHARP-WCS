using System;
using System.Collections.Generic;

namespace solid_OpenClosePrinciple
{
	internal sealed class Factory
	{
		internal Production Craft(IEnumerable<Craftable> craftables)
		{
			Production production = new Production(craftables);
			return production;
		}
	}
}