using System;
using InterfaceExample3;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

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
        [TestMethod]
        public void PowerHigherThan200_Warning()
        {
            var fan = new DeskFan(new PowerSupplyHigherThan200());
            var expexted = "Warning!";
            var actual = fan.Work();
            Assert.AreEqual(expexted, actual);
        }
        [TestMethod]
        public void PowerHigherThan100AndLowerThan200()
        {
            var mock = new Mock<IPowerSupply>();
            mock.Setup(ps => ps.GetPower()).Returns(() => 150);
            var fan = new DeskFan(mock.Object);
            var expexted = "Work fine!";
            var actual = fan.Work();
            Assert.AreEqual(expexted, actual);
        }
        [TestMethod]
        public void PowerEqual0()
        {
            var mock = new Mock<IPowerSupply>();
            mock.Setup(ps => ps.GetPower()).Returns(() => 0);
            var fan = new DeskFan(mock.Object);
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

    class PowerSupplyHigherThan200 : IPowerSupply
    {
        public int GetPower()
        {
            return 210;
        }
    }

}
