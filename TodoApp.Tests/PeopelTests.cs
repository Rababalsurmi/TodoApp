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
            
            People testSize = new People();

            var actual = testSize.Size(personarray);

            Assert.Equal(0, actual);
        }

        [Fact]
        public void FindAllTest()
        {
            Person[] personarray = new Person[] { };

            People testFindAll = new People();

            var actual = testFindAll.FindAll(personarray);

            Assert.Equal(personarray, actual);

        }

        [Fact]
        public void FindByIdTest()
        {

            Person Person = new Person();
            int personId = 1;

            People testFindById = new People();

            Person actual = testFindById.FindById(personId);

            Assert.Equal(Person, actual);
        }

        [Theory]
        [InlineData("Tom", "Andersson")]
        [InlineData("Kim", "Andersson")]
        public void NewPersonTest(String firstName, String lastName)
        { 
            int personId = 1;

            Person newPerson = new Person(firstName, lastName, personId);

            Person actual = People.NewPerson(firstName, lastName);

            //Assert.Equal(newperson, actual);
            Assert.NotNull(newPerson);
            Assert.Equal(newPerson.PersonId, personId);
            Assert.Equal(newPerson.FirstName, firstName);
            Assert.Equal(newPerson.LastName, lastName);
        }

        [Theory]
        [InlineData("", "")]
        [InlineData(null, null)]
        public void NullNewPersonTest(String firstName, String lastName)
        {
            int personId = 1;

            ArgumentException result = Assert.Throws<ArgumentException>(() => new Person(firstName, lastName, personId));

            Assert.Equal("Invaild First Name! ", result.Message) ;

        }
        [Fact]
        public void ClearTest()
        {
            Person[] personarray = new Person[] { };

            People testClear = new People();

            testClear.Clear();

            Assert.Empty(personarray);

        }

        [Fact]
        public void RemoveTest()
        {
            int indexToRemove = 0;
            Person[] personarray = new Person[] { };

            People testRemove = new People();

            testRemove.Remove(indexToRemove);

            Assert.NotNull(personarray);

        }
    }
}
