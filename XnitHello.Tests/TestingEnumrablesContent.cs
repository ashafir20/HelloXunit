using System;
using System.Collections.Generic;
using System.Linq;
using SampleApplication;
using Xunit;

namespace XnitHello.Tests
{
    public class TestingObjectTypes
    {
        [Fact]
        public void AssertType()
        {
            int result = 42;

            Assert.IsType<int>(result);
        }

        [Fact]
        public void AssertNotType()
        {
            int result = 42;

            Assert.IsNotType<string>(result);
        }

        [Fact]
        public void IsAssignableFrom()
        {
            var result = new DrivedPerson();

            Assert.IsAssignableFrom<Person>(result);
        }

    }


    public class DrivedPerson : Person
    {
        
    }
}
