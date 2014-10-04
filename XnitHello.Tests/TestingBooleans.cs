using System;
using System.Collections.Generic;
using System.Linq;
using SampleApplication;
using Xunit;

namespace XnitHello.Tests
{
    public class TestingBooleans
    {
        [Fact]
        public void AssertTrue()
        {
            const bool result = true;

            Assert.True(result);
        }

        [Fact]
        public void AssertFalse()
        {
            const bool result = false;

            Assert.False(result);
        }

        [Fact]
        public void WithMessage()
        {
            const bool result = false;

            //Assert.True(result, "this is the message");
        }

    }
}
