using System;
using System.Collections.Generic;
using System.Linq;
using SampleApplication;
using Xunit;

namespace XnitHello.Tests
{
    public class SkippingTests
    {
        [Fact(Skip="Dont want this to run")]
        public void InRange()
        {
            
        }

    }
}
