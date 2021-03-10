using ConsoleAppGitHub.Model;
using System;
using Xunit;

namespace ConsoleAppGitHub.Tests.Model
{
    
    public class CarTests
    {
        [Fact]
        public void CarIdTest()
        {
            //Arrange
            Car testCar = new Car();

            //Act
            int result = testCar.Id;

            //Assert
            //Assert.Equal( 1 , result );// bad when working with static
            Assert.NotEqual( 0 , result );
        }

        [Fact]
        public void CarUniqueIdTest()
        {
            //Arrange
            //Car.idCounter = 0;//reset idCounter for test
            Car testCar1 = new Car();
            Car testCar2 = new Car();
            Car testCar3 = new Car();

            //Act
            int result1 = testCar1.Id;
            int result2 = testCar2.Id;
            int result3 = testCar3.Id;

            //Assert
            /*Assert.Equal(1, result1);
            Assert.Equal(2, result2);
            Assert.Equal(3, result3);*/
            Assert.True(result1 != result2 && result1 != result3);
            Assert.True(result2 != result1 && result2 != result3);
            Assert.True(result3 != result1 && result3 != result1);

        }

    }
}
