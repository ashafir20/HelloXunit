using System;
using System.Collections.Generic;
using System.Linq;
using SampleApplication;
using Xunit;

namespace XnitHello.Tests
{
    public class RunCodeBeforeTests : IDisposable
    {
        public RunCodeBeforeTests()
        {
            //per-test setup code goes here
        }

        [Fact]
        public void Decimals()
        {
            var d1 = new Decimal(24);
            var d2 = new Decimal(24);

            Assert.Equal(d1, d2);
        }

        public void Dispose()
        {
            //per-test teardown goes here
        }
    }
}
