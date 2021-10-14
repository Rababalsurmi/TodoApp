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

        [Fact]
        public void NewPersonTest()
        {
            String firstName = "Tom";
            String lastName = "Andersson";
            Person newperson = new Person();

            
            Person actual = People.NewPerson(firstName, lastName);


            Assert.Equal(newperson, actual);
        }

        [Fact]
        public void ClearTest()
        {
            Person[] personarray = new Person[] { };

            People testClear = new People();

            testClear.Clear();

            Assert.Empty(personarray);

        }





        public PeopelTests()
        {
        }
    }
}
