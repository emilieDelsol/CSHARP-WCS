using System.Collections.Generic;

namespace solid_OpenClosePrinciple
{
	internal class Production
	{
        public IEnumerable<Craftable> Materials { get; set; }
        public Production(IEnumerable<Craftable> manyMaterials)

        {
            Materials = manyMaterials;
        }
        public override string ToString()
        {
            string description = "Object is composed of\n:";
            foreach (Craftable material in Materials)
            {
                description += "\t" + material.Type;
            }
            return description;
        }
    }
}