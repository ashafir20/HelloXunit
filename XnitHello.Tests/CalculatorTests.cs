using System;
using System.Collections.Generic;
using SampleApplication;
using Xunit;

namespace XnitHello.Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void ShouldAdd()
        {
            //Arrange 
            var sut = new Calculator();

            //Act
            var result = sut.Add(5, 5);

            //Assert
            Assert.Equal(10, result);
        }
    }
}
