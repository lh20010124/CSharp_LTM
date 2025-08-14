using System;
using InterfaceExample3;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class DeskFansTests
    {
        [TestMethod]
        public void PowerLowerThanZero_OK()
        {
            var fan = new DeskFan(new PowerSupplyLowerThanZero());
            var expexted = "Won't work";
            var actual = fan.Work();
            Assert.AreEqual(expexted, actual);
        }
    }

    class PowerSupplyLowerThanZero : IPowerSupply
    {
        public int GetPower()
        {
            return 0;
        }
    }

}
