using NUnit.Framework;
using DojoElectronicsTDD;

namespace DojoElectronicsTDDTest
{
    public class TestResistor
    {
        [Test]
        public void TestSuppliedResistor()
        {
            PowerSupply supply = new PowerSupply(amperage: 10, voltage: 10);
            Resistor resistor = new Resistor { Resistance = 100 };

            resistor.Previous = supply;

            Assert.AreEqual(0.1d, resistor.Amperage,
                            "Amperage = Voltage / Resistance");
            Assert.AreEqual(100 * 10, resistor.Voltage,
                            "Voltage = Resistance * Amperage");
        }
        [Test]
        public void TestSuppliedResistorOpen()
        {
            PowerSupply supply = new PowerSupply(amperage: 10, voltage: 10);
            Switch switchComponent = new Switch();
            switchComponent.Previous = supply;
            Resistor resistor = new Resistor { Resistance = 100 };

            resistor.Previous = switchComponent;

            Assert.AreEqual(0, resistor.Amperage,
                            "Amperage = Voltage / Resistance");
            Assert.AreEqual(0, resistor.Voltage,
                            "Voltage = Resistance * Amperage");
        }
        [Test]
        public void TestSuppliedResistorClosed()
        {
            PowerSupply supply = new PowerSupply(amperage: 10, voltage: 10);
            Switch switchComponent = new Switch();
            switchComponent.Previous = supply;
            Resistor resistor = new Resistor { Resistance = 100 };

            resistor.Previous = switchComponent;
            switchComponent.Toggle();

            Assert.AreEqual(0.1d, resistor.Amperage,
                            "Amperage = Voltage / Resistance");
            Assert.AreEqual(100 * 10, resistor.Voltage,
                            "Voltage = Resistance * Amperage");
        }
    }
}