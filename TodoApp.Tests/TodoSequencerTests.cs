using System;
using Xunit;
using TodoApp.Data;
namespace TodoApp.Tests
{
    public class TodoSequencerTests
    {
        [Fact]
        public void NextTodoTest()
        {
            var testTodoId = TodoApp.Data.TodoSequencer.nextTodo();

            Assert.Equal(1, testTodoId);
        }

        [Fact]
        public void ResetTodoIdTest()
        {
            var testTodoId = TodoApp.Data.TodoSequencer.resetTodoId();

            Assert.Equal(0, testTodoId);
        }
    }
}
