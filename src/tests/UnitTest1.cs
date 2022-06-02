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

        [Fact]
        public void PassesTestFour()
        {
            Assert.Equal("world", "world" + "");
        }

        [Fact]
        public void FailsTestFive()
        {
            Assert.Equal(42, (42 + 1));
        }

        [Fact]
        public void FailsTestSix()
        {
            Assert.Equal(99, (99 - 1));
        }

        [Fact]
        public void FailsTestSeven()
        {
            Assert.Equal("hello", "wo" + "rld");
        }

        [Fact]
        public void FailsTestEight()
        {
            Assert.Equal("world", "hello" + "");
        }

        [Fact(Skip="skips test nine")]
        public void SkipsTestNine()
        {
            Assert.Equal(42, 99);
        }

        [Fact(Skip="skips test ten")]
        public void SkipsTestTen()
        {
            Assert.Equal(72, 72);
        }
    }
}