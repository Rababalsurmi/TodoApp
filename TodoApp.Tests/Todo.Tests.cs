using System;
using Xunit;
using TodoApp.Model;
namespace TodoApp.Tests
{
    public class TodoTests
    {
        [Fact]
        public void TodoConstructor()
        {
            String description = "Student in Lexicon";
            int todoId = 1;

            Todo testDescription = null;
            testDescription = new Todo(todoId, description);

            Assert.NotNull(testDescription);
            Assert.Equal(testDescription.Description, description);
            Assert.Equal(testDescription.Id, todoId);
        }

        [Theory]
        [InlineData(null)]
        [InlineData(-1)]
        public void TodoIdTest(int todoId)
        {
            String description = "Student in Lexicon";

            Todo testDescription = null;
            testDescription = new Todo(todoId, description);

            Assert.NotNull(testDescription);
            Assert.Equal(testDescription.Description, description);
            Assert.Equal(testDescription.Id, todoId);
        }
    }
}
