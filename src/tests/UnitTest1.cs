using System;
using Xunit;


namespace tests
{
    public class UnitTest1
    {
        
        [Fact]
        public void PassesTestOne()
        {
            Assert.Equal(42, (21 + 21));
        }

        [Fact]
        public void PassesTestTwo()
        {
            Assert.Equal(99, (33 * 3));
        }

        [Fact]
        public void PassesTestThree()
        {
            Assert.Equal("hello", "he" + "llo");
        }
/*
        [Fact]
        public void FailsTestFour()
        {
            Assert.Equal(42, (42 + 1));
        }

        [Fact]
        public void FailsTestFive()
        {
            Assert.Equal(42, (42 + 2));
        }
*/
        [Fact(Skip="skips test six")]
        public void SkipsTestSix()
        {
            Assert.Equal(72, 72);
        }
    }
}
