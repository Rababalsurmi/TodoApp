using System;
using Xunit;
using TodoApp.Model;
namespace TodoApp.Tests
{
    public class PersonTests
    {
        [Fact]
        public void Constructor()
        {
            String firstName = "John";
            String lastName = "Andersson";

            Person testPerson = null;
            testPerson = new Person(firstName, lastName);

            Assert.NotNull(testPerson);
            Assert.Equal(testPerson.FirstName, firstName);
            Assert.Equal(testPerson.LastName, lastName);
        }
    }
}
