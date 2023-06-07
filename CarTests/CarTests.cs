using CarNS;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CarTests
{
    [TestClass]
    public class CarTests
    {
        //TODO: add emptyTest so we can configure our runtime environment (remove this test before pushing to your personal GitHub account)


        //TODO: constructor sets gasTankLevel properly


        //TODO: gasTankLevel is accurate after driving within tank range
        [TestMethod]
        public void TestGasWithinRange()
        {
            Car test_car = new Car("Toyota", "Prius", 10, 50);
            test_car.Drive(50);
            Assert.AreEqual(9, test_car.GasTankLevel, .001);
        }

        //TODO: gasTankLevel is accurate after attempting to drive past tank range
        [TestMethod]
        public void TestGasBelowRange()
        {
            Car test_car = new Car("Toyota", "Prius", 10, 50);

            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => test_car.Drive(750));
        }

        //TODO: can't have more gas than tank size, expect an exception
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestGasOverfillException()
        {
            Car test_car = new Car("Toyota", "Prius", 10, 50);
            test_car.AddGas(10);

            Assert.Fail("Shouldn't get here, car cannot have more gas in tank than the size of the tank");
        }
    }
}
