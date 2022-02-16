using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using FarmSystem.Test1;

namespace FarmSystem.UnitTest
{
    [TestClass]
    public class Test1Objective
    {
        [TestMethod]
        public void EnterCow()
        {
            var farm = new EmydexFarmSystem();

            string expected = "Cow has entered the farm";

            Cow cow = new Cow();
            cow.Id = Guid.NewGuid().ToString();
            cow.NoOfLegs = 4;
            string actual = farm.EnterLine(cow);

            Assert.AreEqual<string>(expected, actual);
        }

        [TestMethod]
        public void EnterHen()
        {
            var farm = new EmydexFarmSystem();

            string expected = "Hen has entered the farm";

            Hen hen = new Hen();
            hen.Id = Guid.NewGuid().ToString();
            hen.NoOfLegs = 4;
            string actual = farm.EnterLine(hen);

            Assert.AreEqual<string>(expected, actual);
        }

        [TestMethod]
        public void EnterHorse()
        {
            var farm = new EmydexFarmSystem();

            string expected = "Horse has entered the farm";

            Horse horse = new Horse();
            horse.Id = Guid.NewGuid().ToString();
            horse.NoOfLegs = 4;
            string actual = farm.EnterLine(horse);

            Assert.AreEqual<string>(expected, actual);
        }

        [TestMethod]
        public void EnterSheep()
        {
            var farm = new EmydexFarmSystem();

            string expected = "Sheep has entered the farm";

            Sheep sheep = new Sheep();
            sheep.Id = Guid.NewGuid().ToString();
            sheep.NoOfLegs = 4;
            string actual = farm.EnterLine(sheep);

            Assert.AreEqual<string>(expected, actual);
        }
    }
}
