using DojoElectronicsTDD;
using NUnit.Framework;

namespace DojoElectronicsTDDTest
{
    public class TestSwitch
    {
        [Test]
        public void TestOpened()
        {
            PowerSupply supply = new PowerSupply(amperage: 10, voltage: 10);
            Switch switchComponent = new Switch();

            switchComponent.Previous = supply;

            Assert.AreEqual(0, switchComponent.Amperage, 
                            "Amperage should be 0 after creating a switch");
            Assert.AreEqual(0, switchComponent.Voltage, 
                            "Voltage should be 0 after creating a switch");
        }

        [Test]
        public void TestClosed()
        {
            PowerSupply supply = new PowerSupply(amperage: 10, voltage: 10);
            Switch switchComponent = new Switch();

            switchComponent.Previous = supply;
            switchComponent.Toggle();

            Assert.AreEqual(10, switchComponent.Amperage, 
                            "Amperage should be 10 closed after first toggle");
            Assert.AreEqual(10, switchComponent.Voltage, 
                            "Voltage should be 10 closed after first toggle");
        }
    }
}