using CarNS;
using System;

namespace CarTests_xUnit
{
    public class CarTests_xUnit
    {
        [Fact]
        public void TestGasFromConstructor()
        {
            Car car_test = new Car("Toyota", "Prius", 10, 50);
            Assert.Equal(10, car_test.GasTankLevel, .001);
        }

        [Fact]
        public void TestGasWithinRange()
        {
            Car car_test = new Car("Toyota", "Prius", 10, 50);
            car_test.Drive(50);

            Assert.Equal(9, car_test.GasTankLevel, .001);
        }

        [Fact]
        public void TestGasBelowRange()
        {
            Car car_test = new Car("Toyota", "Prius", 10, 50);

            Assert.Throws<ArgumentOutOfRangeException>(() => car_test.Drive(750));
        }

        [Fact]
        public void TestGasOverfillException()
        {
            Car car_test = new Car("Toyota", "Prius", 10, 50);

            Assert.Throws<ArgumentOutOfRangeException>(() => car_test.AddGas(50));
        }
    }
}