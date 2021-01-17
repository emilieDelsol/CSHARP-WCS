using DojoElectronicsTDD;
using NUnit.Framework;

namespace DojoElectronicsTDDTest
{
	class TestSwitchAfterResistor
	{
        [Test]
        public void TestOpened()
        {
            PowerSupply supply = new PowerSupply(amperage: 10, voltage: 10);
            Resistor resistor = new Resistor { Resistance = 10 };
            resistor.Previous = supply;
            Switch switchComponent = new Switch();
            
            switchComponent.Previous = resistor;
            Assert.AreEqual(0, resistor.Amperage,
                          "Amperage should be 0 after creating a switch");
            Assert.AreEqual(0, resistor.Voltage,
                            "Voltage should be 0 after creating a switch");
            Assert.AreEqual(0, switchComponent.Amperage,
                            "Amperage should be 0 after creating a switch");
            Assert.AreEqual(0, switchComponent.Voltage,
                            "Voltage should be 0 after creating a switch");
        }
    }
}
