using System;
using Xunit;
using TodoApp.Data;

namespace TodoApp.Tests
{
    public class PersonSequencerTests
    {
        [Fact]
        public void NextPersonIdTest()
        {
            var testPersonId = TodoApp.Data.PersonSequencer.nextPersonId();

            Assert.Equal(1, testPersonId);
        }

        [Fact]
        public void ResetPersonIdTest()
        {
            var testPersonId = TodoApp.Data.PersonSequencer.reset();

            Assert.Equal(0, testPersonId);
        }
    }
}
