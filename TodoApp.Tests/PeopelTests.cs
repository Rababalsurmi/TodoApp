using System;
using Xunit;
using TodoApp.Data;
using TodoApp.Model;

namespace TodoApp.Tests
{
    public class PeopelTests
    {
        [Fact]
        public void SizeTest()
        {
             Person[] personarray = new Person[] { };

            personarray = new People.Size();

            Assert.Equal(1, personarray.Length);

        }

        [Fact]
        public void FindAllTest()
        {

        }

        [Fact]
        public void FindByIdTest()
        {

        }

        [Fact]
        public void NewPersonTest()
        {

        }

        [Fact]
        public void ClearTest()
        {

        }





        public PeopelTests()
        {
        }
    }
}
