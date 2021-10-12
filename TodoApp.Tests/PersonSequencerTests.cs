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
            int personId = 1;

            PersonSequencer testPersonId = null;
            testPersonId = new PersonSequencer();

            Assert.NotNull(testPersonId);
            Assert.Equal(2, personId);
        }

        [Fact]
        public void ResetPersonIdTest()
        {
            int personId = 1;

            PersonSequencer testPersonId = null;
            testPersonId = new PersonSequencer();

            Assert.Equal(0, personId);
        }
    }
}
