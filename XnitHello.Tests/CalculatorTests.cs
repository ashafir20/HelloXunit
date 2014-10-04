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


        [Fact]
        public void ComparingReferenceTypes()
        {
            //Arrange 
            var sut1 = new Calculator();
            var sut2 = sut1;

            //Assert
            Assert.Equal(sut1, sut2); //checks reference
        }

        [Fact]
        public void ComparingReferenceTypesWithEqualsImplemented()
        {
            //Arrange 
            var sut1 = new Person { Name = "Aviv" };
            var sut2 = new Person { Name = "Aviv" };

            //Assert
            Assert.Equal(sut1, sut2); //checks reference
        }


        [Fact]
        public void ComparingReferenceTypesWithCustomComparer()
        {
            //Arrange 
            var sut1 = new Person { Name = "Aviv" };
            var sut2 = new Person { Name = "Amiti" };

            //Assert
            Assert.Equal(sut1, sut2, new FirstLetterEqualityComparer());
        }

        public class Person
        {
            public string Name { get; set; }
            // override object.Equals
            public override bool Equals(object obj)
            {
                if (obj == null || GetType() != obj.GetType())
                {
                    return false;
                }

                var p = obj as Person;
                if (p == null)
                {
                    return false;
                }

                return Name.Equals(p.Name);
                
            }
                
            // override object.GetHashCode
            public override int GetHashCode()
            {
                return Name.GetHashCode();
            }
        }
    }

    public class FirstLetterEqualityComparer : IEqualityComparer<CalculatorTests.Person>
    {
        public bool Equals(CalculatorTests.Person x, CalculatorTests.Person y)
        {
            return x.Name[0] == y.Name[0];
        }

        public int GetHashCode(CalculatorTests.Person obj)
        {
            throw new NotImplementedException();
        }
    }
}
