using System;
using System.Collections.Generic;
using System.Linq;
using SampleApplication;
using Xunit;

namespace XnitHello.Tests
{
    public class TestingRanges
    {
        [Fact]
        public void InRange()
        {
            var result = 42;

            Assert.InRange(result, 42, 50);
        }

        [Fact]
        public void NotInRange()
        {
            var result = 42;

            Assert.NotInRange(result, 43, 50);
        }

    }
}
