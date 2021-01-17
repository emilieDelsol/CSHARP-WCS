using DojoElectronicsTDD;
using NUnit.Framework;

namespace DojoElectronicsTDDTest
{
	class TestBulb
	{
        [Test]
        public void TestBulbOn()
        {
            PowerSupply supply = new PowerSupply(amperage: 10, voltage: 10);
            Bulb bulb = new Bulb { MinimumPower=20};
            bulb.Previous = supply;

            Assert.IsTrue(bulb.IsOn);

        }

        [Test]
        public void TestBulbOff()
        {
            PowerSupply supply = new PowerSupply(amperage: 10, voltage: 10);
            Bulb bulb = new Bulb { MinimumPower = 1000 };
            bulb.Previous = supply;

            Assert.False(bulb.IsOn);
        }
    }
}
