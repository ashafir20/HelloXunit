using System;
using System.Collections.Generic;
using System.Linq;
using SampleApplication;
using Xunit;

namespace XnitHello.Tests
{
    public class TestingDecimal
    {
        [Fact]
        public void Decimals()
        {
            var d1 = new Decimal(24);
            var d2 = new Decimal(24);

            Assert.Equal(d1, d2);
        }

        [Fact]
        public void DecimalsWithPrecision()
        {
            var d1 = new Decimal(24.111);
            var d2 = new Decimal(24.112);

            Assert.Equal(d1, d2, 2);
        }
    }
}
