using System;
using System.Collections.Generic;
using System.Linq;
using SampleApplication;
using Xunit;

namespace XnitHello.Tests
{
    public class TestingEnumrablesContent
    {
        [Fact]
        public void AssertContains()
        {
            var names = new[] {"Sarah", "Amrit"};

            Assert.Contains("Amrit", names);
        }

        [Fact]
        public void AssertDoesNotContains()
        {
            var names = new[] { "Sarah", "Amrit" };

            Assert.DoesNotContain("Aviv", names);
        }

        [Fact]
        public void Empty()
        {
            var names = new List<string>();

            Assert.Empty(names);
        }

    }
}
