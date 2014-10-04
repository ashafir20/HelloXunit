using System;
using System.Collections.Generic;
using SampleApplication;
using Xunit;

namespace XnitHello.Tests
{
    public class TestingSingleObjects
    {
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
            var sut1 = new Person {Name = "Aviv"};
            var sut2 = new Person {Name = "Aviv"};

            //Assert
            Assert.Equal(sut1, sut2); //checks reference
        }


        [Fact]
        public void ComparingReferenceTypesWithCustomComparer()
        {
            //Arrange 
            var sut1 = new Person {Name = "Aviv"};
            var sut2 = new Person {Name = "Amiti"};

            //Assert
            Assert.Equal(sut1, sut2, new FirstLetterEqualityComparer());
        }

        public class FirstLetterEqualityComparer : IEqualityComparer<Person>
        {
            public bool Equals(Person x, Person y)
            {
                return x.Name[0] == y.Name[0];
            }

            public int GetHashCode(Person obj)
            {
                throw new NotImplementedException();
            }
        }
    }
}
